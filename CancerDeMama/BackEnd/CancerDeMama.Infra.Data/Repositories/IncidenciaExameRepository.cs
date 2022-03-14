using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CancerDeMama.Infra.Data.Repositories
{
    public sealed class IncidenciaExameRepository : BaseRepository<IncidenciaExameEntity, CancerDeMamaContext>, IIncidenciaExameRepository
    {
        public IncidenciaExameRepository(CancerDeMamaContext context) 
            : base(context)
        {
        }

        public override ICollection<IncidenciaExameEntity> ListarTodos()
        {
            var dados = _context.Set<IncidenciaExameEntity>()
                                                        .Include(p=> p.FaixaEtaria)
                                                        .Include(p=> p.Regiao)
                                                        .ToList();

            return dados;
        }
    }
}
