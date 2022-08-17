namespace VoeAirlinesSenai.Entities;

public class Voo{
    public Voo(string origem, string destino, MvcDataAnnotationsMvcBuilderExtensions dataHoraPartida,MvcDataAnnotationsMvcBuilderExtensions dataHoraChegada,int aeronaveId,int pilotoId){
        origem = origem;
        destino = destino;
        dataHoraPartida = dataHoraPartida;
        dataHoraChegada = dataHoraChegada;
        aeronaveId = aeronaveId;
        pilotoId = pilotoId;

    }
    public int Id{get;set;}
    public string Origem
}