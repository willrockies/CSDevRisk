using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        Task Added(T Objeto);
        Task Modified(T Objeto);
        Task Removed(T Objeto);
      
    }
}
