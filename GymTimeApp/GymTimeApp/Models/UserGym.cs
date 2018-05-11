using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTimeApp.Models
{
    public class UserGym
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Routine Routine { get; set; }
        [ForeignKey("RoutineForeignKey")]
        public int IdRoutine { get; set; }
    }
}
