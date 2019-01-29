using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Paciente
    {
        public Paciente()
        {
        }

        public int PacienteId { get; set; }

        public string Nome { get; set; }

        public int CidadeId { get; set; }

        public string Endereco { get; set; }

        public string Complemento { get; set; }

        public string CEP { get; set; }

        public string TelCelular { get; set; }

        public string TelResidencial { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public int Creditos { get; set; }   

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Foto { get; set; }

        public DateTime DataNascimento { get; set; }

        public  Cidade Cidade { get; set; }

        public virtual ICollection<PacienteCredito> PacienteCreditos { get; set; }

        public virtual ICollection<PacienteDebito> PacienteDebitos { get; set; }

    }
}
