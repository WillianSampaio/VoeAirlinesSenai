namespace VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.Entities.Enums;
public class Manutencao{
    public Manutencao(DateTime dataHora, string observacoes, TipoManutencao tipo, int aeronaveId, Aeronave aeronave)
    {
        DataHora = dataHora;
        Observacoes = observacoes;
        Tipo = tipo;
        AeronaveId = aeronaveId;
        Aeronave = aeronave;
    }

    public int Id{get;set;}
    public DateTime DataHora{get;set;}

    public string Observacoes{get;set;}
    public TipoManutencao Tipo { get; set; }
    public int AeronaveId { get; set; }
    public Aeronave Aeronave { get; set; }

}