using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Services.Interface
{
    public interface ICoursesServices
    {
        public Task<IEnumerable<Modules>> GetModel();

        public Task<IEnumerable<Courses>> GetCourses();
    }
}
