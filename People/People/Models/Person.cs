using SQLite;

namespace People.Models;

// La clase Person es un modelo de datos que representa una tabla de la base de datos (people).
[Table("people")]
public class Person
{
    // El atributo Id es la clave primaria de la tabla people, y se genera automáticamente.
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    // El atributo Name es el nombre de la persona, y es único.
    [MaxLength(250), Unique]
    public string Name { get; set; }
}