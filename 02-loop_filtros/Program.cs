
List<int> numeros = new List<int>();
int numero =0;
int soma =0;
Console.WriteLine("Bem-vindo ao programa de soma de números!");
Console.WriteLine("Digete 0 para sair");

do
{
    Console.WriteLine("Digite um número:");
    numero =int.TryParse(Console.ReadLine(), out int num) ? num : 0;
    
    
    if (numero != 0)
    {
       
        numeros.Add(numero);      
        
        soma += numero;
    }
    else
    {
        Console.WriteLine($"A soma dos números é: {soma}");
        Thread.Sleep(2000);
        Console.WriteLine("Saindo...");

        
    }
    
}   while (numero != 0);
