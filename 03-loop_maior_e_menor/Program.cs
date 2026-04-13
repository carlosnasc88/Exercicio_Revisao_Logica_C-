int numero;
int soma = 0;
int contador = 0;
int maior = 0;
int menor = 0;
bool primeiroNumero = true;

Console.WriteLine("Seja bem vindo ao sistema, encontre o maior e menor número.");

do
{
    Console.Write("Digite um número (0 para sair): ");

    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Valor inválido!");
        continue;
    }

    if (numero != 0)
    {
        // primeiro número define base
        if (primeiroNumero)
        {
            maior = numero;
            menor = numero;
            primeiroNumero = false;
        }

        if (numero > maior)
            maior = numero;

        if (numero < menor)
            menor = numero;

        soma += numero;
        contador++;
    }

} while (numero != 0);

// 👉 resultado final

if (contador == 0)
{
    Console.WriteLine("Nenhum número foi digitado.");
}
else
{
    double media = soma / (double)contador;

    Console.WriteLine($"\nMaior número: {maior}");
    Console.WriteLine($"Menor número: {menor}");
    Console.WriteLine($"Média: {media}");
}

Console.WriteLine("Encerrando...");