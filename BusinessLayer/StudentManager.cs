using DataLayer.Repository;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class StudentManager : IStudentManager
    {
        private readonly StudentRepository _sUnitOfwork;

        public StudentManager()
        {
            _sUnitOfwork = new StudentRepository();
        }

        public Student Get(string i)
        {
            var student= _sUnitOfwork.GetStudent(i);

            return new Student().convert(student);
        }

      
    }
}
