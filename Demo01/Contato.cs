using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo01
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nEmail: "
                + Email + "\nNumero: " + Numero;
        }
    }
}
