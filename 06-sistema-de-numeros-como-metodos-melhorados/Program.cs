

using System.Net.ServerSentEvents;
using System.Runtime.InteropServices;

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
            8- Mostar números pares
            9- Mostrar números ímpares
            10 - Mostrar resumo completo
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
                            var resumo = sistema.ObterResumo();

                            Console.WriteLine($"O maior número é: {resumo.Maior}");
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
                            var resumo = sistema.ObterResumo();

                            Console.WriteLine($"O menor número é: {resumo.Menor}");
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
                            var resumo = sistema.ObterResumo();
                            Console.WriteLine($"A média dos números é: {resumo.Media}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }



                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;


                    case 8:
                        try
                        {
                            var pares = sistema.ObterPares();
                            if (pares.Count == 0)
                            {
                                Console.WriteLine("Nenhum número par na lista.");
                            }
                            else
                            {
                                Console.WriteLine("Números pares:");
                                foreach (int n in pares)
                                {
                                    Console.WriteLine(n);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }

                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;

                    case 9:
                        try
                        {
                            var impares = sistema.ObterImpares();
                            if (impares.Count == 0)
                            {
                                Console.WriteLine("Nenhum número ímpar na lista.");
                            }
                            else
                            {
                                Console.WriteLine("Números ímpares:");
                                foreach (int n in impares)
                                {
                                    Console.WriteLine(n);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        Console.WriteLine("Pressione qualquer tecla...");
                        Console.ReadKey();
                        break;

                    case 10:
                        try
                        {ComDefaultInterfaceAttribute
                            var resumo = sistema.ObterResumo();
                            Console.WriteLine($"Quantidade de números: {resumo.Quantidade}");
                            Console.WriteLine($"Maior número: {resumo.Maior}");
                            Console.WriteLine($"Menor número: {resumo.Menor}");
                            Console.WriteLine($"Média dos números: {resumo.Media}");
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




                }







            }


        }
        while (opcao != 0);









    }
}

class ResumoNumeros
{
    public int Quantidade { get; set; }
    public int Maior { get; set; }
    public int Menor { get; set; }
    public double Media { get; set; }
}





class SistemaDeNumeros
{


    private List<int> numeros = new List<int>();


    public ResumoNumeros ObterResumo()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        return new ResumoNumeros
        {
            Quantidade = numeros.Count,
            Maior = numeros.Max(),
            Menor = numeros.Min(),
            Media = numeros.Average()
        };


    }

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
        // if(numeros.Count == 0)
        //     throw new InvalidOperationException("Nenhum número adicionado ainda.");


        return numeros;
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

    public double ObterMedia()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");


        return numeros.Average();

    }

    public List<int> ObterPares()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        return numeros.Where(n => n % 2 == 0).ToList();
    }

    public List<int> ObterImpares()
    {
        if (numeros.Count == 0)
            throw new InvalidOperationException("Nenhum número adicionado ainda.");

        return numeros.Where(n => n % 2 != 0).ToList();
    }
}