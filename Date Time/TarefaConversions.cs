// Pedir ao usuário que fale sua idade
// E assim printar a idade dele, a idade dele +25 anos e a idade dele -25 anos.

Console.Write("Qual sua idade?: ");
string input = Console.ReadLine(); // Lê a entrada do usuário

// Converter string para int
if (int.TryParse(input, out int age)) // Usa TryParse para evitar erros se a entrada for inválida
{
    int idadeAvançada = age + 25;
    int idadeRetrasada = age - 25;

    Console.WriteLine($"Oh, então sua idade é {age} e sei que daqui 25 anos você terá {idadeAvançada} e que antes você tinha {idadeRetrasada}.");
}
else
{
    Console.WriteLine("Por favor, insira um número válido para sua idade.");
}
