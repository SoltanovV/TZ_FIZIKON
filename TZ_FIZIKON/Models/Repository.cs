using Dapper;
using System.Data;
using System.Data.SqlClient;
using TZ_FIZIKON.Interface;
using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Models
{
    public class Repository : IRepository
    {
        string connectionString = null;
        protected string sql = "SELECT * FROM Courses WHERE 1 = 1 SELECT * FROM Modules WHERE 1 = 1";
        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public async Task<IEnumerable<Courses>> GetCourseSubject()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    var res = db.QueryMultiple(sql);
                    var cour = res.Read<Courses>();
                    var mod = res.Read<Modules>();
                    var d = cour.Select(c => new Courses
                    {
                        Id = c.Id,
                        ExternalId = c.ExternalId,
                        Genre = c.Genre,
                        Grade = c.Grade,
                        Hash = c.Hash,
                        Status = c.Status,
                        Subject = c.Subject,
                        Title = c.Title,
                        Description = c.Description,
                        Modules = mod.Where(m => m.CourseId == c.Id)
                        .OrderBy(m => m.Order).ToList()
                    });
                    return d.OrderBy(d => d.Subject);

                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

        public async Task<IEnumerable<Courses>> GetCourses()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    var res = db.QueryMultiple(sql);
                    var cour = res.Read<Courses>();
                    var mod = res.Read<Modules>();
                    var d = cour.Select(c => new Courses
                    {
                        Id = c.Id,
                        ExternalId = c.ExternalId,
                        Genre = c.Genre,
                        Grade = c.Grade,
                        Hash = c.Hash,
                        Status = c.Status,
                        Subject = c.Subject,
                        Title = c.Title,
                        Description = c.Description,
                        Modules = mod.Where(m => m.CourseId == c.Id)
                        .OrderBy(m => m.Order).ToList()
                    });
                    return d.OrderBy(d => d.Title);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
        public async Task<IEnumerable<Courses>> GetCourseGrade()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    var res = db.QueryMultiple(sql);
                    var cour = res.Read<Courses>();
                    var mod = res.Read<Modules>();
                    var d = cour.Select(c => new Courses
                    {
                        Id = c.Id,
                        ExternalId = c.ExternalId,
                        Genre = c.Genre,
                        Grade = c.Grade,
                        Hash = c.Hash,
                        Status = c.Status,
                        Subject = c.Subject,
                        Title = c.Title,
                        Description = c.Description,
                        Modules = mod.Where(m => m.CourseId == c.Id)
                        .OrderBy(m => m.Order).ToList()
                    });
                    return d.OrderBy(d => d.Grade);

                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
        public async Task<IEnumerable<Courses>> GetCourseGenre()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    var res = db.QueryMultiple(sql);
                    var cour = res.Read<Courses>();
                    var mod = res.Read<Modules>();
                    var d = cour.Select(c => new Courses
                    {
                        Id = c.Id,
                        ExternalId = c.ExternalId,
                        Genre = c.Genre,
                        Grade = c.Grade,
                        Hash = c.Hash,
                        Status = c.Status,
                        Subject = c.Subject,
                        Title = c.Title,
                        Description = c.Description,
                        Modules = mod.Where(m => m.CourseId == c.Id)
                        .OrderBy(m => m.Order).ToList()
                    });
                    return d.OrderBy(d => d.Genre);

                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
    }
}
