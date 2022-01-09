using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    class Furniture
    {
        [DataBaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        [Requierd]public string Name { get; set; }

        public virtual List<Apartment> Aparts { get; set; } = new List<Apartment>();

    }
}
