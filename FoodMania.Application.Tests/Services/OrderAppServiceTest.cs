using AutoMapper;
using FoodMania.Application.Orders.Services;
using FoodMania.Domain.Orders.Interfaces;
using MassTransit;
using Moq;
using Xunit;

namespace FoodMania.Application.Tests.Services
{
    public class OrderAppServiceTest
    {
        OrderAppService _orderAppService;
        Mock<IOrderRepository> _orderRepositoryMock;
        Mock<IMapper> _mapperMock;
        Mock<IPublishEndpoint> _sendProviderMock;
        public OrderAppServiceTest()
        {
            _orderRepositoryMock = new Mock<IOrderRepository>();
            _mapperMock = new Mock<IMapper>();
            _sendProviderMock = new Mock<IPublishEndpoint> { CallBase = true };

            _orderAppService = new OrderAppService(
                _orderRepositoryMock.Object,
                _mapperMock.Object,
                _sendProviderMock.Object);
        }

        [Fact]
        public void GetOrder()
        {

        }
    }
}
