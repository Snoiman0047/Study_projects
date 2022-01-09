using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    [Table("Apart_ForRent")]
    class Apart_ForRent : Apartment
    {
        //[Key, Requierd, DataBaseGenerated(DatabaseGeneratedOption.None), MaxLenght(4)] public string Rent_Id { get; set; }
        public virtual List<Furniture> Furnitures { get; set; } = new List<Furniture>();
        [Requierd] public int Contract_period { get; set; }
        public bool? With_elevator { get; set; } 
        public bool? With_airConditioning { get; set; }
        public DateTime? Evacuation_date { get; set; }
 
        public virtual List<Owner_Details> Apart_Owners { get; set; } = new List<Owner_Details>();

    }
}
