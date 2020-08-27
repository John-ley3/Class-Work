using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Classes
{
    public class BuyOutReserver : ReserveAuction
    {
        public BuyOutReserver(decimal ReservePrice) : base(ReservePrice)
        {

        }
    }
}
