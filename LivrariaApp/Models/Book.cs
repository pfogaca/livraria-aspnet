using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LivrariaApp.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(0, long.MaxValue,
            ErrorMessage = "{0} deve ser maior que zero.")]
        public long ISBN { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Display(Name = "Título")]
        [StringLength(100, 
            ErrorMessage = "{0} não pode ter mais de 100 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Display(Name = "Autor")]
        [StringLength(100,
            ErrorMessage = "{0} não pode ter mais de 100 caracteres.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Display(Name = "Gênero")]
        [StringLength(50, 
            ErrorMessage = "{0} não pode ter mais de 100 caracteres.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(0, 1000,
            ErrorMessage = "{0} deve ser entre {1} e {2}")]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(0, 100,
            ErrorMessage = "{0} deve ser entre {1} e {2}")]
        [Display(Name = "Estoque")]
        public int Stock { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
    }
}