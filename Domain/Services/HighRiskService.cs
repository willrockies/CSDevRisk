using Domain.Interfaces;
using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class HighRiskService : IRisk
    {
        public string Type { get; private set; }
        public bool CalculateRisk(ITrade trade)
        {
            DateTime paymentDate = trade.NextPaymentDate;
            DateTime actualDate = DateTime.Now;


            if (paymentDate < actualDate)
            {
                this.Type = Expired.Expired.ToString().ToUpper();
                return true;
            }
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Private.ToString()))
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }
            //this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
