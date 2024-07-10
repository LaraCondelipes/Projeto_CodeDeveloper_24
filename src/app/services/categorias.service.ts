import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Categorias } from '../models/categorias';

@Injectable({
  providedIn: 'root',
})
export class CategoriasService {
  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<Categorias[]> {
    return this.httpClient.get<Categorias[]>('/api/categorias');
  }

  get(): Observable<Categorias[]> {
    return this.httpClient.get<Categorias[]>('/api/categorias');
  }

  params = new HttpParams().set('Id', 1);

  getCategoriasById(id: number): Observable<Categorias> {
    return this.httpClient.get<Categorias>('api/Categorias/' + id);
  }
}
