namespace poo
{
    class Animals
    {
        public string name; //campo
        public string raza; //campo
        public int nac;
        private string color;

        //declarar metodo constructor 
        public Animals(string name, string raza)
        {
            this.name = name;
            this.raza = raza;
            this.nac = nac;
        }


        //metodo get y set del atributo color
        //get
        public string getcolor()
        {
            return this.color;
        }

        //set
        public void setcolor (string color)
        {
            this.color = color;
        }

    }
}