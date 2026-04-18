

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

                            sistema.AdcionarNumero(numero);
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

                        try
                        {
                            Console.WriteLine("Digite o número que deseja remover:");

                            if (int.TryParse(Console.ReadLine(), out int rnumero))
                            {


                                if (sistema.RemoverNumero(rnumero))
                                {
                                    Console.WriteLine($"Número {rnumero} removido com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine($"Número {rnumero} não encontrado na lista.");
                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }


                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();

                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Digite um número que deseja buscar :");
                            if (int.TryParse(Console.ReadLine(), out int bnumero))
                            {
                                if (sistema.BuscarNumero(bnumero))
                                {
                                    Console.WriteLine($"Número {bnumero} encontrado na lista!");
                                }
                                else
                                {
                                    Console.WriteLine($"Número {bnumero} não encontrado na lista.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }


                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                   
                    case 4:
                        var lista = sistema.ObterNumero();

                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Nenhum número na lista.");
                        }
                        else
                        {
                            foreach (int n in lista)
                            {
                                Console.WriteLine($"Número: {n}");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 5:
                        try
                        {
                            Console.WriteLine($"O maior número é: {sistema.ObterMaior()}");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }

                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();

                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine($"O menor número é: {sistema.ObterMenor()}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }

                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 7:
                        try
                        {
                            Console.WriteLine($"A média dos números é: {sistema.ObterrMedia()}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
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

    public void AdcionarNumero(int numero)
    {
            numeros.Add(numero);

    }
    public bool RemoverNumero(int numero)
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");


        return numeros.Remove(numero);

    }
    public bool BuscarNumero(int numero)
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        return numeros.Contains(numero);
    }


    public List<int> ObterNumero()
    {

        return new List<int>(numeros); ;
    }

    public int ObterMaior()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        
        return numeros.Max();
    }


    public int ObterMenor()
    {
        if (numeros.Count == 0)
        
             throw new InvalidOperationException("Nenhum número adicionado ainda.");

           return numeros.Min();
            
        
           


        
        
        

    }

    public double ObterrMedia()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        
        return numeros.Average();

    }
}