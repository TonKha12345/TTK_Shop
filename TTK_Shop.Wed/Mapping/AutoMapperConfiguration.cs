using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using TTK_Shop.Model.Models;
using TTK_Shop.Wed.Models;

namespace TTK_Shop.Wed.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
            cfg.CreateMap<Product, ProductViewModel>();
            cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();

            });
        }
    }
}