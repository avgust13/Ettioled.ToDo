using AutoMapper;
using Ettioled.ToDo.Business.Mapping;
using Ettioled.ToDo.Web.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ettioled.ToDo.Web.App_Start
{
    public class MapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(x =>
			{
				x.AddProfile<BusinessMappingProfile>();
                x.AddProfile<WebMappingProfile>();
            });
        }
    }
}