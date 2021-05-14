using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComMoq
{
    public interface IVerificaIdade
    {
        string VerificaIdade(Pessoa p);
    }
    public class Pessoa : PessoaBase, IVerificaIdade
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string telefone { get; set; }
        public int idade { get; set; }

        public string VerificaIdade(Pessoa p) 
        {
            if (p.idade >= 21)
                return "Adulto";
            else
                return "Jovem ou criança";
        }

        public object VerificaCPF(Pessoa pedro)
        {
            throw new NotImplementedException();
        }

        public object VerificaLetra(Pessoa pedro)
        {
            throw new NotImplementedException();
        }
    }

    public class PessoaBase
    {
    }

    public interface IVerificaCPF
    {
        String VerificaCPF(Pessoa p);
        void VerificaCPF(PessoaCPF pedro);
    }

    public class PessoaCPF : Pessoa, IVerificaCPF

     
    {
        public new(string, string) CPF;

        public static bool ValidaCPF(object CPF)

        {

            string valor = validaCPF(".", "") ;

            valor = valor.Replace("-", "");



            if (valor.Length != 11)

                return false;



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;



            if (igual || valor == "12345678909")

                return false;



            int[] numeros = new int[11];



            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());



            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)

                    return false;

            }

            else if (numeros[9] != 11 - resultado)

                return false;



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)

                    return false;

            }

            else

                if (numeros[10] != 11 - resultado)

                return false;



            return true;

        }

        private static string validaCPF(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public new string VerificaCPF(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public void VerificaCPF(PessoaCPF pedro)
        {
            throw new NotImplementedException();
        }
    }
    public interface IVerificaLetra
    {
        String VerificaLetra(Pessoa p);
        string LetraMaiuscula(Pessoa p);
        void VerificaCPF(Pessoa pedro);
    }
    public class Validator : IVerificaLetra
    {
        public static string PrimeiraMaiuscula(String Pessoa)

        {

            string strResult = "";

            if (Pessoa.Length > 0)

            {

                strResult += Pessoa.Substring(0, 1).ToUpper();

                strResult += Pessoa.Substring(1, Pessoa.Length - 1).ToLower();

            }

            return strResult;

        }

        public string LetraMaiuscula(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public void VerificaCPF(Pessoa pedro)
        {
            throw new NotImplementedException();
        }

        public string VerificaLetra(Pessoa p)
        {
            throw new NotImplementedException();
        }

        string IVerificaLetra.VerificaLetra(Pessoa p)
        {
            throw new NotImplementedException();
        }
    }
}