﻿using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController:ControllerBase
    {
        private readonly ILoggingService _loggingService;

        public ValuesController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Synergy>> Get()
        {
            _loggingService.CreateElement();
            return _loggingService.GetData();
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
