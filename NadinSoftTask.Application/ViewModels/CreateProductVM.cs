using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoftTask.Application.ViewModels
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public PhoneAttribute ManufacturePhone { get; set; }
        public EmailAddressAttribute ManufactureEmail { get; set; }
    }
}
