using System;
using System.Collections.Generic;
using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ILoggingRepository _loggingRepository;

        public LoggingService(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        public List<Synergy> GetData()
        {
            return _loggingRepository.Get();

        }

        public void CreateElement()
        {
            var Temp = new Synergy()
            {
                Text = "Funciuonacorrectamente",
                Date = DateTime.Now
            };
            _loggingRepository.CreateElement(Temp);
        }
    }
}
