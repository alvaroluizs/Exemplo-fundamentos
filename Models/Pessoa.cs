using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_fundamentos.Models
{
    public class Pessoas
    {
     public string Nome {get; set;}    
     public int Idade {get; set;}

     public void Apresentar()
     {
        Console.WriteLine($"Olá, meu nome é \n" +
        $"{Nome}, e tenho {Idade} anos");

     }

    }
}