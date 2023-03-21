using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Enums;


namespace Domain.Services
{
    public class MediumRiskService : IRisk
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
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Public.ToString()))
            {
                this.Type = TypeRisk.MediumRisk.ToString().ToUpper();

                return true;
            }

            //this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
