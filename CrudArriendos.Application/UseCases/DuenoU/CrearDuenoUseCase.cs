using CrudArriendo.Domain.Entities;
using CrudArriendo.Domain.Interfaces;
using CrudArriendo.Application.DTOs;
using System;

namespace CrudArriendo.Application.UseCases.DuenoU
{
    public class CrearDuenoUseCase
    {
        private readonly IDuenoRepository _duenoRepository;

        public CrearDuenoUseCase(IDuenoRepository duenoRepository)
        {
            _duenoRepository = duenoRepository ?? throw new ArgumentNullException(nameof(duenoRepository));
        }

        public void Execute(DuenoDto duenoDto)
        {
            if (duenoDto == null)
                throw new ArgumentNullException(nameof(duenoDto));

            var dueno = new Domain.Entities.Dueno // Fully qualify the 'Dueno' class to avoid ambiguity
            {
                Id = duenoDto.Id,
                Nombre = duenoDto.Nombre,
                Telefono = duenoDto.Telefono
            };

            _duenoRepository.Add(dueno);
        }
    }
}
