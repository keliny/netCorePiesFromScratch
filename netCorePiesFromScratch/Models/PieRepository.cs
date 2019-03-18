using System.Collections.Generic;
using System.Linq;

namespace netCorePiesFromScratch.Models
{
    public class PieRepository : IPieRepository
    {

        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            DbInitializer.Seed(appDbContext);
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}