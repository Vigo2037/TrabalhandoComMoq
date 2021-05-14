using System;
using Xunit;
using TrabalhandoComMoq;
using Moq;

namespace TrabalhandoComMoqTeste
{
    public class PessoaTeste
    {
        [Fact]
        
        public void VerificaIdadeTeste()
        {
            //Arrange
            Pessoa Pedro = new Pessoa();
            Pedro.idade = 22;

            Mock<IVerificaIdade> mock = new Mock<IVerificaIdade>();
            mock.Setup(m=> m.VerificaIdade(Pedro)).Returns("Adulto");     

            Pessoa verifica = new Pessoa();

            //Act
            var idadeEsperada = mock.Object.VerificaIdade(Pedro);
            var idade = verifica.VerificaIdade(Pedro);

            //Assert
            Assert.Equal(idade, idadeEsperada);
        }
    }

    public class TesteCPF
    {
        [Fact]
        public void VerificaCPF()
        {
            //Arrange
            Pessoa Pessoa = new Pessoa();
            Pessoa.CPF = ("12345678909");

            Mock < IVerificaCPF > mock = new Mock<IVerificaCPF>();
            mock.Setup(m => m.VerificaCPF(Pessoa)).Equals(true);

            Pessoa verifica = new Pessoa();

            //Act
            var numerocpf = mock.Object.VerificaCPF( Pessoa);
            var cpf = verifica.VerificaCPF(Pessoa);


            //Assert
            Assert.Equal(cpf, numerocpf);

        }


    }
    public class TesteMaiuscula
    {
        public string nome { get; private set; }

        [Fact]
        public void IVerificaletra()
        {
            //Arrange
            Pessoa Pedro = new Pessoa();
            Pedro.Nome = ("Pedro");

            var mock = new Mock<IVerificaLetra>();
            mock.Setup(m => m.VerificaLetra(Pedro)).Returns("Pedro");

            Pessoa verifica = new Pessoa();

            //Act
            var letranome = mock.Object.VerificaLetra(Pedro);
            var nome = verifica.VerificaLetra(Pedro);


            //Assert
            Assert.Equal(nome, letranome);

        }


    }
}
