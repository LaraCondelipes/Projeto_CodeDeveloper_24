import { Ingredientes } from './ingredientes';
import { Receitas } from './receitas';

export interface ReceitaIngredientes {
  id: number | null;
  receitas: Receitas;
  unidades: string;
  quantidade: number | null;
  ingredientes: Ingredientes;
}
