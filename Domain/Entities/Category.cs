using Domain.Interfaces;
using Domain.Services;
using Domain.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Category : ICategory
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
           
            List<IRisk> risks = new List<IRisk> 
            {
                RiskFactoryService.Create(TypeRisk.MediumRisk),
                RiskFactoryService.Create(TypeRisk.HighRisk),

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
        public Task Added(Category Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Modified(Category Objeto)
        {
            throw new NotImplementedException();
        }
        public Task Removed(Category Objeto)
        {
            throw new NotImplementedException();
        }

       
    }
}
