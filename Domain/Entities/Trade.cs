using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Trade : ITrade
    {
        private static int tradeID = 1;

        private string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        
        public Trade()
        {
            this.name = "Trade" + tradeID++;
            
        }

        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            this.name = "Trade" + tradeID++;
            this.Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        public override string ToString()
        {
            return
                this.Value + " " +  this.ClientSector + " " +
                this.NextPaymentDate.ToString("MM/d/yyyy") ;

        }


    }
}
