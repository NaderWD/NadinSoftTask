﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoftTask.Application.ViewModels
{
    public class UpdateProductVM
    {
        public string? Name { get; set; }
        public DateTime ProduceDate { get; set; }
        public string? ManufacturePhone { get; set; }
        public string? ManufactureEmail { get; set; }
        public bool IsAvailable { get; set; }
    }
}
