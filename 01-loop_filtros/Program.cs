List<double> notas = new List<double>();
Console.WriteLine("Digite as notas (digite -1 para finalizar):");
while (true)
{
    Console.Write("Nota: ");
    if(!double.TryParse(Console.ReadLine(), out double nota))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
        continue;
    }
    if(nota == -1)
    {
        Console.WriteLine("Encerrando sistema... ");
        break;
    }
    notas.Add(nota);

    if(notas.Count == 0)
    {
        Console.WriteLine("Nenhuma nota foi inserida.");
        return;
    }

    double soma =0;
    int acimade7=0;
    int abaixode7=0;
    foreach(double n in notas)
    {
        soma += n;
        if(n >= 7)
        {
            acimade7++;
        }
        else
        {
            abaixode7++;
        }
    }
    double media = soma / notas.Count;

    Console.WriteLine($"\nTotal de notas: {notas.Count}");
    Console.WriteLine($"Média: {media}");
    Console.WriteLine($"Acima ou igual a 7: {acimade7}");
    Console.WriteLine($"Abaixo de 7: {abaixode7}");

}    