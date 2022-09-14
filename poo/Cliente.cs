namespace poo
{
    class Cliente : Persona
    {
        //propiedades de la clase cliente
        public int IdCliente { get; set; }

        //constructor
        public cliente(string name, string lastname, int edad, int idCliente) : base (name, lastname, edad)
        {
            //super (name, lastname, edad);
            this.IdCliente = idCliente;
        }
    }
}