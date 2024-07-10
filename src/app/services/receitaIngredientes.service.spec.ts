/* tslint:disable:no-unused-variable */

import { TestBed, inject } from '@angular/core/testing';
import { ReceitaIngredientesService } from './receitaIngredientes.service';

describe('Service: ReceitaIngredientes', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ReceitaIngredientesService],
    });
  });

  it('should ...', inject(
    [ReceitaIngredientesService],
    (service: ReceitaIngredientesService) => {
      expect(service).toBeTruthy();
    }
  ));
});
