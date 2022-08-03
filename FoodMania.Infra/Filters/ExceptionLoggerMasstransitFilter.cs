
using MassTransit;
using MassTransit.Configuration;

namespace FoodMania.Infra.Filters
{
    public class ExceptionLoggerMasstransitFilter<T> : IFilter<T> where T : class, PipeContext
    {
        public void Probe(ProbeContext context)
        {
            context.CreateFilterScope("ExceptionFilter");
        }

        public async Task Send(T context, IPipe<T> next)
        {
            try
            {
                await next.Send(context);
            }
            catch (Exception ex)
            {
                //include log

                throw;
            }
        }
    }
    public static class ExampleMiddlewareConfiguratorExtensions
    {
        public static void UseExceptionLogger<T>(this IPipeConfigurator<T> configurator)
            where T : class, PipeContext
        {
            configurator.AddPipeSpecification(new ExceptionLoggerSpecification<T>());
        }
    }

    public class ExceptionLoggerSpecification<T> : IPipeSpecification<T>
        where T : class, PipeContext
    {
        public IEnumerable<ValidationResult> Validate()
        {
            return Enumerable.Empty<ValidationResult>();
        }

        public void Apply(IPipeBuilder<T> builder)
        {
            builder.AddFilter(new ExceptionLoggerMasstransitFilter<T>());
        }
    }
}
