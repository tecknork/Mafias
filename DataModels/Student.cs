using DataLayer.DataLayerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Student
    {
       
        public int StudentID { get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }



        public Student convert(MStudent student)
        {

            this.Name = student.Name;
            this.RollNo = student.RollNo;

            return this;
        }

        public MStudent getMStudent()
        {
            return new MStudent()
            {
                Class = this.Class,
                Name = this.Name,
                RollNo = this.RollNo,
                StudentID = this.StudentID
            };

        }

    }
}
