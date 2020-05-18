using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
       private string nome;
        private double altura,peso;
        private int idade;

       
        public string Nome 
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
                get{ return this.nome; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura minima deve ser de 1.00m.");
                }
            }
            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso minimo deve ser de 1kg.");
                }
            }
            get { return this.peso; }
        }
        public int Idade
        {
            set
            {
                if (value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade minima deve ser de 1 ano.");
                }
            }
            get { return this.idade; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa:\n\nNome:" + this.nome +
                "\nAltura:" + this.altura.ToString("0.00") + "m"+ 
                "\nPeso:" + this.peso.ToString("00") + "kg" +
                "\nIdade:" + this.idade.ToString("00")  ;
        }


        public  double Resultado()
        {
            return this.peso / this.altura * this.altura;
        }
      

      







    }
}
