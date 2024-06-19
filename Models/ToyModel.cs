using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Models;

public class ToyModel
{
    public Guid Id {get; set;}
        
        public int codigo {get; set;}
        [Required]
        public string? nombre {get; set;}
        [Required]
        public int precio {get; set;}
        [Required]
        public DateTime Vigencia {get; set;}
        [Required]
        public bool Activo {get; set;}
}