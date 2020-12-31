﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RMDataManager.Library.Models;
using RMDataManager.Library.DataAccess;

namespace RMDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {

        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
