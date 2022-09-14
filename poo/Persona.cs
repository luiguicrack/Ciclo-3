namespace poo
{
    class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Edad { get; set; }

        public Persona(string name, string lastname, int edad)
        {
            Name = name;
            LastName = lastname;
            Edad = edad;
        }

        //metodo regular
        public void saludoPersona()
        {
            System.Console.WriteLine($"¡Hola¡ Bienvenido {Name} {LastName}");
        }
    }
}