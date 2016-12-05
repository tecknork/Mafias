using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
 public interface IStudentManager
    {
          string Insert(Student student);
        Student Get(string i);
        List<Student> GetAll();
        //void Delete(int id);
        //void Update(Student student);

    }
}
