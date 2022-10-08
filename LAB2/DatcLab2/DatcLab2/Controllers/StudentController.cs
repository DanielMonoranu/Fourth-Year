using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace DatcLab2.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class StudentController
    {
        public static List<Student> students = new List<Student>();

        [HttpGet]
        [Route("[controller]/GetStudents")]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        [HttpPost]
        [Route("[controller]/PostStudents")]
        public Student Post([FromBody] Student student)

        {
            students.Add(student);
            return student;
        }

        [HttpDelete]
        [Route("[controller]/DeleteStudents")]
        public HttpResponseMessage Delete([FromBody] string name)
        {
            var studentToDelete = students.Where(x => x.Name == name).FirstOrDefault();
            var response = new HttpResponseMessage();

            if (studentToDelete == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.Headers.Add("Message", "Student not found!");
            }
            else
            {
                students.Remove(studentToDelete);
                response.StatusCode = HttpStatusCode.OK;
                response.Headers.Add("Message", "Succsessfuly Deleted!!!");
            }
            return response;

        }

        [HttpPut]
        [Route("[controller]/UpdateStudents")]
        public HttpResponseMessage Update([FromHeader] string name, [FromBody] Student student)

        {
            var studentToUpdate = students.Where(x => x.Name == name).FirstOrDefault();
            var response = new HttpResponseMessage();

            if (studentToUpdate == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.Headers.Add("Message", "Student not found!");
            }
            else
            {
                studentToUpdate.Name = student.Name;
                studentToUpdate.Faculty = student.Faculty;
                studentToUpdate.Year = student.Year;

                response.StatusCode = HttpStatusCode.OK;
                response.Headers.Add("Message", "Succsessfuly Updated!!!");
            }
            return response;
        }



    }

}