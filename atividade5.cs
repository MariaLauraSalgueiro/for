/*## Atv5 - Comparação entre estruturas

Escolha uma das atividades anteriores e resolva de duas formas:

- Uma usando `for`;
- Outra usando `while`.

Depois, escreva uma breve explicação dizendo qual das duas formas ficou mais organizada.*/

public static class atividade5
{
    public static void executar()
    {
        Console.WriteLine("Digite um número para ver a tabuada:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Usando for:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }

        Console.WriteLine("\nUsando while:");
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine($"{numero} x {j} = {numero * j}");
            j++;
        }
    }
}

