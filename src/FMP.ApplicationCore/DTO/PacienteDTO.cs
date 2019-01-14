using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.DTO
{
    public class PacienteDTO
    {
        public PacienteDTO()
        {
        }

        public Paciente Paciente { get; set; }

        public ICollection<PacienteCredito> PacienteCreditos { get; set; }

        public ICollection<PacienteDebito> PacienteDebitos { get; set; }
    }
}
