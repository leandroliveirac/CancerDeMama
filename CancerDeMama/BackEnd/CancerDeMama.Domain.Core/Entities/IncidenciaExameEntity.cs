namespace CancerDeMama.Domain.Core.Entities
{
    public class IncidenciaExameEntity : BaseEntity
    {
        public int RegiaoId { get; set; }
        public int FaixaEtariaId { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int QuantExames { get; set; }

        public RegiaoEntity Regiao { get; set; }
        public FaixaEtariaEntity FaixaEtaria { get; set; }
    }
}
