

Console.WriteLine(value:"Qual sua idade: ");
string? ageText = Console.ReadLine();

//Console.WriteLine (ageText + 15); errado, pois ele entende que o ageText é uma string e o 15 é um número, então vai imprimir, por exemplo 3015

int age = int.Parse(ageText);

//Então o parse seria um método de conversão de strings para dados, geralmente usados quando uma string é um número e se quer usar int, decimal ou bool com o valor daquela string.
//É melhor o TryParse, porque aí ele vai retornar true ou false quando ocorre algum erro

Console.WriteLine(age + 15);