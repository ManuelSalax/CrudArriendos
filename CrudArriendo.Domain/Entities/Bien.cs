using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Bien
    {
        public int IdBien { get; private set; }
        public string TipoBien { get; private set; }
        public string Descripcion { get; private set; }
        public int IdFiador { get; private set; }

        public Bien(int idBien, string tipoBien, string descripcion, int idFiador)
        {
            IdBien = idBien;
            TipoBien = tipoBien;
            Descripcion = descripcion;
            IdFiador = idFiador;
        }
    }
}
