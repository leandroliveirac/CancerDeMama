using System.Collections.Generic;

namespace CancerDeMama.Domain.Core.Entities
{
    public class FaixaEtariaEntity : BaseEntity
    {
        public int FaixaInicial { get; set; }
        public int FaixaFinal { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<IncidenciaExameEntity> IncidenciasExames { get; set; }
    }
}
