import './Lista.scss';
import { ITarefa } from 'types/tarefa';

export default function Lista(props: {tarefas: ITarefa[], slctTarefa: (id: string) => void, running: boolean}) {
	
	return (
	<aside className="listaTarefas">
		<h2 className="listaTitulo">
			Lista de Tarefas
		</h2>

		<ul style={{ paddingLeft: "0" }}>
			{props.tarefas.map((item) => { 
				return <ItemLista
					key={item.id}
					tarefa={item}
					slctTarefa={props.slctTarefa}
					running={props.running}
				/>; 
			})}
		</ul>
	</aside>
	)
}

function ItemLista(props: {tarefa:ITarefa, slctTarefa: (id: string) => void, running: boolean}) {
	return (
		<li
			className={`item ${props.tarefa.selecionado ? 'itemSelecionado' : ''} ${props.tarefa.completado ? 'itemCompletado' : ''}`}
			onClick={props.tarefa.completado || props.running ? undefined : () => props.slctTarefa(props.tarefa.id)}
		>
			<h3>   {props.tarefa.nome} </h3>
			<span> {props.tarefa.tempo} </span>
			{ props.tarefa.completado && <span>✅</span> }
		</li>
	)
}