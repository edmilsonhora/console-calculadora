using Console_Calculadora_Testes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1.Testes
{
    public class CalculadoraTestes
    {

        #region "Tipo 1"

        [Fact]
        public void Ao_Somar_dois_valores_o_resultado_deve_ser_a_soma()
        {
            //Arranje
            var sut = new Calculadora(); // Sistem Under Test
            sut.Valor1 = 5;
            sut.Valor2 = 5;

            //Act
            var resultado = sut.Somar();

            //Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Ao_Subtrair_dois_valores_o_resultado_deve_ser_a_subtração()
        {
            //Arranje
            var sut = new Calculadora(); // Sistem Under Test
            sut.Valor1 = 5;
            sut.Valor2 = 5;

            //Act
            var resultado = sut.Subtrair();

            //Assert
            Assert.Equal(0, resultado);            
        }

        #endregion

        #region "Tipo 2"

        [Fact(DisplayName = "Ao dividir dois numeros Caso o divisor seja zero deve lançar Exception")]
        public void Teste2()
        {
            //Arranje
            var sut = new Calculadora(); // Sistem Under Test
            sut.Valor1 = 10;
            sut.Valor2 = 0;

            //Act
            var resultado = Assert.Throws<DivideByZeroException>(() => sut.Dividir());

            //Assert
            Assert.Equal("Divisão por zero", resultado.Message);

        }

        [Fact(DisplayName = "Ao multiplicar dois numeros o resultado deve ser a multiplicação")]
        public void Teste3()
        {
            //Arranje
            var sut = new Calculadora(); // Sistem Under Test
            sut.Valor1 = 10;
            sut.Valor2 = 2;

            //Act
            var resultado = sut.Multiplicar();

            //Assert
            Assert.Equal(20,resultado);

        }

        [Fact(DisplayName = "Ao dividir dois numeros o resultado deve ser a divisão")]
        public void Teste4()
        {
            //Arranje
            var sut = new Calculadora(); // Sistem Under Test
            sut.Valor1 = 5;
            sut.Valor2 = 2;

            //Act
            var resultado = sut.Dividir();

            //Assert
            Assert.Equal(2.5m, resultado);

        }

        #endregion
    }
}
