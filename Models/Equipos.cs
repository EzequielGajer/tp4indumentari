 public static class Equipos()
    {
        List<string> ListaEquipos = new List {get; private set;}
        public List<string> ListaMedios = new List<string>();
        public List<string> ListaPantalones = new List<string>();
        public List<string> ListaRemeras = new List<string>();

        public Dictionary<string, Indumentaria> EquiposIndumentaria = new Dictionary<string, Indumentaria>();
    }