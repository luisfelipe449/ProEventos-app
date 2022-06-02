import { Evento } from './evento';

export interface Lotes {
  id?: number;
  nome: string;
  preco: number;
  dataInicio: Date;
  dataFim: Date;
  quantidade: number;
  eventoId: number;
  evento: Evento[];
}
