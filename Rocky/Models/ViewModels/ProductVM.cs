﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Rocky.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<SelectListItem>CategorySelectList { get; set; }


    }
}
