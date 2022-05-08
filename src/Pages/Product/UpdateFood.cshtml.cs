﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite.Pages.Product
{
    /// <summary>
    /// This class defines the pgae model of UpdateFood page 
    /// </summary>
    public class UpdateFoodModel : PageModel
    {
        // service for acuiring data
        public JsonFileProductService ProductService { get; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="productService"></param>
        public UpdateFoodModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        /// <summary>
        /// This function is called when GET requested
        /// </summary>
        public void OnGet()
        {
        }
    }
}
