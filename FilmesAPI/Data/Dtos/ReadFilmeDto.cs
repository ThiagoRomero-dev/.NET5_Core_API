using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genero nao pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 300, ErrorMessage = "A duração deve ter entre 1 e 300 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta{ get; set; }
    }
}
