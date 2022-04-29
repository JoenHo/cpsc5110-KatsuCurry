﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite.Pages.Product
{
    public class ProductIndexModel : PageModel
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductIndexModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        
    }
}

