using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IExpired
    {
        string Type { get; }
        bool IsExpired(ITrade trade);
        DateTime date { get; }
    }
}
