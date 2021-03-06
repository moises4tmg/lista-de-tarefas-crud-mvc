using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TarefasApp.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "O campo login é obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        public List<Tarefa> Tarefas { get; set; }
    }
}