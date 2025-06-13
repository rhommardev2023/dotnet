using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.classes // namespace para organizar o codigo   
{
    public class Pessoa // classe Pessoa que representa uma pessoa
    {
        //atributos se inica con prop 
        public string Nome { get; set; }
        public int Idade { get; set; } //get y set son los metodos de acceso get= obtener y set= asignar

        // creacion de um metodo que es la accion a ejecutar
        public void Apresentar() // metodo que imprime na tela ou chamada do metodo
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
