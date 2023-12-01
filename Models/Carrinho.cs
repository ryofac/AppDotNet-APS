using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APS.Models;

public class Carrinho {
    [Display(Name = "Cod_Car")]
    public int Id {get; set;}
    [Display(Name = "Id do usuário")]
    public int UsuarioId {get; set;}
}
