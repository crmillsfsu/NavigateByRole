using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.FakeBackendStuff.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Roster { get; set; }
        public string Display
        {
            get
            {
                return $"{Id}. {Name}";
            }
        }
        public Course() { 
            Roster= new List<Student>();
        }
    }
}
