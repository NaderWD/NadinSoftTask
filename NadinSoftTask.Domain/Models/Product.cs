using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoftTask.Domain.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("نام")]
        [MaxLength(255)]
        public string? Name { get; set; }

        [DisplayName("تاریخ تولید")]
        public DateTime ProduceDate { get; set; }

        [Required]
        [DisplayName("تلفن همراه")]
        [MaxLength(255)]
        public string? ManufacturePhone { get; set; }

        [Required]
        [DisplayName("آدرس ایمیل")]
        [MaxLength(255)]
        public string? ManufactureEmail { get; set; }

        public bool IsAvailable { get; set; }
    }
}
