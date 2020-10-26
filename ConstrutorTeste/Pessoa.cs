using System;
using System.Collections.Generic;
using System.Text;

namespace ConstrutorTeste
{
    class Pessoa
    {
        public static String Nome = "EMERSON";
        public static int Idade = 23;

        public Pessoa(string nome , int idade ){
            Nome = nome;
            Idade = idade;
        }
        
        /* public override string ToString()
         {
             return "Nome " + Nome + " Idade " + Idade; 

         }*/
    }
}
