using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoftTask.Application.ViewModels
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProduceDate { get; set; }
        public PhoneAttribute ManufacturePhone { get; set; }
        public EmailAddressAttribute ManufactureEmail { get; set; }
        public bool IsAvailable { get; set; }
    }
}
