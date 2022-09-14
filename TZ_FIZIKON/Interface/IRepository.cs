using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Interface
{
    public interface IRepository
    {
        public Task<IEnumerable<Courses>> GetCourses();

        public Task<IEnumerable<Courses>> GetCourseSubject();

        public Task<IEnumerable<Courses>> GetCourseGrade();

        public Task<IEnumerable<Courses>> GetCourseGenre();

    }
}
