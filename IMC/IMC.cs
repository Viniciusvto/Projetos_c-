//  Exercicio contendo uma classe, um método, variaveis, Laço de repetição, conversão de tipos e exibição de resultados.

using System; 

class IMC //Crio a classe IMC 
{ 
static void Main(string[] args) // Crio o método
{
    double IMC = 0; // Crio a variavel media e inicializo com 0 pois vou implementar um laço de repetição
    string resposta = "s"; // Crio a variável resposta e inicializo com "s" para entrar no laço de repetição
    
    do
{
    Console.WriteLine("Digite o seu Peso"); // Solicito ao usuário que digite o peso
    double peso = Convert.ToDouble(Console.ReadLine()); // O Double pega o valor e transforma em um número decimal

    Console.WriteLine("Digite a sua Altura"); // Solicito ao usuário que digite a altura
    double altura = Convert.ToDouble(Console.ReadLine()); // O Double pega o valor e transforma em um número decimal

    IMC = peso / (altura * altura); // Faço o cálculo do IMC dividindo o peso pela altura ao quadrado
    Console.WriteLine("Seu IMC é:" + IMC); // Exibo o IMC calculado
    
    Console.WriteLine("Quer calcular outro? (s/n)"); // Pergunto ao usuário se ele quer calcular outro IMC
     resposta = Console.ReadLine(); // Leio a resposta do usuário e armazeno na variável resposta

} while (resposta.ToLower() == "s"); // O ToLower converte a resposta para minúsculas, assim o usuário pode digitar "S" ou "s" e o programa continuará funcionando

     Console.WriteLine("Obrigado por usar o programa!");

}
}
