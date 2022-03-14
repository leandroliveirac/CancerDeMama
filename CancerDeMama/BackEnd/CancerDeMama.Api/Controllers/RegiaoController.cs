using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CancerDeMama.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoAppService _regiaoAppService;

        public RegiaoController(IRegiaoAppService regiaoService)
        {
            _regiaoAppService = regiaoService;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public ICollection<RegiaoEntity> ListarTodos()
        {
            var oRetorno = _regiaoAppService.ListarTodos();

            return oRetorno;
        }

        [HttpGet]
        [Route("ObterPorId/{id}")]
        public RegiaoEntity ObterPorId(int id)
        {
            return _regiaoAppService.ObterPorId(id);
        }
    }
}
