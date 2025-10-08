using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Fiador
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        public Fiador(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
