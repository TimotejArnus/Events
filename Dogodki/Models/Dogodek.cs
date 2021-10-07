using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dogodki.Models
{
    public class Dogodek
    {       
        public int ID { get; set; } //  for DB, EF will consider this primary key automatically

        [Required]
        public DateTime DatumZacetka { get; set; }        
        public DateTime DatumKonca { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }

        public Dogodek(DateTime DatumZacetka, DateTime DatumKonca, string Naziv, string Opis)   // Conctructor for every property
        {            
            this.DatumZacetka = DatumZacetka;
            this.DatumKonca = DatumKonca;
            this.Naziv = Naziv;
            this.Opis = Opis;
        }
        public Dogodek(DateTime DatumZacetka, string Naziv, string Opis)   // Conctructor without DatumKonca
        {
            this.DatumZacetka = DatumZacetka;          
            this.Naziv = Naziv;
            this.Opis = Opis;
        }

        public Dogodek() { }    // Default constructor, we need it for making changes to DB

    }
}
