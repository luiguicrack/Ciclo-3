using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    class Paciente : Persona
    {
        public string Direccion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string cuidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public FamiliarDesignado Familiar { get; set; }
        public Enfermera Enfermera { get; set; }
        public Medico Medico { get; set; }
        public Historia Historia { get; set; }
        public List<SignoVital> SignosVitales { get; set; }

    }
}