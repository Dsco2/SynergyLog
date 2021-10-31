using Business.Interfaces;

namespace Persistence.Repositories
{
    public class LoggingRepository : ILoggingRepository
    {
        public string Test()
        {
            return "hola mundo";
        }
    }
}
