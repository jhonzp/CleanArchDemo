using cleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace cleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }

}
