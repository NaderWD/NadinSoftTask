using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NadinSoftTask.Domain.Models;
using NadinSoftTask.Domain.ViewModels;

namespace NadinSoftTask.Domain.Interfaces
{
    public interface IproductRepository
    {
        IEnumerable<ProductListVM> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void DeleteById(int id);

    }
}
