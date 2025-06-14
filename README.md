# ParouImpar
EX4. Verificação de Número Par ou Ímpar
Objetivo: Trabalhar com variáveis int e a estrutura condicional if-else.

Enunciado:
Crie um programa que peça ao usuário um número inteiro e informe se o número é par ou ímpar.

using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite um número inteiro //
        Console.Write("Digite um número inteiro: ");
        int numero;

// Tenta ler e converter a entrada do usuário para um inteiro //
  if (int.TryParse(Console.ReadLine(), out numero))
        {
            // Verifica se o número é par ou ímpar usando o operador módulo (%) //
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
        }
    }
}
