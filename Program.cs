//Programa para calcular o Índice de Massa Corporal (IMC) e classificar o resultado
//Autor: Nathaline Santos
//Data: 02/04/2026
//Descrição: Este programa solicita ao usuário seu nome, idade, peso e altura, calcula o IMC e classifica o resultado de acordo com as categorias estabelecidas pela Organização Mundial da Saúde (OMS).
//Observação: Certifique-se de que o usuário insira valores válidos para peso e altura para evitar erros de cálculo.
//Nota: Este programa é apenas para fins educacionais e não deve ser usado como uma ferramenta de diagnóstico médico. Para avaliações de saúde, consulte um profissional de saúde qualificado.


Console.WriteLine("Hello, World!");

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("digite seu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine();
Console.WriteLine($"Nome: {nome}, Idade: {idade} anos.");
Console.WriteLine($"Seu IMC é: {imc:F2}");

if (imc < 18.5)
{
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Classificação: Peso normal");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Classificação: Sobrepeso");
}
else
{
    Console.WriteLine("Classificação: Obesidade");
}

