using Microsoft.AspNetCore.Mvc;
using TZ_FIZIKON.Interface;
using TZ_FIZIKON.Models.Entity;

namespace TZ_FIZIKON.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository _repository;

        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }



        [HttpGet]
        [Route("GetModules")]
        public async Task<IActionResult> GetModules()
        {
            try
            {
                _logger.LogInformation("Запрос GetModules получен");

                var result = await _repository.GetModel();

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

    }
}