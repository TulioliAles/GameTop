namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return $"Messi está pateando. \n";
        }

        public string Corre()
        {
            return $"Messi está corriendo. \n";
        }

        public string Passa()
        {
            return $"Messi está pasando. \n";
        }
    }
}
