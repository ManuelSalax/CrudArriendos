using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Contrato
    {
        public int NumeroContrato { get; private set; }
        public decimal Precio { get; private set; }
        public int IdPropiedad { get; private set; }
        public int IdCliente { get; private set; }
        public DateTime Fecha { get; private set; }

        public Contrato(int numeroContrato, decimal precio, int idPropiedad, int idCliente, DateTime fecha)
        {
            NumeroContrato = numeroContrato;
            Precio = precio;
            IdPropiedad = idPropiedad;
            IdCliente = idCliente;
            Fecha = fecha;
        }
    }
}
