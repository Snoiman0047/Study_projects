using System;

namespace Ef_cf__Apartment_brokerage_.Class
{
    internal class MaxLenghtAttribute : Attribute
    {
        private int v;

        public MaxLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}