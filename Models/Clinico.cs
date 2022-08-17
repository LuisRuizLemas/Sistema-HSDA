using System.ComponentModel.DataAnnotations;

namespace SistemaHSDA.Models

{
    public class Clinico 
    {
        [Key]
        public int VCHNUMEXPEDIENTE { get; set; }
        public string? VCHNOMBRE { get; set; }

    }
}