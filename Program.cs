// See https://aka.ms/new-console-template for more information

//primeiros passos com C#

/*Console.WriteLine("Hello, World!");
Console.WriteLine("teste");
Console.WriteLine("nombre");*/

using dotnet.classes; // importando o namespace dotnet.classes 
// instanciando um objeto da classe Pessoa

Pessoa pessoa1 = new Pessoa(); //instancia de um objeto da classe Pessoa   

pessoa1.Nome = "João"; // atribuindo valor ao atributo Nome
pessoa1.Idade = 30; // atribuindo valor ao atributo Idade       
// chamando o metodo Apresentar
pessoa1.Apresentar(); // chamando o metodo Apresentar da classe Pessoa  

