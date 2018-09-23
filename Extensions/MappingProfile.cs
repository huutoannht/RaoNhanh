using AutoMapper;
using NetCore.Models.EntitiesFramework;
using NetCore.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Extensions
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
