using NadinSoftTask.Domain.Interfaces;
using NadinSoftTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NadinSoftTask.Infra.Data.Context;

namespace NadinSoftTask.Infra.Data.Repository
{
    public class ProductRepository(NadinTaskDB dbcontext, IMapper mapper) : IproductRepository
    {
        private readonly NadinTaskDB _dbcontext = dbcontext;
        private readonly IMapper _mapper = mapper;

        public void Add(Product product)
        {
            var model = _mapper.Map<Product>(product);
            _dbcontext.Products.Add(model);
            _dbcontext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var model = _dbcontext.Products.Find(id);
            if (model != null)
            {
                _dbcontext.Products.Remove(model);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            var model = _dbcontext.Products.ToList();
            _mapper.Map<IEnumerable<Product>>(model);
            return model;
        }

        public Product GetById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _dbcontext.Products.Find(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public void Update(Product product)
        {
            var model = _dbcontext.Products.Find(product);
            var result = _mapper.Map<Product>(model);
            _dbcontext.Products.Update(result);
            _dbcontext.SaveChanges();
        }
    }
}
