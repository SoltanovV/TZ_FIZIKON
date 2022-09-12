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

        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public async Task<IEnumerable<Modules>>  GetModel()
        {
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    var sql = "SELECT * FROM Courses JOIN Modules ON Courses.id = Modules.CourseId";
                    var res = await db.QueryMultipleAsync(sql);
                    var mod = res.Read<Modules>();
                    var cour = res.Read<Courses>();

                    //return cour.Select(c => new Courses
                    //{
                    //    Modules = mod.Where(m => m.CourseId == c.Id).ToList()
                    //});
                    return mod;
                   
                }
                catch(Exception ex)
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
                    //var sql = "SELECT * FROM Courses JOIN Modules ON Courses.id = Modules.CourseId";
                    var sql = " select * from Courses where 1 = 1 select * from Modules where 1 = 1";
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
                        Modules = mod.Where(m => m.CourseId == c.Id).ToList()
                    });
                    return d.OrderBy(d => d.Title);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
    }
}
