using StudentsApi.Models;

namespace StudentsApi.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<IEnumerable<Student>> GetAllStudentsByName(string name);
        Task CreateStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
