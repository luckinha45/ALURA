import React from "react";
import Produto from "./Produto";
import produtos from "@/mocks/produtos.json";
import Titulo from "@/components/Titulo";
import { CarrinhoCtx } from "@/context/CarrinhoCtx";

function Produtos() {
  const { _, setCarrinho } = React.useContext(CarrinhoCtx);

  function adicionarProduto(novoProd) {
    let found = false;

    // se o produto já estiver no carrinho, aumenta a quantidade
    setCarrinho(prevCarrinho => prevCarrinho.map((item) => {
      if (item.id === novoProd.id) {
        found = true;
        item.quantidade += 1;
      }
    }))

    // senão, adiciona o produto ao carrinho com qtde 1
    if (!found) {
      novoProd.quantidade = 1;
      setCarrinho(prevCarrinho => [...prevCarrinho, novoProd])
    }
  }

  return (
    <section role="produtos" aria-label="Produtos que estão bombando!">
      <Titulo>Produtos que estão bombando!</Titulo>
      <div className="container row mx-auto">
        {produtos.map((produto) => (
          <Produto
            key={produto.id}
            {...produto}
            adicionarProduto={adicionarProduto}
          />
        ))}
      </div>
    </section>
  );
};

export default Produtos;
