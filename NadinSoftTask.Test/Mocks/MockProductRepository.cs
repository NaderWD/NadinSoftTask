using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NadinSoftTask.Domain.Interfaces;
using NadinSoftTask.Domain.Models;

namespace NadinSoftTask.Test.Mocks
{
    public static class MockProductRepository
    {
        public static Mock<IproductRepository> GetProductRepository()
        {
            var product = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Hulu",
                    ManufacturePhone = "02112345678",
                    ManufactureEmail = "Hulu@gmail.com",
                    IsAvailable = true,
                },

                new Product
                {
                    Id = 2,
                    Name = "Moz",
                    ManufacturePhone = "02187654321",
                    ManufactureEmail = "Moz@gmail.com",
                    IsAvailable = true,
                }
            };

            var mocrepo = new Mock<IproductRepository>();

            mocrepo.Setup(r => r.GetAll()).Returns(product);
             
            return mocrepo;
        }
    }
}
