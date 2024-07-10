/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { IngredientesService } from './ingredientes.service';

describe('Service: Ingredientes', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IngredientesService]
    });
  });

  it('should ...', inject([IngredientesService], (service: IngredientesService) => {
    expect(service).toBeTruthy();
  }));
});
