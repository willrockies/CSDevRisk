using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRisk 
    {
        string Type { get; }     
        bool CalculateRisk(ITrade trade);
    }
}
