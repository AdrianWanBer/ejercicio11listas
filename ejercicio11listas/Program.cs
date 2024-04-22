namespace ejercicio11listas
{
    class program
    {
        public static void Main(String[] args) {

            string parentesis = "((()))";
            char parentesisAbrir = '(';
            char parentesisCerrar = ')';
            int contadorAbiertos = 0;
            int contadorCerradas = 0;

            foreach (char letra in parentesis) {

                if (letra == parentesisAbrir)
                {
                    contadorAbiertos++;
                }
                if (letra == parentesisCerrar)
                {
                    contadorCerradas++;
                }
            }

            if(contadorCerradas == contadorAbiertos)
            {
                Console.WriteLine("Esta balanceado");

            } else
            {
                Console.WriteLine("No esta balanceado");
            }

        }
    }
}
