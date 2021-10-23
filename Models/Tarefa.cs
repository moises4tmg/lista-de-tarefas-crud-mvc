using System;
using System.ComponentModel.DataAnnotations;

namespace TarefasApp.Models
{
    public class Tarefa
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "ID do Usuário")]
        public int UsuarioId { get; set; }

        [Display(Name = "Data prazo")]
        [Required(ErrorMessage = "Informe uma data prazo para a realização da tarefa")]

        public DateTime Data { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a descrição da tarefa")]

        public string Descricao { get; set; }

        [Display(Name = "Tarefa executada")]
        public bool Status { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}