

class Program
{
    static void Main(string[] args)
    {
        SistemaDeNumeros sistema = new SistemaDeNumeros();
        int opcao  ;

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
                        sistema.AdcionarNumeros();
                        break;
                    case 2:
                        sistema.RemoverNumeros();
                        break;
                    case 3:
                        sistema.BuscarNumeros();
                        break;
                    case 4:
                        sistema.MostrarNumeros();
                        break;
                    case 5:
                        sistema.MostrarMaior();
                        break;
                    case 6:
                        sistema.MostrarMenor();
                        break;
                    case 7:
                        sistema.MostrarMedia();
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

    public void AdcionarNumeros()
    {
        Console.WriteLine("Digite um número: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            numeros.Add(numero);
            Console.WriteLine($"Número {numero} adicionado com sucesso!");
        }

        
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadKey();

    }
    public void RemoverNumeros()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");

            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }
        else
        {
            Console.WriteLine("Digite o número que deseja remover:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numeros.Remove(numero))
                {
                    Console.WriteLine($"Número {numero} removido com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Número {numero} não encontrado na lista.");
                }
            }
        }
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadKey();

    }
    public void BuscarNumeros()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");
            
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }
        else
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numeros.Contains(numero))
                {
                    Console.WriteLine($"Número {numero} encontrado na lista!");
                }
                else
                {
                    Console.WriteLine($"Número {numero} não encontrado na lista.");
                }
            }
        }
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadKey();
    }


    public void MostrarNumeros()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");
            
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }
        else
        {
            foreach (int n in numeros)
            {
                Console.WriteLine($"Numero: {n}");
            }
        }
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    public void MostrarMaior()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");
            
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }

        int maior = numeros[0];

        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }

        Console.WriteLine($"O maior número é: {maior}");

        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();
    }


    public void MostrarMenor()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");
            
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }

        int menor = numeros[0];

        foreach (int n in numeros)
        {
            if (n < menor)
            {
                menor = n;
            }
        }

        Console.WriteLine($"O menor número é: {menor}");

        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();

    }

    public void MostrarMedia()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nehum número adicionado ainda.");
            
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return;

        
        }
        double media = 0;
        foreach (int n in numeros)
        {
            media += n;
        }
        Console.WriteLine($"A média dos números é: {media / numeros.Count}");

        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();
    }
}