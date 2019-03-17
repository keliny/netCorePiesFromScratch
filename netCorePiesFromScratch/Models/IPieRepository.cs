using System.Collections.Generic;

namespace netCorePiesFromScratch.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}