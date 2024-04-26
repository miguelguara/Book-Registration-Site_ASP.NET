using System.ComponentModel.DataAnnotations;

namespace Web_Projeto_integrado.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public string LivroEmprestado { get; set; }

        public DateTime Dataultimaatualizacao { get; set; } = DateTime.Now;

    }
}
