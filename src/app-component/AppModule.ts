import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';

import {
  HTTP_INTERCEPTORS,
  HttpClient,
  provideHttpClient,
  withInterceptorsFromDi,
} from '@angular/common/http';
import { AuthInterceptor } from '../app/receitas-interceptor.interceptor';
import { RouterModule } from '@angular/router';
import { ReceitasComponent } from '../Components/receitas/receitas.component';
import { CriarReceitaComponent } from '../Components/CriarReceita/criar-receita.component';
import { HomeComponentComponent } from '../Components/Home/home-component.component';
import { BrowserModule } from '@angular/platform-browser';
import { DisplayReceitaComponent } from '../Components/display-receita/display-receita.component';

@NgModule({
  declarations: [],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    NgbModule,
    RouterModule,
    AppComponent,
    ReceitasComponent,
    CriarReceitaComponent,
    HomeComponentComponent,
  ],

  providers: [
    provideHttpClient(withInterceptorsFromDi()),
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true,
    },
  ],
  bootstrap: [],
})
export class AppModule {}
