using CrudArriendo.Domain.Entities;
using CrudArriendo.Domain.Interfaces;
using CrudArriendo.Application.DTOs;
using System.Collections.Generic;

namespace CrudArriendo.Application.UseCases.DuenoU
{
    public class ListarDuenosUseCase
    {
        private readonly IDuenoRepository _duenoRepository;

        public ListarDuenosUseCase(IDuenoRepository duenoRepository)
        {
            _duenoRepository = duenoRepository;
        }

        public IEnumerable<DuenoDto> Execute()
        {
            // Recupera los datos desde el repositorio
            var duenos = _duenoRepository.GetAll();

            // Mapea las entidades del dominio a DTOs
            var duenoDtos = new List<DuenoDto>();
            foreach (var dueno in duenos)
            {
                duenoDtos.Add(new DuenoDto
                {
                    Id = dueno.Id,
                    Nombre = dueno.Nombre,
                    Telefono = dueno.Telefono
                });
            }

            return duenoDtos;
        }
    }
}
