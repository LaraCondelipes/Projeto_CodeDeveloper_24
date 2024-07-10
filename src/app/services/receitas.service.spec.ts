/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ReceitasService } from './receitas.service';

describe('Service: Receitas', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ReceitasService]
    });
  });

  it('should ...', inject([ReceitasService], (service: ReceitasService) => {
    expect(service).toBeTruthy();
  }));
});
