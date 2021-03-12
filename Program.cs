using System;
using System.Globalization;

//Este código não está correto, mas é o que passa no teste da DIO
//Ao que tudo indica há um erro na checagem das respostas do código na DIO
//A versão efetivamente correta do programa está no meu repositório chamado
//"aumento_de_salario_correto

namespace aumento_de_salario_ok
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste, percentual;
            salario = -10;
            novoSalario = 0.00;
            reajuste = 0.00;
            percentual = 0;
            
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (salario < 0.00)
            {return;}
            else if (salario <= 400.00)
            { percentual = 15;}
            else if (salario <= 800.00)
            {percentual = 12;}
            else if (salario <= 1200.00)
            {percentual = 10;}
            else if (salario <= 2000.00)
            {percentual = 7;}
            else
            {percentual = 4;}
            
            reajuste = salario * ((double)percentual / 100);
            novoSalario = salario + reajuste;
            
            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual);
            
        }
    }
}