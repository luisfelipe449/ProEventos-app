import { Evento } from './evento';
import { RedeSocial } from './redeSocial';

export interface Palestrante {
  id?: number;
  nome: string;
  descricao: string;
  imagemUrl: string;
  telefone: string;
  email: string;
  redesSociais: RedeSocial[];
  palestrantesEventos: Evento[];
}
