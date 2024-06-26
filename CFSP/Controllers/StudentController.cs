using CFSP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFSP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly ApplicationDbContext _context;

        public StudentController(ILogger<StudentController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetStudents")]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }
    }
}
