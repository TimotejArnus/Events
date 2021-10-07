using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dogodki.Models;

namespace Dogodki.Database
{
    // this class creates pre-defined object and adds them to DB   
    public class DbInitializer
    {
        public static void Initialize(DogodekContext context)
        {
            // if database is not pre-created we create it 
            context.Database.EnsureCreated();

            // create pre-defined objects and add them to list
            List<Dogodek> dogodkiList = new List<Dogodek>
            {
                new Dogodek(new DateTime(2021,10,1,12,0,0), new DateTime(2021,10,1,15,0,0), "Brezplačno usposabljanje s področja energetske učinkovitosti", "Izobrazevanje"),
                new Dogodek(new DateTime(2021,10,2,17,0,0), new DateTime(2021,10,2,20,0,0), "MUSEOEUROPE 2021 ‑ LIVING IN EUROPE", "Zgodovina"),
                new Dogodek(new DateTime(2021,10,3,12,0,0), new DateTime(2021,10,3,17,0,0), "Nastop CRVENA JABUKA", "Glazba"),                
                new Dogodek(new DateTime(2021,10,4,10,0,0), "Mednarodni festival Čili & Čokolada", "Hrana"),
                new Dogodek(new DateTime(2021,10,7,20,0,0), new DateTime(2021,10,5,23,0,0), "Komicni Cetrtek", "Yabava")
            };

            // use list to add objects to database (inMemory)
            foreach(Dogodek dogodek in dogodkiList)
            {
                context.Dogodki.Add(dogodek);
            }

            // write changes to database
            context.SaveChanges();
        }
    }
}
