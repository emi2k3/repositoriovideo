namespace Library;

public class Persona
{
public string nombre;
public DateTime fechaNacimiento;

    public Persona(string nombre, DateTime nacimiento) {
        this.nombre = nombre;
        this.fechaNacimiento = nacimiento;
    }



    public int GetAge() {  
        DateTime hoy = DateTime.Today;
        int edad =  hoy.Year - this.fechaNacimiento.Year;
        if (hoy.Month < this.fechaNacimiento.Month)
        {
            edad = edad - 1;
        }

        else if (hoy.Month == this.fechaNacimiento.Month && hoy.Day < this.fechaNacimiento.Day)
        {
            edad = edad - 1;
        }
        return edad;
    }
  
}