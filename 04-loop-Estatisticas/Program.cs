List<int> numeros = new List<int>();
int opcao;

Console.WriteLine("Seja bem vindo ao sistema de estatisticas de números!");
do
{
    Console.WriteLine(@"
1 - Adicionar número
2 - Mostrar números
3 - Mostrar maior
4 - Mostrar menor
5 - Mostrar média
6 - Mostrar pares
7 - Mostrar ímpares
8 - Remover número
9 - Buscar número
10 - Ordenar crescente
11 - Ordenar decrescente
12 - Mostrar resumo geral
0 - Sair
    ");
    Console.Write("Digite a opção desejada: ");
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida, tente novamente.");
        continue;
    }
    switch (opcao)
    {
        case 1: AdicionarNuero(); break;
        case 2: MostrarNumeros(); break;
        case 3: MostrarMaior(); break;
        case 4: MostrarMenor(); break;
        case 5: MostrarMedia(); break;
        case 6: MostrarPares(); break;
        case 7: MostrarImpares(); break;
        case 8: RemoverNumero(); break;
        case 9: BuscarNumero(); break;
        case 10: OrdenarCrescente(); break;
        case 11: OrdenarDecrescente(); break;
        case 12: MostrarResumoGeral(); break;
        case 0: Console.WriteLine("Saindo do programa..."); return;
            // default: Console.WriteLine("Opção inválida, tente novamente."); break;
    }
    

} while (true);


void OrdenarCrescente()
{
    Console.Clear();
    
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nenhum número cadastrado.");
            return;
        }
        numeros.Sort();
        Console.WriteLine("Números em ordem crescente:");
        foreach (int n in numeros)
        {
            Console.WriteLine($"Número: {n}");
        }

        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();
    }

}

void MostrarResumoGeral()
{
    void MostrarResumoGeral()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }

    int maior = numeros[0];
    int menor = numeros[0];
    int soma = 0;
    int pares = 0;
    int impares = 0;

    foreach (int n in numeros)
    {
        soma += n;

        if (n > maior) maior = n;
        if (n < menor) menor = n;

        if (n % 2 == 0) pares++;
        else impares++;
    }

    double media = soma / (double)numeros.Count;

    Console.WriteLine("\n===== RESUMO =====");
    Console.WriteLine($"Total: {numeros.Count}");
    Console.WriteLine($"Maior: {maior}");
    Console.WriteLine($"Menor: {menor}");
    Console.WriteLine($"Média: {media}");
    Console.WriteLine($"Pares: {pares}");
    Console.WriteLine($"Ímpares: {impares}");

    Console.WriteLine("\nPressione qualquer tecla...");
    Console.ReadKey();
}
}

void OrdenarDecrescente()
{
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nenhum número cadastrado.");
            return;
        }
        numeros.Sort();
        numeros.Reverse();
        Console.WriteLine("Números em ordem decrescente:");
        foreach (int n in numeros)
        {
            Console.WriteLine($"Número: {n}");
        }

        Console.WriteLine("Pressione qualquer tecla...");
        Console.ReadKey();
    }

}



void BuscarNumero()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }
    Console.Write("Digite um número para buscar: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numeros.Contains(numero))
        {
            Console.WriteLine($"Número encontrado: {numero}");
        }
        else
        {
            Console.WriteLine("Número não encontrado, tente novamente.");
        }


    }
    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}

void RemoverNumero()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }
    Console.Write("Digite um número que deseja remover: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numeros.Contains(numero))
        {
            numeros.Remove(numero);
            Console.WriteLine("Número removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Número não encontrado, tente novamente.");
        }
    }
    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}

void AdicionarNuero()
{
    Console.Clear();
    Console.Write("Digite um número para adicionar: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numeros.Contains(numero))
        {
            Console.WriteLine("Número já cadastrado, tente novamente.");
            return;
        }
        numeros.Add(numero);
        Console.WriteLine("Número adicionado com sucesso!");
    }
    else
    {
        Console.WriteLine("Número inválido, tente novamente.");
    }
    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}

void MostrarNumeros()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Nenhum número cadastrado.");
        return;
    }
    foreach (int n in numeros)
    {
        Console.WriteLine($"Número: {n}");
    }

    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}

void MostrarMaior()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
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

void MostrarMenor()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
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

void MostrarMedia()
{
    if (numeros.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
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

void MostrarPares()
{
    bool encontrou = false;

    foreach (int n in numeros)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine($"Número par: {n}");
            encontrou = true;
        }
    }

    if (!encontrou)
    {
        Console.WriteLine("Nenhum número par encontrado.");
    }
    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}

void MostrarImpares()
{
    bool encontrou = false;
    foreach (int n in numeros)
    {
        if (n % 2 != 0)
        {
            Console.WriteLine($"Número ímpar: {n}");
        }
    }
    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
}