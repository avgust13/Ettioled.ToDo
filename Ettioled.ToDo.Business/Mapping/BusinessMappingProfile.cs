using AutoMapper;
using Ettioled.ToDo.Business.Data;
using Ettioled.ToDo.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.Business.Mapping
{
    public class BusinessMappingProfile : Profile
    {
        public BusinessMappingProfile()
        {
            CreateMap<ToDoData, ToDoRecord>();
        }
    }
}
