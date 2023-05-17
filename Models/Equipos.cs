public static class Equipos
{
    public static List<string> ListaEquipos { get; private set; }
    public static List<string> ListaMedias { get; private set; }
    public static List<string> ListaPantalones { get; private set; }
    public static List<string> ListaRemeras { get; private set; }
    public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }

    static Equipos()
    {
        ListaEquipos = new List<string>();
        ListaMedias = new List<string>();
        ListaPantalones = new List<string>();
        ListaRemeras = new List<string>();
        EquiposIndumentaria = new Dictionary<string, Indumentaria>();

        CargarEquipos();
        CargarMedias();
        CargarPantalones();
        CargarRemeras();
    }

    static void CargarEquipos(){
        ListaEquipos = new List<string> {"Equipo 1", "Equipo 2", "Equipo 3", "Equipo 4", "Equipo 5", "Equipo 6", "Equipo 7", "Equipo 8", "Equipo 9", "Equipo 10"};
    }

    static void CargarMedias(){
        ListaMedias = new List<string>{"media1.jpg", "media2.jpg", "media3.jpg", "media4.jpg", "media5.jpg", "media6.jpg", "media7.jpg", "media8.jpg", "media9.jpg", "media10.jpg"};
    }

    static void CargarPantalones(){
        ListaPantalones = new List<string>{"pantalon1.jpg", "pantalon2.jpg", "pantalon3.jpg", "pantalon4.jpg", "pantalon5.jpg", "pantalon6.jpg", "pantalon7.jpg", "pantalon8.jpg", "pantalon9.jpg", "pantalon10.jpg"};
    }

    static void CargarRemeras(){
        ListaRemeras = new List<string>{"remera1.jpg", "remera2.jpg", "remera3.jpg", "remera4.jpg", "remera5.jpg", "remera6.jpg", "remera7.jpg", "remera8.jpg", "remera9.jpg", "remera10.jpg"};
    }

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        if (EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
            return false;
        }

        EquiposIndumentaria[equipoSeleccionado] = item;
        return true;
    }
}