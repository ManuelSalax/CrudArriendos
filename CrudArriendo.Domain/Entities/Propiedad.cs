using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Propiedad
    {
        public int Id { get; private set; }
        public string Ubicacion { get; private set; }
        public string Tipo { get; private set; }

        public int IdCaracteristica { get; private set; }
        public int IdDueno { get; private set; }
        public int IdAdministrador { get; private set; }

        public Propiedad(int id, string ubicacion, string tipo, int idCaracteristica, int idDueno, int idAdministrador)
        {
            Id = id;
            Ubicacion = ubicacion;
            Tipo = tipo;
            IdCaracteristica = idCaracteristica;
            IdDueno = idDueno;
            IdAdministrador = idAdministrador;
        }
    }
}
