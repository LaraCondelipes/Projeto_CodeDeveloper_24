import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import {
  HTTP_INTERCEPTORS,
  HttpClient,
  provideHttpClient,
  withInterceptorsFromDi,
} from '@angular/common/http';
import { AuthInterceptor } from '../app/interceptor.interceptor';
import { RouterModule } from '@angular/router';
import { ReceitasComponent } from '../Components/receitas/receitas.component';
import { CriarReceitaComponent } from '../Components/CriarReceita/criar-receita.component';
import { HomeComponentComponent } from '../Components/Home/home-component.component';

@NgModule({
  declarations: [],
  imports: [
    NgbModule,
    RouterModule,
    AppComponent,
    ReceitasComponent,
    CriarReceitaComponent,
    HomeComponentComponent,
    ReactiveFormsModule,
    FormsModule,
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
