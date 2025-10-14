using System.ComponentModel.DataAnnotations;
namespace GCook.ViewModels;

public class LoginVM
{
    [Display(Name = "E-mail ou Nome do Usuário", Prompt = "Informe seu email ou nome de usuário")]
    [Required(ErrorMessage = " O e-mail ou nome do Usuário é obrigatório")]
    public string Email { get; set; }

    [Display(Name = "Senha de acesso", Prompt = "******")]
    [Required(ErrorMessage = "A senha é obrigatória")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;


    public string UrlRetorno { get; set; }
}
