using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Entities
{
    public class Marca
    {
        public Guid Id {get; set;}

        public int codigo {get; set;}
        
        public string? Nombre {get; set;}
        
        public bool Activo {get; set;}
    }
}