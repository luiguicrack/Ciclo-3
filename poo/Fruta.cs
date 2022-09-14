namespace poo
{
    class Fruta
    {
        private string nombre;
        private int peso;
        public string Color {get; set;}

        public string Textura { get; set; }  //propiedad encapsulada

        //propiedad del campo nombre
        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        //propiedad para el campo peso
        public int Peso
        {
            get{return peso;}
            set{peso = value;}
        }
    }
}