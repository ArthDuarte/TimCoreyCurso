// Peça para o usuário informar sua idade.
// Calcule e mostre em que ano ele nasceu.
// Calcule e mostre em que ano ele terá o dobro da idade atual.

Console.Write("Olá, me fale sua idade: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    int anoNascimento = DateTime.Now.Year - age;
    int anoDobroIdade = anoNascimento + (age * 2);

    Console.WriteLine($"Ah, então você tem {age} anos, nasceu em {anoNascimento}, e terá {age * 2} anos no ano {anoDobroIdade}.");
}
else
{
    Console.WriteLine("Deu erro, por favor digite um número válido.");
}
