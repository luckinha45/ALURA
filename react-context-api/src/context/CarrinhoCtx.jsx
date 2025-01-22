import React from "react";
import Home from "../pages/Home";

export const CarrinhoCtx = React.createContext();

export function CarrinhoProvider({children}) {
	const [carrinho, setCarrinho] = React.useState([]);


	return (
		<CarrinhoCtx.Provider value={{carrinho, setCarrinho}}>
			{children}
		</CarrinhoCtx.Provider>
	)
}
