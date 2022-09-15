using Microsoft.AspNetCore.Mvc;
using TZ_FIZIKON.Interface;
using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursController : Controller
    {
        private readonly ILogger<CoursController> _logger;
        private IRepository _repository;

        public CoursController(ILogger<CoursController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            try
            {
                _logger.LogInformation("Запрос GetModules получен");

                var result = await _repository.GetCourses();

                _logger.LogInformation("Запрос GetModules выполнен");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetCoursesSubject")]
        public async Task<IActionResult> GetCoursesSubject()
        {
            try
            {
                _logger.LogInformation("Запрос GetCoursesSubject получен");

                var result = await _repository.GetCourseSubject();

                _logger.LogInformation("Запрос GetCoursesSubject выполнен");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetCoursesGenre")]
        public async Task<IActionResult> GetCoursesGenre()
        {
            try
            {
                _logger.LogInformation("Запрос GetCoursesGenre получен");

                var result = await _repository.GetCourseGenre();

                _logger.LogInformation("Запрос GetCoursesGenre выполнен");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetCoursesGrade")]
        public async Task<IActionResult> GetCourseGrade()
        {
            try
            {
                _logger.LogInformation("Запрос GetCoursesGrade получен");

                var result = await _repository.GetCourseGrade();

                _logger.LogInformation("Запрос GetCoursesGrade выполнен");

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }

    }
}