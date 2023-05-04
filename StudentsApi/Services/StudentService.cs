using Microsoft.EntityFrameworkCore;
using StudentsApi.Context;
using StudentsApi.Models;

namespace StudentsApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            try
            {
                return await _context.Students.AsNoTracking().ToListAsync();
            }
            catch 
            {
                throw;
            }
           
        }

        public async Task<IEnumerable<Student>> GetStudentsByName(string name)
        {
            IEnumerable<Student> students;

            if (!string.IsNullOrEmpty(name))
            {
                students = await _context.Students.Where(x => x.Name == name).AsNoTracking().ToListAsync();
            }
            else
            {
                students = await GetAllStudents();
            }
            return students;

        }


        public async Task CreateStudent(Student student)
        {
            try
            {
               _context.Students.Add(student);
               await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw ;
            }
        }

        public async Task DeleteStudent(Guid id)
        {
            try
            {
                var student = _context.Students.FirstOrDefault(x => x.Id.Equals(id));
                if (student != null)
                {
                    _context.Students.Remove(student);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<Student> GetStudentById(int id)
        {
            try
            {
                var student = await _context.Students.FindAsync(id);
                return student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
