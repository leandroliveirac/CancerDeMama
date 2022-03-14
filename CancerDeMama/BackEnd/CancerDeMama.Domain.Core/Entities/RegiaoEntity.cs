using System.Collections.Generic;

namespace CancerDeMama.Domain.Core.Entities
{
    public class RegiaoEntity : BaseEntity
    {
        public string Nome { get; set; }

        public IEnumerable<IncidenciaExameEntity> IncidenciasExames { get; set; }
    }
}
