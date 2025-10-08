using CrudArriendo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudArriendos.Application.UseCases.DuenoU
{
    public class EliminarDuenoUseCase
    {
        private readonly IDuenoRepository _duenoRepository;

        public EliminarDuenoUseCase(IDuenoRepository duenoRepository)
        {
            _duenoRepository = duenoRepository;
        }

        public void Execute(int id)
        {
            var dueno = _duenoRepository.GetById(id);
            if (dueno == null)
                throw new Exception($"No se encontró el dueño con ID {id}");

            _duenoRepository.Delete(id);
        }
    }
}
