using System.ComponentModel.DataAnnotations;


namespace aspnetcore.Models
{

    public class Product
    {

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(60, ErrorMessage = "Deve conter entre 3 e 60 caracteres", MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(60, ErrorMessage = "Deve conter no máximo 1024  caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida!")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }

}