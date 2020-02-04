using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Projeto.Models
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Nome { get; set; }
        [DataMember]
        [Required]
        public bool Pf_Pj { get; set; }
        [DataMember]
        [Required]
        public string Documento { get; set; }
        [DataMember]
        [Required]
        public DateTime DataCadastro { get; set; }
        [DataMember]
        [Required]
        public string Telefone { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
