//Criar um Console App usando variáveis para Primeiro nome, idade, estado de saude e telefone celular.

string primeiroNome;
string ultimoNome;
int idade;
bool estadoDeSaude;
int ddd;
int telefoneCelular;

primeiroNome = "Maria";
ultimoNome = "Joaquina";
idade = 25;
estadoDeSaude = true;
ddd = 61;
telefoneCelular = 99999999;

Console.WriteLine($"Olá, eu sou a {primeiroNome} {ultimoNome}, tenho {idade} anos, meu telefone é {ddd} {telefoneCelular} e {(estadoDeSaude ? "estou bem de saúde" : "não estou bem de saúde")}.");
