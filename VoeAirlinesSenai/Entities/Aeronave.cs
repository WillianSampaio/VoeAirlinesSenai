//Namespace é um conjunto de classes
//Objeti: é uma instâmcia de uma classe
namespace VoeAirlinesSenai.Entities;

//Classes:é um conjunto de objetos
//Objetos: é uma intância de uma classe
public class Aeronave{
    public Aeronave(string? fabricante, string? modelo, string? codigo)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }

    /*
Propriedades Automáticas
Caracteristicas do objeto 
Automático: gera o get set
Métodos set -atribui
Métodos get -recupera
POCO-foco é o objeto
*/
    public int Id{get;set;}
    public string? Fabricante { get; set; }
    public string? Modelo { get; set; }
    public string? Codigo { get; set; }

    public ICollection<Manutencao> Manutencoes{get;set;}


}
