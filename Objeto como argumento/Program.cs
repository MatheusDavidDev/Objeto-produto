using System;
using System.Collections.Generic;
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

            List<Produto> produtos = new List<Produto>();


            Carrinho carrinho = new Carrinho();
            int resposta;
            do
            {
            Console.WriteLine("MENU"); 
            Console.WriteLine("[1] - Listar produtos cadastrados"); 
            Console.WriteLine("[2] - Deletar um produto"); 
            Console.WriteLine("[3] - Alterar um produto"); 
             resposta = int.Parse(Console.ReadLine()); 

                switch (resposta)
                {
                    case 1:

                        carrinho.AdicionarProduto(produto1);
                        carrinho.AdicionarProduto(produto2);
                        carrinho.AdicionarProduto(produto3);
                        foreach (var item in produtos)
                        {
                        Console.WriteLine($"Item codigo {item.Codigo} Nome {item.Nome} preco {item.Preco}");  
                        }
                        carrinho.MostrarProdutos();
                        break;

                    case 2:

                        Produto produtoNovo = new Produto();
                        carrinho.AlterarItem(2, produtoNovo);
                        Console.WriteLine("Digite o codigo do produto");
                        produtoNovo.Codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nome do produto");
                        produtoNovo.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o preco do produto");
                        produtoNovo.Preco = float.Parse(Console.ReadLine());

                        break;

                    case 3:
                        break;

                    default: 
                        break;
            }
                
            } while (resposta != 0);
            



            //carrinho.RemoverProduto(produto2); //Aqui removo um produto da lista





        }
    }
}
