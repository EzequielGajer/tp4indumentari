namespace tp4indumentari.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

class Indumentaria
{

    public string Medias { get; private set ;}
    public string Pantalon { get; private set ;} 
    public string Camiseta { get; private set ;}

    public Indumentaria(string medias, string pantalon, string camiseta)
    {
        Medias = medias;
        Pantalon = pantalon;
        Camiseta = camiseta;
    }

    public static class Equipos()
    {
        public List<string> ListaEquipos = new List<string>();
        public List<string> ListaMedios = new List<string>();
        public List<string> ListaPantalones = new List<string>();
        public List<string> ListaRemeras = new List<string>();

        public Dictionary<string, Indumentaria> EquiposIndumentaria = new Dictionary<string, Indumentaria>();
    }


}

