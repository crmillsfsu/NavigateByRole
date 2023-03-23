using NavigateByRole.FakeBackendStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.FakeBackendStuff.Services
{
    public class CourseService
    {
        public List<Course> Get()
        {
            return FakeDatabase.Courses;
        }
    }
}
