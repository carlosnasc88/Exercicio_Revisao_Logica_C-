

using System.Net.ServerSentEvents;

class Program
{
    static void Main(string[] args)
    {
        SistemaDeNumeros sistema = new SistemaDeNumeros();
        int opcao;

        do
        {
            Console.WriteLine(@"
            Seja bem-vindo ao sistema de números!
            1- Adicionar            
            2- Remover
            3- Buscar
            4- Mostrar
            5- Maior 
            6- Menor
            7- Média
            0- Sair           
        
            
            ");
            Console.Write("Digite a opção desejada: ");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        //Adionar números
                        Console.WriteLine("Digite um número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            sistema.AdcionarNumeros(numero);
                            Console.WriteLine($"Número {numero} adicionado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                        }
                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        //Remover números
                        Console.WriteLine("Digite o número que deseja remover:");

                        if (int.TryParse(Console.ReadLine(), out int rnumero))
                        {


                            if (sistema.RemoverNumeros(rnumero))
                            {
                                Console.WriteLine($"Número {rnumero} removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine($"Número {rnumero} não encontrado na lista.");
                            }

                        }
                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();

                        break;
                    case 3:

                        Console.WriteLine("Digite um número que deseja buscar :");
                        if (int.TryParse(Console.ReadLine(), out int bnumero))
                        {
                            if (sistema.BuscarNumeros(bnumero))
                            {
                                Console.WriteLine($"Número {bnumero} encontrado na lista!");
                            }
                            else
                            {
                                Console.WriteLine($"Número {bnumero} não encontrado na lista.");
                            }
                        }
                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                       
                        if (sistema.ObterNumeros().Count == 0)
                        {
                            Console.WriteLine("Nenhum númeor foi inserido na lista");

                        }
                        else
                        {
                            var lista = sistema.ObterNumeros();
                            foreach (int n in lista)
                            {
                                Console.WriteLine($"Nuemro: {n}");
                            }
                        }
                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;

                    case 5:
                        
                        ;
                        if (sistema.ObterNumeros().Count == 0)
                        {
                            Console.WriteLine("Nehum número adicionado ainda.");

                            Console.WriteLine("Precione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                           

                            Console.WriteLine($"O maior número é: {sistema.ObterMaior()}");

                            Console.WriteLine("Pressione qualquer tecla...");
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        
                        if  (sistema.ObterNumeros().Count == 0)
                        {
                            Console.WriteLine("Nehum número adicionado ainda.");

                            Console.WriteLine("Precione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                           Console.WriteLine($"O menor número é: {sistema.ObterMenor()}");
                        }

                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 7:
                      
                        if (sistema.ObterNumeros().Count == 0)
                        {
                            Console.WriteLine("Nehum número adicionado ainda.");

                            Console.WriteLine("Precione qualquer tecla para continuar...");
                            Console.ReadKey();



                        }
                        else
                        {
                            
                            Console.WriteLine($"A média dos números é: {sistema.ObterrMedia()}");



                        }

                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                        // default:
                        //     Console.WriteLine("Opção inválida. Tente novamente.");
                        //     break;
                }
            }


        }
        while (opcao != 0);









    }
}




class SistemaDeNumeros
{
    private List<int> numeros = new List<int>();

    public void AdcionarNumeros(int numero)
    {

        {
            numeros.Add(numero);

        }


    }
    public bool RemoverNumeros(int numero)
    {

        return numeros.Remove(numero);

    }
    public bool BuscarNumeros(int numero)
    {

        return numeros.Contains(numero);
    }


    public List<int> ObterNumeros()
    {

        return numeros; ;
    }

    public int ObterMaior()
    {
        int maior = numeros[0];
        foreach(int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }
        return maior;
    }


    public int ObterMenor()
    {


        int menor = numeros[0];
        foreach(int n in numeros)
        {
            if (n < menor)
            {
                menor = n;
            }
        }
        return menor;

    }

    public double ObterrMedia()
    {
        double media = 0;
        foreach(int n in numeros)
        {
            media += n;
        }
        return media / numeros.Count;

    }
}