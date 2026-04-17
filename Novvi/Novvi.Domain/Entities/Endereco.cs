namespace Novvi.Domain.Entities;

//N:1-> Usuario -----
public class Endereco
{
    //id, cep, complemento
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Cep { get; private set; }
    public string Complemento { get; private set; }

    public Guid IdUsuario { get; private set; }
    
    

    public Endereco(string cep, string complemento, Guid idUsuario)
    {
        if (cep.Length != 8)
            throw new Exception("Cep inválido");
        Cep = cep;

        if (complemento.Length < 2)
            throw new Exception("Complemento incompleto");
        Complemento = complemento;
        
        
        IdUsuario = idUsuario;
    }

    public Endereco() { }
}