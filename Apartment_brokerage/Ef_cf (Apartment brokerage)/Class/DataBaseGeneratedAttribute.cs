using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_cf__Apartment_brokerage_.Class
{
    internal class DataBaseGeneratedAttribute : Attribute
    {
        private DatabaseGeneratedOption none;

        public DataBaseGeneratedAttribute(DatabaseGeneratedOption none)
        {
            this.none = none;
        }
    }
}