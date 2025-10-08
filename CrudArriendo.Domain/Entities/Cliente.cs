using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string CertificadoTrabajo { get; private set; }

        public Cliente(int id, string nombre, string telefono, string certificadoTrabajo)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            CertificadoTrabajo = certificadoTrabajo;
        }
    }
}
