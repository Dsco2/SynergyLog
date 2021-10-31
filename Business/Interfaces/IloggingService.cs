using System.Collections.Generic;
using Business.Models;

namespace Business.Interfaces
{
    public interface ILoggingService
    {
        List<Synergy> GetData();
        void CreateElement();
    }
}
