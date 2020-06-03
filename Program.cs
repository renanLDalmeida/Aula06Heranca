using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           CPF cpf = new CPF();
           cpf.nome = "Renan";
           Console.WriteLine( cpf.Saudacao() );

           cpf.cpf = "123.456.789-0";
           Console.WriteLine( cpf.ValidarCPF() );
    }
}

}
