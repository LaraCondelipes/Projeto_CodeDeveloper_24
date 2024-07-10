import { Injectable } from '@angular/core';
import { ReceitaIngredientes } from '../models/receitaIngredientes';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ReceitaIngredientesService {
  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<ReceitaIngredientes[]> {
    return this.httpClient.get<ReceitaIngredientes[]>(
      '/api/ReceitaIngredientes'
    );
  }
}
