using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Models;

public class MarcasModel
{
    public Guid Id {get; set;}
        [Required]
        public int codigo {get; set;}
        [Required]
        public string? Nombre {get; set;}
        [Required]
        public bool Activo {get; set;}
}