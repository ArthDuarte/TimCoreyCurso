

//4.12, 32, 1.123

decimal bankAccountBalance;
//decimais são mais precisos, usando por exemplo em dados bancários.

bankAccountBalance = 10.5M;
//Ao usar decimais, temos que colocar o M, senão ele irá identificar como doubles.

Console.WriteLine(bankAccountBalance);
Console.WriteLine(bankAccountBalance / 2);

// NUMERO QUE N FOREM DINHEIRO -> DOUBLE
// DINHEIRO -> DECIMAL USANDO O M NO FINAL
