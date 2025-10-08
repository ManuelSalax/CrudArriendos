using CrudArriendo.Domain.Interfaces;
using CrudArriendo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendo.Application.UseCases.Dueno
{
    public class ActualizarDuenoUseCase
    {
        private readonly IDuenoRepository _duenoRepository;

        public ActualizarDuenoUseCase(IDuenoRepository duenoRepository)
        {
            _duenoRepository = duenoRepository;
        }

        public void Execute(int id, DuenoDto duenoDto)
        {
            var dueno = _duenoRepository.GetById(id);
            if (dueno == null)
                throw new Exception($"No se encontró el dueño con ID {id}");

            dueno.Nombre = duenoDto.Nombre;
            dueno.Telefono = duenoDto.Telefono;

            _duenoRepository.Update(dueno);
        }
    }
}
