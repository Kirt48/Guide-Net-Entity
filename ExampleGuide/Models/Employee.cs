using System.ComponentModel.DataAnnotations; // Esto nos permite hacer la validacion de Required

namespace ExampleGuide.Models
{
    public class Employee
    {

        public Guid EmployeeId { get; set; }


        [Required(ErrorMessage ="Campo {0} requerido")] // Validacion de requerido
        [Display(Name ="Nombre")] // Como se reconocera el campo en el front
        public string Name { get; set; }



        [Required(ErrorMessage = "Campo {0} requerido")] // Validacion de requerido
        [Display(Name = "Apellido")] // Como se reconocera el campo en el front
        public string LastName { get; set; }


        [Required(ErrorMessage = "Campo {0} requerido")] // Validacion de requerido
        [Display(Name = "Telefono")] // Como se reconocera el campo en el front
        public string Phone { get; set; }


        [Required(ErrorMessage = "Campo {0} requerido")] // Validacion de requerido
        [Display(Name = "Estado")] // Como se reconocera el campo en el front
        public int Status { get; set; }
        
        
    }
}
