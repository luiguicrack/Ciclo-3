using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    class Historia
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}