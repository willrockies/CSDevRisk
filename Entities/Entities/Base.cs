using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Entities
{
    public class Base
    {
        private static int tradeID = 1;

        private string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }

        public Base()
        {
            this.name = "Trade" + tradeID++;
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }
    }
}
