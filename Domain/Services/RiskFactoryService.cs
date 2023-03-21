using Domain.Interfaces;
using Domain.Entities.Enums;
namespace Domain.Services
{
    static class RiskFactoryService
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "MediumRisk":
                    return new MediumRiskService();
                case "HighRisk":
                    return new HighRiskService();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
