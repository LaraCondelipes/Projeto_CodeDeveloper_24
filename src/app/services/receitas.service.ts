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
  //criação da função onSubmit no serviço
  onSubmit(ingredientArray: []) {
    //mostrar no console a estrutura do objeto para saber como navegar dentro dele
    console.log(JSON.stringify(ingredientArray));
  }
}
