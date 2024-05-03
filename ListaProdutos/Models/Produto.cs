using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ListaProdutos.Models
{

        [Table("TB_PRODUTO")] // Especifica o NOME da tabela no banco de dados Oracle
        public class Produto
        {
            [Key]
            public int ID { get; set; }

            [Required]
            public string NOME { get; set; }

            [Required]
            [Column(TypeName = "decimal(18, 2)")] // Define o tipo de dados como decimal no banco de dados Oracle
            public decimal PRECO { get; set; }
        }
    }

