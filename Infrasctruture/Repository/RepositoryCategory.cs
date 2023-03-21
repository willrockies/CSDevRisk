using Domain.Interfaces;
using Entities.Entities;
using Infrasctruture.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasctruture.Repository
{
    public class RepositoryCategory : RepositoryGeneric<Category>, ICategoria
    {
        public Task<IList<Category>> ListarCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
