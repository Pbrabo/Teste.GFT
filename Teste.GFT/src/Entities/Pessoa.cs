using System;

namespace Teste.GFT.src
{
    public class Pessoa
    
    {    
        private string Name {get; set;}
        private DateTime DataNascimento{get; set;}
        private double Altura{get; set;}


        public void SetNome(string name){
            Name = name;
        }

        public void SetDataNascimento(DateTime dataNascimento){
            DataNascimento = dataNascimento;
        }
        public void SetAltura(int altura){
            Altura = altura;
        }

        public int CalcularIdade()
        {
                int idade = 0;
                idade = DateTime.Now.Year - DataNascimento.Year;
                if (DataNascimento.Date > DateTime.Now.AddYears(-idade))
                {
                    idade = idade - 1;
                }
            
            return idade;
        }

        public void ImprimeDadosPessoa()
        {
            Console.WriteLine(Name);
            Console.WriteLine(DataNascimento);
            Console.WriteLine(Altura);
            Console.WriteLine(CalcularIdade());
        }
    }
}