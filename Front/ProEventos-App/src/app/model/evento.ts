import { Lotes } from './lote';
import { Palestrante } from './palestrante';
import { RedeSocial } from './redeSocial';

export interface Evento {
  id?: number;
  local: string;
  dataEvento?: Date;
  tema: string;
  qtdPessoas: number;
  imagemURL: string;
  telefone: string;
  email: string;
  lote: Lotes[];
  redesSociais: RedeSocial[];
  PalestrantesEventos: Palestrante[];
}
