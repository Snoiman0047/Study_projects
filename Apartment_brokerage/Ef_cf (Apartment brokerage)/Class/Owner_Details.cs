using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    class Owner_Details
    {
        [Key, MaxLength(9), MinLength(9), DataBaseGenerated(DatabaseGeneratedOption.None)] public string Tz { get; set; }
        [Requierd, MaxLenght(25)] public string Lname { get; set; }
        [Requierd, MaxLenght(25)] public string Fname { get; set; }
        [MaxLenght(10)] public string Phone_number { get; set; }
        [Requierd, MaxLenght(12)] public string MobilePhone_number { get; set; }

        public virtual List<Apartment> Aparts { get; set; } = new List<Apartment>();

    }
}
