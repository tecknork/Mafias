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

        public List<Student> GetAll()
        {
            var mStudent = _sUnitOfwork.GetAll();

            List <Student> student = new List<Student>();
            foreach(var item in mStudent)
            {
                student.Add(new Student().convert(item));
            }

            return student;
        }

        public string Insert(Student m )
        {
            string id = _sUnitOfwork.Insert(m.getMStudent());

            return id;

        }
    }
}
