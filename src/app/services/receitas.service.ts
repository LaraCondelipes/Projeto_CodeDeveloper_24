import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Receitas } from '../models/receitas';

@Injectable({
  providedIn: 'root',
})
export class ReceitasService {
  constructor(private httpClient: HttpClient) {}

  getAll(): Observable<Receitas[]> {
    return this.httpClient.get<Receitas[]>('/api/Receitas');
  }

  get(): Observable<Receitas[]> {
    return this.httpClient.get<Receitas[]>('/api/Receitas');
  }

  getReceitasById(id: number): Observable<Receitas[]> {
    return this.httpClient.get<Receitas[]>('/api/Receitas' + id);
  }
}
