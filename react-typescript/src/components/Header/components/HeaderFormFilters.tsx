import { FaLocationDot } from "react-icons/fa6";
import SelectorGroup from "../../Selector/SelectorGroup";
import SelectorOption from "../../Selector/SelectorOption";
import axios from "axios";
import { useEffect, useState } from "react";

type Cidade = {
  'municipio-nome': string;
  'UF-sigla': string;
}

export default function HeaderFormFilters() {
  const [cidInput, setCidInput] = useState<string>('');
  const [searchedCidades, setSearchedCidades] = useState<Cidade[]>([]);
  const [listaCidades, setListaCidades] = useState<Cidade[]>([]);

  useEffect(() => { console.log(searchedCidades)}, [searchedCidades]);

  useEffect(() => {
    axios.get('https://servicodados.ibge.gov.br/api/v1/localidades/municipios?view=nivelado')
    .then((response) => {
      setListaCidades([]);
      response.data.forEach((cidade: any) => {
        setListaCidades((prev) => [...prev, {
          'municipio-nome': cidade['municipio-nome'],
          'UF-sigla': cidade['UF-sigla']
        }]);
      });
    })
    .catch((error: any) => {
      console.error("Erro ao buscar cidades:", error);
    })
  }, []);

  async function procuraCidade(event: React.ChangeEvent<HTMLInputElement>) {
    event.preventDefault();
    let cidNome = event.target.value.normalize("NFD").replace(/[\u0300-\u036f]/g, "").toLowerCase();

    setSearchedCidades([]);
    // Verifica se o nome da cidade contém o texto digitado
    let counter = 0;
    for (const cidade of listaCidades) {
      if (cidade['municipio-nome'].normalize("NFD").replace(/[\u0300-\u036f]/g, "").toLowerCase().indexOf(cidNome) !== -1) {
        setSearchedCidades(prev => [...prev, cidade]);
        counter++;
      }

      if (counter >= 10) break;
    }
  }

  return (
  <form>
      <input
        type='text'
        placeholder='Digite sua cidade'
        className='input'
        onChange={procuraCidade}
        value={cidInput}
        onInput={e => setCidInput((e.target as HTMLInputElement).value)}
      />
    <SelectorGroup id='cidade' icon={<FaLocationDot/>}>
      {searchedCidades.map((cidade, index) => (
        <SelectorOption key={index} value={cidade['municipio-nome']} label={`${cidade['municipio-nome']} - ${cidade['UF-sigla']}`}/>
      ))}
    </SelectorGroup>
  </form>
  );
}