import {ITarefa} from "types/tarefa";
import Botao from "./Botao";
import './Cronometro.scss';
import React, {useState} from "react";


export default function Cronometro(props: {
	slctdTarefa: ITarefa | null,
	finishTarefa: () => void,
	running: boolean,
	setRunning: (running: boolean) => void
}) {
	const [time, setTime] = useState<number>(0);
	React.useEffect(() => setTime(TimeToSecs(props.slctdTarefa?.tempo ?? '00:00:00')), [props.slctdTarefa?.id, props.slctdTarefa?.tempo]);

	// const audio = new Audio('/alarm.mp3');

	async function regredTime(time: number) {
		if (props.running) return;

		props.setRunning(true);
		console.log('started');

		let counter = time;
		while(counter > 0) {
			await new Promise(resolve => setTimeout(resolve, 1000));
			counter--;
			setTime(counter);
			
		}
		console.log('finished');
		props.setRunning(false);
		props.finishTarefa();
	}

	return (
			<div className="cronometro">
				<p className="cronTitulo">Escolha um card e inicie o cronômetro</p>
				<div className="relogioWrapper">
					<Relogio time={time}/>
				</div>
				<Botao onClick={() => regredTime(time)}> Começar </Botao>
			</div>
	);
}

function Relogio(props: {time: number}) {
	const h = Math.floor(props.time / 3600);
	const m = Math.floor((props.time % 3600) / 60);
	const s = props.time % 60;

	const strH = h.toString().padStart(2, '0');
	const strM = m.toString().padStart(2, '0');
	const strS = s.toString().padStart(2, '0');

	return (
		<>
			<div className="relNumDiv"><span className="relogioNumero">{strH[0]}</span></div>
			<div className="relNumDiv"><span className="relogioNumero">{strH[1]}</span></div>
			<span className="relogioDivisao">:</span>
			<div className="relNumDiv"><span className="relogioNumero">{strM[0]}</span></div>
			<div className="relNumDiv"><span className="relogioNumero">{strM[1]}</span></div>
			<span className="relogioDivisao">:</span>
			<div className="relNumDiv"><span className="relogioNumero">{strS[0]}</span></div>
			<div className="relNumDiv"><span className="relogioNumero">{strS[1]}</span></div>
		</>
	);
}

function TimeToSecs(time: string): number {
	const [h, m, s] = time.split(':').map(Number);
	return h * 3600 + m * 60 + s;
}


