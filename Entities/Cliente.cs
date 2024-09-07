namespace ProvaPOO2;

public class Cliente : Produto
{
	private string NomeCliente {get;set;}
	private int TelefoneCliente {get;set;}
	
	public Cliente(string nomecliente, int telefonecliente, string nomeproduto, float valorproduto) : base (nomeproduto, valorproduto)
	{
		NomeCliente = nomecliente;
		TelefoneCliente = telefonecliente;
	}

	public Cliente(string nomeproduto, float valorproduto) : base(nomeproduto, valorproduto)
	{
	}
	
	
}