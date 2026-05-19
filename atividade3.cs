/*## Atv3 — Números pares

Crie um programa que mostre os números pares de `2` até `20` usando `for`. (proíbido o uso de foreach ou qualquer outro tipo, é permitido somente o uso de for)

Exemplo de saída:

```
2
4
6
8
10
12
14
16
18
20
```*/

public static class atividade3
{
    public static void executar()
    {
        for (int contador = 2; contador <= 20; contador += 2)
        {
            Console.WriteLine(contador);
        }
    }
}
