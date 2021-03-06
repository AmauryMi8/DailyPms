using System.Collections.Generic;
using System.Threading.Tasks;
using DailyPmsAPI.Models;

namespace DailyPmsAPI.Data
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();

        Task<IEnumerable<Student>> GetAllStudentsBySchoolAsync(string schoolId);

        Task<IEnumerable<Student>> GetAllStudentsByClasseAsync(string classeId, string schoolId);

        Task<Student> GetStudentByIdAsync(string id);

        Task<IEnumerable<Student>> GetStudentsByNameAsync(string name);

        Task CreateStudentAsync(Student newStudent);

        Task UpdateStudentByIdAsync(string id, Student updatedStudent);

        Task DeleteStudentByIdAsync(string id);
    }
}
