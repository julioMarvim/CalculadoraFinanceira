using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceira
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoPoupanca();
        }
            public static void CalculoPoupanca()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("            ***CALCULADORA FINANCEIRA - POUPANCA***");
            Console.WriteLine("--------------------------------------------------------------------");

            //Valor a ser aplicado
            Console.Write("Informe o valor da Aplicação: ");
            double valorAplicado = double.Parse(Console.ReadLine());


            //% de rendimento mensal na poupança
            Console.Write("Informe o juros de Poupança: ");
            double juros = double.Parse(Console.ReadLine());

            //Quantidade de meses que o dinheiro ficará aplicado
            Console.Write("Infomre por quanto tempo deseja investir: ");
            int meses = int.Parse(Console.ReadLine());

            CalculadoraFinanceira poupanca = new CalculadoraFinanceira();//Instanciando a classe Poupanca.

            //Armazenando os valores de entrada nos atributos da classe "Poupanca"
            poupanca.aplicacao = valorAplicado;
            poupanca.meses = meses;
            poupanca.juros = juros;
            poupanca.Juros(poupanca.juros);// armazenando o valor fornecido pelo usuario em um metodo da classe "Poupanca"

            //Chamando o metodo Criado para armazenar a logia da aplicação em poupança
            poupanca.ResultadoAplicacao(poupanca.aplicacao, poupanca.meses);

            Console.Write("Valor para Aplicação em poupança por {0} meses sera: R${1}", poupanca.meses, Math.Round(poupanca.aplicacao, 2));
            Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("            ***CALCULADORA FINANCEIRA - RENDA FIXA***");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Informe o juros de Renda Fixa: ");
            double jurosRendaFixa = Convert.ToDouble(Console.ReadLine());

            CalculadoraFinanceira rendaFixa = new CalculadoraFinanceira();

            rendaFixa.aplicacao = valorAplicado;
            rendaFixa.meses = meses;
            rendaFixa.juros = juros;
            rendaFixa.Juros(rendaFixa.juros);

            rendaFixa.AplicacaoEmRFixa(rendaFixa.aplicacao, rendaFixa.meses);

            Console.Write("Valor para Aplicação em poupança por {0} meses sera: R${1}", rendaFixa.meses, Math.Round(rendaFixa.aplicacao, 2));
            Console.ReadLine();
            

            if (poupanca.aplicacao > rendaFixa.aplicacao)
            {
                Console.Write("Poupança é mais indicada pois terá um maior rendimento.");
                Console.ReadLine();
            }else
            {
                Console.Write("Renda Fixa é mais indicada pois terá um maior rendimento.");
                Console.ReadLine();
            }
            }
    }
}
    

