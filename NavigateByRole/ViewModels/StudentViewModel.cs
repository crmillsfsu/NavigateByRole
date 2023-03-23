using NavigateByRole.FakeBackendStuff.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByRole.ViewModels
{
    public class StudentViewModel
    {
        private StudentService _studentSvc;

        public StudentViewModel()
        {
            _studentSvc = new StudentService();
        }
    }
}
