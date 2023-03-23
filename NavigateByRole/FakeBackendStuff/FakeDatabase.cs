using NavigateByRole.FakeBackendStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.FakeBackendStuff
{
    public static class FakeDatabase
    {
        public static List<Student> Students
        {
            get
            {
                return new List<Student> { 
                    new Student{Id = 1, Name = "Student1"}
                    , new Student{Id = 2, Name = "Student2"}
                    , new Student{Id = 2, Name = "Student3"}
                    , new Student{Id = 2, Name = "Student4"}
                    , new Student{Id = 2, Name = "Student5"}
                    , new Student{Id = 2, Name = "Student6"}
                    , new Student{Id = 2, Name = "Student7"}
                    , new Student{Id = 2, Name = "Student8"}
                    , new Student{Id = 2, Name = "Student9"}
                    , new Student{Id = 2, Name = "Student10"}
                };
            }
        }

        public static List<Course> Courses
        {
            get
            {
                return new List<Course>
                {
                    new Course
                    {
                        Id = 1,
                        Name = "Course1",
                    }
                };
            }
        }
    }
}
