using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NadinSoftTask.Domain.Models;
using NadinSoftTask.Application.ViewModels;

namespace NadinSoftTask.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductVM, Product>();
            CreateMap<UpdateProductVM, Product>();
            CreateMap<ProductListVM, Product>();
        }
    }
}
