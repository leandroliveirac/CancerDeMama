using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Domain.Core.Services
{
    public class IncidenciaExameService : BaseService<IncidenciaExameEntity>, IIncidenciaExameService
    {
        private readonly IIncidenciaExameRepository _incidenciaExameRepository;

        public IncidenciaExameService(IIncidenciaExameRepository incidenciaExameRepository)
            : base(incidenciaExameRepository)
        {
            _incidenciaExameRepository = incidenciaExameRepository;
        }
    }
}
