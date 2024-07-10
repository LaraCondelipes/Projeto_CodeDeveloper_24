import { Injectable } from '@angular/core';
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent,
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    // Clonar a solicitação para adicionar o cabeçalho de autenticação
    const clonedRequest = req.clone({
      headers: req.headers.set('Authorization', 'Bearer my-token'),
    });

    // Passar a solicitação clonada para o próximo manipulador
    return next.handle(clonedRequest);
  }
}
