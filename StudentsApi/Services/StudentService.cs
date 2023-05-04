using StudentsApi.Models;

namespace StudentsApi.Services
{
    public class StudentService : IStudentService
    {
        public Task CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudentsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
