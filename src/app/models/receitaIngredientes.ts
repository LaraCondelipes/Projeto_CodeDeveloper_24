import { Ingredientes } from './ingredientes';
import { Receitas } from './receitas';

export interface ReceitaIngredientes {
  id: number;
  receitas: Receitas;
  unidades: string;
  quantidade: number;
  ingredientes: Ingredientes;
}
