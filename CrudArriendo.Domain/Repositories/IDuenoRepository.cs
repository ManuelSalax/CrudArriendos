using CrudArriendo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Repositories
{
    public interface IDuenoRepository
    {
        void Add(Dueno dueno);
        Dueno? GetById(int id);
        IEnumerable<Dueno> GetAll();
        void Update(Dueno dueno);
        void Delete(int id);
    }
}
