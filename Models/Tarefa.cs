using System;
using System.ComponentModel.DataAnnotations;

namespace lista_de_tarefas.Models
{
    public class Tarefa
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "ID do Usuário")]
        public int UsuarioId { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Descrição da Tarefa")]
        public string Descricao { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}