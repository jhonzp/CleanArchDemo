using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace cleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
