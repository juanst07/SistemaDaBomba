using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int opcao = random.Next(1, 4);

        bool boiaA = false;
        bool boiaB = false;

        switch (opcao)
        {
            case 1:
                boiaA = true;
                boiaB = false;
                Console.WriteLine("Boia A: Reservatório quase vazio. Ligando a bomba...");
                break;

            case 2:
                boiaA = false;
                boiaB = true;
                Console.WriteLine("Boia B: Reservatório quase cheio. Não é necessário ligar a bomba.");
                break;

            case 3:
                boiaA = true;
                boiaB = true;
                Console.WriteLine("Atenção : Boia A indica que o reservatório está cheio, mas Boia B indica que está vazio.");
                Console.WriteLine("Manutenção necessária nas boias.");
                break;
        }
    }
}
