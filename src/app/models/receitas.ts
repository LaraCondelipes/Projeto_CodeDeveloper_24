import { Categorias } from './categorias';
import { ReceitaIngredientes } from './receitaIngredientes';

export interface Receitas {
  id: number;
  titulo: string;
  duracao: number;
  dificuldade: 'facil' | 'medio' | 'dificil';
  categoria: Categorias;
  descricao: string;
  receitaIngredientes: ReceitaIngredientes[];
}
