using System.Text;
using System.Globalization;

namespace Course.Entities
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        
        

        public Conta()
        {            
        }

        public Conta(int numero, string nome, double saldo)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Saldo = saldo;
        }

         public Conta(int numero, string nome)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Saldo = 0;
        }


        public void Deposito(double quantia)
        {
            Saldo+= quantia;
        }
        
        public void Saque(double quantia)
        {
            const double taxa = 5.00;
            Saldo = (Saldo - quantia) - taxa;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Conta: ");
            sb.Append(Numero);
            sb.Append(", ");
            sb.Append("Titular: ");
            sb.Append(Nome);
            sb.Append(", ");
            sb.Append("Saldo: ");
            sb.Append("$ ");
            sb.Append(Saldo.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
        
    }
}