

namespace SegundoParcial.Entities
{
    public class Juguete
    {
        public Guid Id {get; set;}
        
        public int codigo {get; set;}
       
        public string? nombre {get; set;}
        
        public int precio {get; set;}
        
        public DateTime Vigencia {get; set;}
        
        public bool Activo {get; set;}

    }
}