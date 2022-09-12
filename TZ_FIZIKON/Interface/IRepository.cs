using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Interface
{
    public interface IRepository
    {
        public Task<IEnumerable<Modules>> GetModel();

        public Task<IEnumerable<Courses>> GetCourses();
    }
}
