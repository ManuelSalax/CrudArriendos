using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Domain.Entities
{
    public class Caracteristica
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public int Habitacion { get; private set; }
        public int Banos { get; private set; }
        public bool Piscina { get; private set; }
        public bool Gimnasio { get; private set; }

        public Caracteristica(int id, string tipo, int habitacion, int banos, bool piscina, bool gimnasio)
        {
            Id = id;
            Tipo = tipo;
            Habitacion = habitacion;
            Banos = banos;
            Piscina = piscina;
            Gimnasio = gimnasio;
        }
    }
}
