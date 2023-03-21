using Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Entities
{
    public class Category : ITrade
    {
        private List<ITrade> portfolio;

        public Category(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                RiskFactory.Create(TypeRisk.LowRisk),
                RiskFactory.Create(TypeRisk.MediumRisk),
                RiskFactory.Create(TypeRisk.HighRisk)
            };

            foreach (Trade trade in portfolio)
            {
                foreach (IRisk r in risks)
                {
                    risk = r;

                    if (trade.CalculateRisk(r))
                    {
                        break;
                    }
                }

                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
