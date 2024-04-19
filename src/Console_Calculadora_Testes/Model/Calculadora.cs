using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculadora_Testes.Model
{
    public class Calculadora
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public decimal Somar()
        {
            return Valor1 + Valor2;
        }
        public decimal Subtrair()
        {
            return Valor1 - Valor2;
        }
        public decimal Multiplicar()
        {
            return Valor1 * Valor2;
        }
        public decimal Dividir()
        {
            if(Valor2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero");
            }

            return Valor1 / Valor2;
        }
       
    }
}
