using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CancerDeMama.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaixaEtariaController : ControllerBase
    {
        private IFaixaEtariaAppService _faixaEtariaAppService;

        public FaixaEtariaController(IFaixaEtariaAppService faixaEtariaAppService)
        {
            _faixaEtariaAppService = faixaEtariaAppService;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public ICollection<FaixaEtariaEntity> ListarTodos()
        {
            return _faixaEtariaAppService.ListarTodos();
        }
    }
}
