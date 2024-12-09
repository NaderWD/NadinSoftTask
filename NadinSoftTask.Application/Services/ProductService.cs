using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NadinSoftTask.Application.Interfaces;
using NadinSoftTask.Application.ViewModels;
using NadinSoftTask.Domain.Interfaces;
using NadinSoftTask.Domain.Models;

namespace NadinSoftTask.Application.Services
{
    public class ProductService : IProductServices
    {
        private readonly IproductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IproductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddProduct(Product product)
        {
            _repository.Add(product);
        }

        public void DeleteProductById(int id)
        {
            _repository.DeleteById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var model = _repository.GetAll();
            var result = _mapper.Map<IEnumerable<Product>>(model);
            return result;
        }

        public Product GetProductById(int id)
        {
            var model = _repository.GetById(id);
            return model;
        }

        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
        }
    }
}
