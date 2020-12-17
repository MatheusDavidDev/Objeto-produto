using System;
using Objeto_como_argumento.classes;

namespace Objeto_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar Menu com opcoes
            // Listar Produtos
            // Deletar um produto
            // Alterar um produto 
            Produto produto1 = new Produto(1, "Mouse Razer 3.5", 350);
            Produto produto2 = new Produto(2, "HeadSet Razer Chroma", 650);
            Produto produto3 = new Produto(3, "Mouse Pad Razer naga", 150);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);

            //carrinho.RemoverProduto(produto2); //Aqui removo um produto da lista

            Produto produtoNovo = new Produto();
            produtoNovo.Codigo = 20;
            produtoNovo.Nome = "Fone com microfone 7.1";
            produtoNovo.Preco = 600;


            carrinho.AlterarItem(2, produtoNovo);

            carrinho.MostrarProdutos();

        }
    }
}
