import { Categorias } from './categorias';
import { ReceitaIngredientes } from './receitaIngredientes';

export interface Receitas {
  id: number | null;
  titulo: string;
  duracao: number;
  dificuldade: string;
  categoria: Categorias;
  descricao: string;
  receitaIngredientes: ReceitaIngredientes[];
}
