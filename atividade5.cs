/*## Atv5 - Comparação entre estruturas

Escolha uma das atividades anteriores e resolva de duas formas:

- Uma usando `for`;
- Outra usando `while`.
/*
/*
Depois, escreva uma breve explicação dizendo qual das duas formas ficou mais organizada.*/
O 'fo'r ficou mais organizado porque é uma estrutura de repetição que concentra a inicialização, onde a variável é criada,
a condição de parada e o incremento em uma única linha, tornando o código mais compacto e fácil de entender.
Já no 'while' e, esses três elementos ficam espalhados pelo 'código' (a inicialização fica antes 'do' laço 
e o incremento fica solto dentro 'do' bloco). Isso deixa o código mais longo e aumenta o risco de 
esquecermos o contador++,o que levaria a um loop "infinito".
*/
    
public static class atividade5
{
    public static void executar()
    {
        Console.WriteLine("Digite um número para ver a tabuada:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Usando for:");
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }

        Console.WriteLine("\nUsando while:");
        int contadorWhile = 1;
        while (contadorWhile <= 10)
        {
            Console.WriteLine($"{numero} x {contadorWhile} = {numero * contadorWhile}");
            contadorWhile++;
        }
    }
}

