using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using NadinSoftTask.Application.Profiles;
using NadinSoftTask.Application.Services;
using NadinSoftTask.Domain.Interfaces;
using NadinSoftTask.Domain.Models;
using NadinSoftTask.Infra.Data.Repository;
using NadinSoftTask.Test.Mocks;
using Shouldly;

namespace NadinSoftTask.Test.Products
{
    public class GetAllProductsTest
    {
        IMapper _mapper;
        Mock<IproductRepository> _mockrepository;
        public GetAllProductsTest()
        {
            _mockrepository = MockProductRepository.GetProductRepository();
            var mapper = new MapperConfiguration(m =>
                {
                    m.AddProfile<MappingProfiles>();
                });
            _mapper = mapper.CreateMapper();
        }

        [Fact]
        public Task GetProductTest()
        {
            var handler = new ProductService(_mockrepository.Object, _mapper);
            var result = handler.GetAllProducts();
            
            result.ShouldBeOfType<List<Product>>();
            result.Count().ShouldBe(2);

            return Task.CompletedTask;
        }
    }
}
