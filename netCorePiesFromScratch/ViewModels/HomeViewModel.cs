using netCorePiesFromScratch.Models;
using System.Collections.Generic;

namespace netCorePiesFromScratch.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
