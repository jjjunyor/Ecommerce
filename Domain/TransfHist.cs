using System;
using System.Collections.Generic;

using System.Runtime.Serialization;

namespace WebApp.Models
{
    public class TransfHist : BaseModel
    {
        private readonly List<TransfHist> _quotes = new List<TransfHist>();
        public TransfHist(string _ContaOrigem, string _ContaDestino){

            this.ContaDestino = new Conta(_ContaOrigem);
            this.ContaOrigem = new Conta(_ContaDestino);

        }
        public void Transferir(string _ContaOrigem, string _ContaDestino, decimal valor)
        {
            var transf = new TransfHist(_ContaOrigem, _ContaDestino);
              _quotes.Add(transf);
        }
        
        [DataMember]
        public int idCliente { get; set; }
        [DataMember]
        public int idContaOrigem { get; set; }
        [DataMember]
        public int idContaDestino { get; set; }
        [DataMember]
        public decimal Valor { get; set; }
        public DateTime DataOcorrencia { get; set; }
        [DataMember]
        public Conta ContaOrigem { get; set; }
        [DataMember]
        public Conta ContaDestino { get; set; }
    }
    public class ParamTransHist
    {
        public string ContaOrigem { get; set; }
        public string ContaDestino { get; set; }
        public decimal Valor { get; set; }

    }
}
