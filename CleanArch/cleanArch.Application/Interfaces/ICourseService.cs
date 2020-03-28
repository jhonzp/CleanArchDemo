using cleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace cleanArch.Application.Interfaces
{
    public interface ICourseService
    {
       CourseViewModel GetCourses();
        void Add(CourseViewModel course);
    }

}
