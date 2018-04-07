using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp
{
    class Produto
    {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }
        public Fornecedor fornecedor { get; private set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.fornecedor = fornecedor;
        }

        public Produto(string nome, double preco, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
            this.fornecedor = fornecedor;
        }

        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizaSaidaEstoque(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        public override string ToString()
        {
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades, Total: R$: "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + ", Fornecedor: "
                + fornecedor;
        }
    }
}
