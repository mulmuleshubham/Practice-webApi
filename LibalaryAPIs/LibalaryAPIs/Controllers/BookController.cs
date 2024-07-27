using Microsoft.AspNetCore.Mvc;

namespace LibalaryAPIs.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : ControllerBase
    {
     
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAllBooks")]
        public IEnumerable<string> GetAllBooks()
        {
            List<string> books = new List<string>()
            {
                "book 1", "book 2", "book 3"
            };
            return books;
        }
    }
}