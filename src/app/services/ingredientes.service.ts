import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Ingredientes } from '../models/ingredientes';

@Injectable({
  providedIn: 'root',
})
export class IngredientesService {
  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<Ingredientes[]> {
    return this.httpClient.get<Ingredientes[]>('/api/Ingredientes');
  }

  get(): Observable<Ingredientes[]> {
    return this.httpClient.get<Ingredientes[]>('/api/Ingredientes');
  }
  getReceitasById(id: number): Observable<Ingredientes[]> {
    return this.httpClient.get<Ingredientes[]>('/api/Ingredientes' + id);
  }
}
