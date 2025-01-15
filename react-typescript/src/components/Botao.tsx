import React from "react";
import './Botao.scss';

interface BotaoProps {
	type?: "button" | "submit" | "reset" | undefined;
	children?: React.ReactNode;
	onClick?: () => void;
}

export default function Botao(props: BotaoProps) {
	// if(props.onClick) props.onClick();

	const { type = "button" } = props;
	return (
		<button type={type} className="botao" onClick={props.onClick}>{props.children}</button>
	);
}
