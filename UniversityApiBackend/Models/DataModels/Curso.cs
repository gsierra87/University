using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;

        [StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public Niveles Nivel { get; set; }

        public enum Niveles
        {
            Básico,
            Intermedio,
            Avanzado
        }

    }
}
