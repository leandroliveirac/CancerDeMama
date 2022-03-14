using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Application.Services
{
    public class IncidenciaExameAppService : AppBaseService<IncidenciaExameEntity>, IIncidenciaExameAppService
    {
        private readonly IIncidenciaExameService _incidenciaExameService;

        public IncidenciaExameAppService(IIncidenciaExameService incidenciaExameService)
            : base(incidenciaExameService)
        {
            _incidenciaExameService = incidenciaExameService;
        }
    }
}
