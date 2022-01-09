using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    abstract class Apartment
    {
        [Key, DataBaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        public Apart_Address Address { get; set; }
        public bool North { get; set; } = false;
        public bool South { get; set; } = false;
        public bool East { get; set; } = false;
        public bool West { get; set; } = false;
        public int? Num_rooms { get; set; }
        public int? Price { get; set; }

    }
}
