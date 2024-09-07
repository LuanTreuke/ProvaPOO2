namespace ProvaPOO2;

public class Pedido : Cliente
{
	private int CodPedido {get;set;}
	
	public Pedido(string nomecliente, int telefonecliente, int codpedido) : base (nomecliente, telefonecliente)
	{
		CodPedido = codpedido;
	}
	
}

//Fazer busca na classe pedido que retorna de Produto e de Cliente 
