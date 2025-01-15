import React, {useState} from 'react';
import Formulario from 'components/Formulario';
import Lista from 'components/Lista';
import './App.scss';
import Cronometro from 'components/Cronometro';
import { ITarefa } from 'types/tarefa';


export default function App() {
  const [tarefas, setTarefas] = useState<ITarefa[]>([]);
  const [slctdTarefa, setSlctdTarefa] = useState<ITarefa | null>(null);
  const [running, setRunning] = useState<boolean>(false);
  
  function selectTarefa(slctdId: string) {
    setTarefas(prev => prev.map(item => ({
      ...item,
      selecionado: item.id === slctdId,
    })));

    const selecionada = tarefas.find(item => item.id === slctdId) ?? null;

    console.log(selecionada);
    setSlctdTarefa(selecionada);
  }

  function finishTarefa() {
    if (slctdTarefa) {
      setTarefas(prev => prev.map(item => ({
        ...item,
        selecionado: false,
        completado: item.id === slctdTarefa.id ? true : item.completado,
      })));
    }

    setSlctdTarefa(null);
  }

  return (
    <div className='AppStyle'>
      <Formulario setTarefas={setTarefas}/>
      <Lista tarefas={tarefas} slctTarefa={selectTarefa} running={running}/>
      <Cronometro
        slctdTarefa={slctdTarefa}
        finishTarefa={finishTarefa}
        running={running} setRunning={setRunning}
      />
    </div>
  );
}
