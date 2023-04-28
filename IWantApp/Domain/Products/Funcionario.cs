namespace IWantApp.Domain.Products;

public class Funcionario : Entity
{
    public int idade { get; set; }

    public Funcionario(int idade)
    {
        this.idade = idade;
    }
}
