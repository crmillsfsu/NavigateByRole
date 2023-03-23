using NavigateByRole.FakeBackendStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.FakeBackendStuff.Services
{
    public class StudentService
    {
        public List<Student> Get()
        {
            return FakeDatabase.Students;
        }
    }
}
