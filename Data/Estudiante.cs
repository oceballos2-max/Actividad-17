public class Estudiante
{
    public int Id { get; set; } // Clave primaria para la base de datos
    public string Nombre { get; set; } = "";
    public string Correo { get; set; } = "";
    public int Calificacion { get; set; }
}