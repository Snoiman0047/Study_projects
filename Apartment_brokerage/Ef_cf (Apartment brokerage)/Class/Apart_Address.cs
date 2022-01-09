using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_cf__Apartment_brokerage_.Class
{
    class Apart_Address
    {
        [Requierd] public string City { get; set; }
        [Requierd] public string Street { get; set; }
        [Requierd] public int Floor { get; set; }
        public int? House_num { get; set; }

    }
}
