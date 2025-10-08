using CrudArriendo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Interfaces
{
    public interface IContratoRepository
    {
        IEnumerable<Contrato> GetAll();
        Contrato GetById(int numeroContrato);
        void Add(Contrato contrato);
        void Update(Contrato contrato);
        void Delete(int numeroContrato);
    }
}
