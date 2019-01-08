using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class PacienteDebito
    {
        public PacienteDebito()
        {
        }

        public int PacienteDebitoId { get; set; }

        public int QtdCreditos { get; set; }

        public DateTime Data { get; set; }

        public int PacienteId { get; set; }       
        
        public Paciente Paciente { get; set; }

    }
}
