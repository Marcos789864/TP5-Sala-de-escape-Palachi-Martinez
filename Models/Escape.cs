public static class Escape
{
        static string[] IncognitasSalas = new string [5];


        static int EstadoJuego = 1;


        private static void InicializarJuego()
        {
         IncognitasSalas[0] = "";
         IncognitasSalas[1] = "Agujero";
         IncognitasSalas[2] = "Cocos";
         IncognitasSalas[3] = "Marea";
         IncognitasSalas[4] = "Llave";
        }


        public static int GetEstadoJuego()
        {
            return EstadoJuego;
        }


        public static bool ResolverSala(int sala,string incognita)
        {
            if(IncognitasSalas[0] == null)
            {
                InicializarJuego();
                IncognitasSalas[0] = "h";
            }
            if(IncognitasSalas[sala] == incognita)
            {
                EstadoJuego++;
                return true;
            }
            return false;


        }
}