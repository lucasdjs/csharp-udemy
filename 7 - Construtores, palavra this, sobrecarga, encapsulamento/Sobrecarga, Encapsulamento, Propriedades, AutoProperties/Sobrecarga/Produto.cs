using System.Globalization;
namespace Course
{
    class Produto
    {
        //atributos
        /*
        private string _nome;
        private double _preco;
        private int _quantidade;*/

        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public string _nome;    

        //construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
        }
        //propiedade
        public string Nome { 
            get {
                return _nome;
            } 
            set {
                if(value!=null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }/*


        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public int Quantidade {
            get { return _quantidade; }

        }*/

        //metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
