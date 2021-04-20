using System; 
using Utilidades;
 
namespace Person
{ 
    /// <summary>
    /// Clase que crea "personas" y envia un mensaje con la informacion de la persona(objeto).
    /// </summary>
    public class type_Person 
    { 
        // Declaración de los atributos y de sus getters y setters.
        private string name; 
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Ingresar nombre.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        private string id; 
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Cedula incorrecta");
                }
            }
        }
        
        // Creacion del constructor de la clase.
        public type_Person(string name, string id) 
        { 
            this.name = name; 
            this.id = id; 
        } 

        // Metodo de clase. Imprime en pantalla el nombre y cedula del objeto.
        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 
}