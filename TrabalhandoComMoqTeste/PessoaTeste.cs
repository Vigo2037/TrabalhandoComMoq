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
}
