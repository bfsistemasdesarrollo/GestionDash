namespace GestionDash.Server.DTOs;

public class LoginResponse
{
    public string Token { get; set; } = null!;
    public short UsuCod { get; set; }
    public string UsuNom { get; set; } = null!;
    public string UsuNomLar { get; set; } = null!;
    public string UsuMail { get; set; } = null!;
    public short SgruCod { get; set; }
}
