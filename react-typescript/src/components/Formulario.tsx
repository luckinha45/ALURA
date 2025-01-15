import React, {useState} from "react";
import Botao from "./Botao";
import './Formulario.scss';
import { ITarefa } from 'types/tarefa';
import { v4 as uuidv4 } from 'uuid';


export default function Formulario(props: {setTarefas: React.Dispatch<React.SetStateAction<ITarefa[]>>}) {
	let [tarefa, setTarefa]  = useState("");
	let [tempo, setTempo]  = useState("00:00:00");

	function addTarefa(e: React.FormEvent) {
		e.preventDefault();
		
		props.setTarefas((prev) => [...prev, { 
			nome: tarefa,
			tempo,
			selecionado: false,
			completado: false,
			id: uuidv4(),
		}]);

		setTarefa("");
		setTempo("00:00:00");
	}

	return (
	<form className="novaTarefa" onSubmit={addTarefa}>
		<div className="inputContainer">
			<label htmlFor="tarefa"> Nome do estudo: </label>
			<input 
				required 
				value={tarefa}
				onChange={(e) => setTarefa(e.target.value)}
				name="tarefa" 
				id="tarefa" 
				placeholder="O que você quer estudar" 
				type="text" 
			/>
		</div>

		<div className="inputContainer">
			<label>Tempo:</label>
			<input
				required 
				style={{ width: "200px" }} 
				value={tempo}
				onChange={(e) => setTempo(e.target.value)}
				type="time" 
				step="1" 
				name="tempo"
				id="tempo" 
				min="00:00:00" 
				max="01:30:00"
			/>
		</div>
		<Botao type="submit">Adicionar</Botao>
	</form>
	);
}
