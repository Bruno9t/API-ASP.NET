using System.ComponentModel.DataAnnotations;



namespace aspnetcore.Models
{

    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(60, ErrorMessage = "Deve conter entre 3 e 60 caracteres", MinimumLength = 3)]

        public string Title { get; set; }

    }

}