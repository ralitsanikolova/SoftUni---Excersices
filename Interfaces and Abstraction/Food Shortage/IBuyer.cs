using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    interface IBuyer
    {
        int Food { get; set; }
        public void BuyFood();
    }
}
