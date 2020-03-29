using AutoMapper;
using cleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace cleanArch.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
