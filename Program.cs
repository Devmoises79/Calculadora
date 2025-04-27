using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Calculadora Simples!");
        Console.WriteLine("---------------------------- \n");
        

        // Exibindo o menu de opções para o usuário
        Console.WriteLine("Escolha a operação: \n");
        Console.WriteLine("1 - Soma \n");
        Console.WriteLine("2 - Subtração \n");
        Console.WriteLine("3 - Multiplicação \n");
        Console.WriteLine("4 - Divisão \n");

        // Lê a escolha do usuário
        int escolha = Convert.ToInt32(Console.ReadLine());

        // Solicita ao usuário os números para a operação
        Console.Write("Digite o primeiro número: \n");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: \n");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        // Realiza a operação com base na escolha
        switch (escolha)
        {
            case 1:
                resultado = num1 + num2;  // Soma
                break;
            case 2:
                resultado = num1 - num2;  // Subtração
                break;
            case 3:
                resultado = num1 * num2;  // Multiplicação
                break;
            case 4:
                // Verifica se o usuário não está tentando dividir por zero
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero!");
                    return;
                }
                resultado = num1 / num2;  // Divisão
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        // Exibe o resultado da operação para o usuário
        Console.WriteLine($"O resultado da operação é: {resultado} \n");

        Console.WriteLine("Obrigado por usar a Calculadora Simples!");
        Console.WriteLine("----------------------------");
    }
}
