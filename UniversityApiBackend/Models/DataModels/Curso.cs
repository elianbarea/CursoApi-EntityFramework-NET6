using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Level { Básico, Intermedio, Avanzado}
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(280)]
        public string ShortDescription { get; set; }

         [Required]
        public string LongDescription { get; set; }

         [Required]
        public string TargetAudiences { get; set; }

        [Required]
        public string Objetive { get; set; }

        [Required]
        public string Requirement { get; set; }

        [Required]
        public Level Level { get; set; }

    }
}
