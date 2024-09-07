namespace ProvaPOO2;

public class Produto
{
	Produto produto1= new Produto("Feijão", 10);
	Produto produto2= new Produto("Arroz", 12);
	Produto produto3= new Produto("Carne", 20);
	
	List<String> listaProdutos = new List<String>();
	private string NomeProduto {get;set;}
	private float ValorProduto {get;set;}
	
	public Produto(string nomeproduto, float valorproduto)
	{
		NomeProduto = nomeproduto;
		ValorProduto = valorproduto;
	}
	
	public virtual void VerProduto()
	{
		Console.WriteLine($"Nome do Produto 1: {NomeProduto} Valor do Produto 1: {ValorProduto}" );
	}
	
	
	
}