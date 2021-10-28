using System;
namespace Course.Excecao
{
    public class FormatoErrado : Exception
    {
        public FormatoErrado(string message)
            : base(message)
        {
            
        }
    }
}