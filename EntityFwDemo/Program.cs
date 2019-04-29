using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GlobeEntities globeEntiites = new GlobeEntities())
            {
                List<Country> countries = (from c in globeEntiites.Countries
                                select c).ToList();
                List<Country> countriesMS = globeEntiites.Countries.ToList();

                globeEntiites.Countries.Add(new Country() { NAME = "Ireland", POPULTAION = 570000 });
                globeEntiites.SaveChanges();
                    
                Console.WriteLine();
            }
        }
    }
}
