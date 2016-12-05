using DataLayer.DataLayerModels;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
  public  class StudentRepository:MongoRepository<MStudent> 
    {

        public MStudent GetStudent(string val)
        {
            var variable= this.GetById(val);
            return variable;
        }

      
        public List<MStudent> GetAll()
        {
            var enumrator = this.GetEnumerator();

            var list = new List<MStudent>();
            while (enumrator.MoveNext())
            {
                list.Add(enumrator.Current);
            }
            return list;
           

        }
        public string Insert(MStudent m)
        {
            var newStudent = this.Add(m);
            return newStudent.Id;
        }
    }
}
