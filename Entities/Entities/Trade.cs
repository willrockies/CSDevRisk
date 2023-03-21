using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Entities
{
    public class Trade : ITrade
    {
        private static int tradeID = 1;

        private string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }

        public Trade()
        {
            this.name = "Trade" + tradeID++;
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
