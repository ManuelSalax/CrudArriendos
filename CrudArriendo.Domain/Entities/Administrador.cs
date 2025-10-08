using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Administrador
    {
        public int Id { get; private set; }
        public string Sede { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }

        public Administrador(int id, string sede, string nombre, string telefono)
        {
            Id = id;
            Sede = sede;
            Nombre = nombre;
            Telefono = telefono;
        }

        public void ActualizarDatos(string sede, string nombre, string telefono)
        {
            Sede = sede;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
