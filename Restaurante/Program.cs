using Restaurante.Classes;
using Restaurante.Classes;
using Restaurante.Enums;

internal class Program
{
    private static void Main(string[] args)
    {


        List<Cardapio> c1 = new List<Cardapio>();

        int op;

        Console.WriteLine("------SEJA BEM-VINDO-------");

        Console.WriteLine("DIGITE SEU NOME");
        string nome = Console.ReadLine();

        Console.WriteLine("DIGITE SEU CPF");
        string cpf = Console.ReadLine();

         Console.WriteLine("DIGITE SUA DATA DE NASCIMENTO");
         DateTime datanasc = DateTime.Parse(Console.ReadLine());

         Pessoa p1 = new Pessoa(nome, cpf, datanasc);

        

        do
        {
            Console.WriteLine("----CARDAPIO----");
            Console.WriteLine("\n 1 - PRATOS \n 2 - BEBIDAS \n 3 - SAIR");
            Console.Write("ESCOLHA UMA OPÇÃO:");
            op = int.Parse(Console.ReadLine());
            if (op == 1)

            {
                Console.WriteLine("----PRATOS----");
                Console.WriteLine(" 0 - PRATO DA CASA   \n 1 - PRATO MEDIANO \n 2 - PRATO RUIM \n 3 - PRATO DE GORDO");
                Console.Write("ESCOLHA UMA OPÇÃO:");
                Sabores sabores = Enum.Parse<Sabores>(Console.ReadLine());

                Console.WriteLine("VOCE ESCOLHER O PRATO: " + sabores);


            }

            if (op == 2)
            {
                Console.WriteLine("----BEBIDAS----");
                Console.WriteLine(" 4 - COLA 2L  \n 5 - CERVEJA \n 6 - VINHO \n 7 - AGUA COM GAS");
                Console.Write("ESCOLHA UMA OPÇÃO:");
                Sabores sabores = Enum.Parse<Sabores>(Console.ReadLine());

                Console.WriteLine("VOCE ESCOLHEU A BEBIDA: " + sabores);
            }
        } while (op != 3);


        Console.WriteLine("PROGRAMA FINALIZADO");
    }
}