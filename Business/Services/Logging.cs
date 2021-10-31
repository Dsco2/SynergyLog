using Business.Interfaces;

namespace Business.Services
{
    public class Logging : ILogging
    {
        private readonly ILoggingRepository _loggingRepository;

        public Logging(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        public string Test()
        {
            return _loggingRepository.Test();
            //return "Hola mundo";
        }
    }
}
