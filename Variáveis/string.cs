// EXPLICAÇÕES SOBRE USO DE STRINGS
//variaveis seguram informação
//usar camelCase para strings
string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;
string testString = string.Empty;

firstName = "Arthur";
lastName = "Cardoso";

//filePath = "C:\\temp\\Demo"; funcional, mas não otimizado
filePath = @"C:\temp\Demo";
// ao usar o @, ele irá tratá tudo como string, independente do que esteja (mesmo scape caracteres) (exceto string interpolations)

//Console.WriteLine(firstName + " " + lastName); Modo errado de colocar espaços
// string interpolation > usar o $, para usar várias strings juntas
Console.WriteLine($"{firstName} {lastName} {filePath}");
//colocar o $ indica que mesmo sendo string, ou qualquer outra coisa, estando dentro das {} ele lerá como código, como var, como string etc, podendo usar espaços entre strings de forma mais correta.

testString = $@"O arquivo do {firstName} está dentro do C:\user\artu";
Console.WriteLine(testString);
