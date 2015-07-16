using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo01
{
    public class Agenda : IAgendaMassa
    {
        public List<Contato> Contatos { get; private set; }

        public Agenda()
        {
            Contatos = new List<Contato>();
        }

        public void AdicionarContato()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();

            Console.Write("Digite o numero: ");
            int numero;
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Erro na conversão");
                numero = 0;
            }

            Contato novoContato = new Contato()
            {
                Nome = nome,
                Email = email,
                Numero = numero
            };

            this.Contatos.Add(novoContato);
        }
    }
}
