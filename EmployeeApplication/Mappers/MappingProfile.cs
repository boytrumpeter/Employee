namespace EmployeeApplication.Mappers
{
    using AutoMapper;
    using EmployeeApplication.Models;
    using EmployerDomain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeModel>()
                .ReverseMap();
        }
    }
}
