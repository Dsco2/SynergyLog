using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Models;
using Business.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController:ControllerBase
    {
        private readonly ILogging _logging;
        private readonly IBookstoreDatabaseSettings _bookstoreDatabase;
        private readonly BookService _bookService;

        public ValuesController(ILogging logging, IBookstoreDatabaseSettings bookstoreDatabase, BookService bookService)
        {
            _logging = logging;
            _bookstoreDatabase = bookstoreDatabase;
            _bookService = bookService;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var test = _bookService.Create(new Book());
            var temp = _bookService.Get();
            return new string[] {_logging.Test()};
            //return new string[] { "value1","value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
