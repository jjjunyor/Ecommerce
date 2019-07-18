using System.Runtime.Serialization;

namespace WebApp.Models
{
    public class Conta 
    {
        public Conta(string numeroConta)
        {
            this.NumeroConta = numeroConta;
        }
        [DataMember]
        public int idConta { get; set; }
        [DataMember]
        public string NumeroConta { get; set; }
        [DataMember]
        public decimal Saldo { get; set; }
    }
    

}
