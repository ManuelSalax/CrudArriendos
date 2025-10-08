using CrudArriendo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Interfaces
{
    public interface IPropiedadRepository
    {
        IEnumerable<Propiedad> GetAll();
        Propiedad GetById(int id);
        void Add(Propiedad propiedad);
        void Update(Propiedad propiedad);
        void Delete(int id);
    }
}
