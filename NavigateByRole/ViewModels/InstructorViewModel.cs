using NavigateByRole.FakeBackendStuff.Models;
using NavigateByRole.FakeBackendStuff.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.ViewModels
{
    public class InstructorViewModel
    {
        private CourseService _courseSvc;
        private StudentService _studentSvc;

        public List<Course> Courses
        {
            get
            {
                return _courseSvc.Get();
            }
        }

        public List<Student> Students
        {
            get
            {
                return _studentSvc.Get();
            }
        }

        public InstructorViewModel()
        {
            _courseSvc= new CourseService();
            _studentSvc= new StudentService();
        }
    }
}
