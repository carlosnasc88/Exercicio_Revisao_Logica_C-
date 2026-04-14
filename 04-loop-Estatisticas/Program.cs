List<int> numeros = new List<int>();
int opcao;
int maior;
int menor;
bool valorMaiorEncontrado = false;
bool valorMenorEncontrado = false;
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
0 - Sair
    ");
    Console.Write("Digite a opção desejada: ");
  if(!int.TryParse(Console.ReadLine(),out opcao))
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
        case 0: Console.WriteLine("Saindo do programa..."); return;
       // default: Console.WriteLine("Opção inválida, tente novamente."); break;
    }


} while (true);

void AdicionarNuero()
{
    Console.Write("Digite um número para adicionar: ");
    if(int.TryParse(Console.ReadLine(), out int numero))
    {
        numeros.Add(numero);
        Console.WriteLine("Número adicionado com sucesso!");
    }
    else
    {
        Console.WriteLine("Número inválido, tente novamente.");
    }
}

void MostrarNumeros()
{
    if (numeros.Count == 0)
{
    Console.WriteLine("Nenhum número cadastrado.");
    return;
}
   foreach(int n in numeros)
    {
        Console.WriteLine($"Número: {n}");
    }
}

void MostrarMaior()
{
    if (numeros.Count == 0)
{
    Console.WriteLine("Lista vazia.");
    return;
}
   foreach(int n in numeros)
    {
        if(!valorMaiorEncontrado || n > maior)
        {
            maior = n;
            valorMaiorEncontrado = true;
        }
      
    }
      Console.WriteLine($"O maior número é: {maior}");
}

void MostrarMenor()
{
    if (numeros.Count == 0)
{
    Console.WriteLine("Lista vazia.");
    return;
}
   foreach(int n in numeros)
    {
        if(!valorMenorEncontrado || n < menor)
        {
            menor = n;
            valorMenorEncontrado = true;
        }
        Console.WriteLine($"O menor número é: {menor}");
    }
}

void MostrarMedia()
{
    double media = 0;
    foreach(int n in numeros)
    {
        media += n;
    }
    Console.WriteLine($"A média dos números é: {media / numeros.Count}");
}

void MostrarPares()
{
    foreach(int n in numeros)
    {
        if(n % 2 == 0)
        {
            Console.WriteLine($"Número par: {n}");
        }
    }
}

void MostrarImpares()
{
    foreach(int n in numeros)
    {
        if(n % 2 != 0)
        {
            Console.WriteLine($"Número ímpar: {n}");
        }
    }
    
}