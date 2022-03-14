using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CancerDeMama.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidenciaExameController : ControllerBase
    {
        private IIncidenciaExameAppService _incidenciaExameAppService;

        public IncidenciaExameController(IIncidenciaExameAppService incidenciaExameAppService)
        {
            _incidenciaExameAppService = incidenciaExameAppService;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public ICollection<IncidenciaExameEntity> ListarTodos()
        {
            return _incidenciaExameAppService.ListarTodos();
        }
    }
}
