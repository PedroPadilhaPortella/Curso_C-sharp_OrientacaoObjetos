namespace _03_static
{
    static class Estatico
    {
        public static int Taxa { get; set; }

        public static int Adicionar(int valor){
            return valor + Taxa;
        }

        public static int Subtrair(int valor){
            return valor - Taxa;
        }
    }
}