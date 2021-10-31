using System.Collections.Generic;
using Business.Models;

namespace Business.Interfaces
{
    public interface ILoggingRepository
    {
        List<Synergy> Get();
        void CreateElement(Synergy temp);
    }
}
