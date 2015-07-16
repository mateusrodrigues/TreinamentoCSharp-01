using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contato meuContato = new Contato();
            //meuContato.Nome = "Sylvia Helena";
            //meuContato.Email = "basbdasd";
            //meuContato.Numero = 123;

            //var meuContato = new Contato()
            //{
            //    Nome = "Gamarra",
            //    Email = "gamarra@dez.com",
            //    Numero = 5551234
            //};

            //Console.WriteLine(meuContato);
            //Console.ReadLine();

            Agenda minhaAgenda = new Agenda();

            minhaAgenda.Contatos.Add(new Contato()
            {
                Nome = "Falsiane",
                Email = "falsiane@hotmail.com",
                Numero = 12345
            });

            minhaAgenda.Contatos.Add(new Contato()
            {
                Nome = "Falsiane 2",
                Email = "falsiane2@hotmail.com",
                Numero = 123456780
            });

            Contato meuContato = new Contato()
            {
                Nome = "Cicrano",
                Email = "cicrano@hotmail.com",
                Numero = 123
            };
            minhaAgenda.Contatos.Add(meuContato);

            minhaAgenda.Contatos.ForEach(m => Console.WriteLine(m + "\n"));
            Console.ReadLine();

            minhaAgenda.AdicionarContato();
            minhaAgenda.Contatos.ForEach(m => Console.WriteLine(m + "\n"));
            Console.ReadLine();
        }
    }
}
