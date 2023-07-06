using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TodoList.Entities.Concrete;
using TodoList.Entities.DTOs;

namespace TodoList.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskList, TaskAddDTo>().ReverseMap();
            
            CreateMap<TaskList, TaskListDTO>().ReverseMap();
        }
    }
}