using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiDotNetCore.Models
{
  public class Product
  {
    [Key]
    public int Id { get; set; }

    [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
    public string Title { get; set; }

    [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [Required(ErrorMessage = "Este campo é obrigatório")]
    [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Este campo é obrigatório")]
    [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
  }
}