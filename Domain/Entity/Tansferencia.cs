using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Entity
{
    public class Tansferencia
    {
        [DataMember]
        public string ContaOrigem { get; set; }
        [DataMember]
        public string ContaDestino { get; set; }
        [DataMember]
        public string CPFDestino { get; set; }
        [DataMember]
        public string TipoTransferencia { get; set; }
        [DataMember]
        public decimal Valor { get; set; }

    }



}
