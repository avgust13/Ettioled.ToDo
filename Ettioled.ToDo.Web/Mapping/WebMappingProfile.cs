using AutoMapper;
using Ettioled.ToDo.Business.Data;
using Ettioled.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ettioled.ToDo.Web.Mapping
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<ToDoViewModel, ToDoData>();
        }
    }
}