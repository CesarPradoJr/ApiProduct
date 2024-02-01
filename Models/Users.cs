using ApiProduct.Validation;

namespace ApiProduct.Models;

public class Users
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public byte[] PasswordHash { get; private set; }
    public byte[] PasswordSalt { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime DeletedAt { get; private set; }

    public Users(int id, string name, string email)
    {
        DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo.");
        Id = id;
        ValidateDomain(name, email);
    }

    public void AlterarSenha(byte[] passwordHash, byte[] passwordSalt)
    {
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }

    public void ValidateDomain(string name, string email)
    {
        DomainExceptionValidation.When(name == null, "O nome é obrigatório.");
        DomainExceptionValidation.When(email == null, "O E-mail é obrigatório.");
        DomainExceptionValidation.When(name.Length > 250, "O nome não pode conter mais que 250 caracterers.");
        DomainExceptionValidation.When(email.Length > 200, "O E-mail não pode conter mais que 200 caracterers.");
    }
}
