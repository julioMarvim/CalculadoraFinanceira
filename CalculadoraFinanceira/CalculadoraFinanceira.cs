using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceira
{
    class CalculadoraFinanceira
    {
        public double aplicacao;
        public double juros;
        public int meses;

        public void Juros(double Valor)
        {
            juros /= 100; 
        }

        public void ResultadoAplicacao(double valor, int tempo)
        {
            for (int i = 1; i <= this.meses; i++)
            {
                this.aplicacao += (this.aplicacao * this.juros);   
            }
 
        }
        public void AplicacaoEmRFixa(double valor, int tempo)
        {
            for (int i = 1; i <= this.meses; i++)
            {
                this.aplicacao += (this.aplicacao * this.juros);
            }
            //Calculando o imposto de Renda
            if (this.meses <= 12)
            {
                this.aplicacao -= (this.aplicacao * 0.25);
            }
            else if (this.meses >= 13 && this.meses <= 24)
            {
                this.aplicacao -= (this.aplicacao * 0.15);
            }
            else if (this.meses <= 25 && this.meses <= 36)
            {
                this.aplicacao -= (this.aplicacao * 0.05);
            }
            else
            {
                this.aplicacao -= (this.aplicacao * 0.01);
            }
        }

    }

}
