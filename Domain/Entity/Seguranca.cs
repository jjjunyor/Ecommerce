using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Entity
{
    public class Seguranca
    {
        public Seguranca() { }
        [DataMember]
        public int idToken { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public DateTime DataGeracao { get; set; }

    }
}
