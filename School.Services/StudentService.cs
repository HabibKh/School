using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        public async Task Register()
        {
            var student = new { Id = 1, Name = "Hab" };
            await Task.Run(() => Debug.Write(student));
        }
    }
}
