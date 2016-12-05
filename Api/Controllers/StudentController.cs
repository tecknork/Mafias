using Api.Hubs;
using BusinessLayer;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class StudentController : HubApiController<StudentHub>
    {
        private readonly StudentManager _studentService;

        public StudentController()
        {
            _studentService = new StudentManager();
        }

        // GET api/student/id
        public HttpResponseMessage Get(string id)
        {

            var student = _studentService.Get(id);
            if (student != null)
                return Request.CreateResponse(HttpStatusCode.OK, student);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student not found for provided id.");
        }

        public HttpResponseMessage GetAll()
        {
            var students = _studentService.GetAll();
            if (students.Any())
                return Request.CreateResponse(HttpStatusCode.OK, students);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No students found.");
        }

        public HttpResponseMessage Post([FromBody]Student student)
        {
            var id = _studentService.Insert(student);
            Hub.Clients.All().addItem(student);
            return Request.CreateResponse(HttpStatusCode.OK, id);
           // return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No students found.");
        }
        //public void Delete(string id)
        //{
        //    _studentService.Delete(id);
        //}
        //public void Put([FromBody]Student student)
        //{
        //    _studentService.Update(student);
        //}
    }
}
