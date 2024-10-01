//Exemplo de TryCatch com numeradror e denominador
//O bloco try-catch em c# permite que voce execute um bloco de codigo
//(try) que pode gerar exceçoes. Se uma excessão ocorrer, ela ira ser tratada no bloco catch.


//try 
//{
//    Console.Write("Digite o numerador: "); // string "5" == 5 int  ---> conversão
//    int numerador = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int resultado = numerador / denominador;
//    Console.WriteLine($"O resultado da divisão é: {resultado}");
//} catch(DivideByZeroException)
//{
//   Console.WriteLine("Erro: Não é posivel dividir por zero");
//}

//catch(FormatException)
//{
//    Console.WriteLine("Erro: Por Favor, digite um numeros válidos!!!");
//}



/*Exemplo 2 com casas decimais utilizando Double e convertendo com Try.Parse*/
using System.Globalization;

///*Exemplo 1 com Valores inteiros*/
try
{
    Console.Write("Digite o numerador: ");
    double numerador;
    // ! - Significa diferente
    while(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))

    {
        Console.WriteLine("Erro: Digite numero Valido!");
        Console.Write("Digite o denominador ");
    }


    Console.WriteLine("Digite o denominador: ");
    double denominador;

    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))

    {
        Console.WriteLine("Erro: Digite numero Valido!");
        Console.Write("Digite o denominador ");
    }


    //Verifica o valor do denominador e caso seja zero gera uma excessão
    if (denominador == 0) 
    {
        throw new DivideByZeroException();
    }

    double resultado =  numerador / denominador;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é posivel dividir por zero");
}

catch (FormatException)
{
    Console.WriteLine("Erro: Por Favor, digite um numeros válidos!!!");
}
Console.ReadKey();
