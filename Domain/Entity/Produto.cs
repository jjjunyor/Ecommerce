using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Entity
{
   public class Produto
    {
        public Produto() { }
        [DataMember]
        public int idProduto { get; set; }
        [DataMember]
        public string desProduto { get; set; }
        [DataMember]
        public int quantidade { get; set; }
        [DataMember]
        public decimal Valor { get; set; }
    }
}
