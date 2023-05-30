public static class Escape {
    private static string[] incognitasSalas = {"87", "R", "LOS TRES CERDITOS", "7"};
    private static int estadoJuego = 1;
    public static int GetEstadoJuego(){return estadoJuego;}

    public static bool ResolverSala(int Sala, string Incognita){
        if (Sala == estadoJuego && Incognita.ToUpper() == incognitasSalas[Sala-1]){
            estadoJuego++;
            return true;
        } 
        else return false;
    }
}