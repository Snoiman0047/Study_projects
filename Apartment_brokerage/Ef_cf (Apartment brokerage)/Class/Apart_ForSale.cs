using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    [Table("Apart_ForSale")]
    class Apart_ForSale : Apartment
    {
        //[Key, Requierd,  DataBaseGenerated(DatabaseGeneratedOption.None), MaxLenght(4)] public string Sale_Id { get; set; }
        public Nullable<bool> Common_taboo { get; set; }
        public int? Neighbors { get; set; }

    }
}
