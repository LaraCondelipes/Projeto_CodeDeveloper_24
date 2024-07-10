import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponentComponent } from '../Components/Home/home-component.component';
import { CriarReceitaComponent } from '../Components/CriarReceita/criar-receita.component';
import { ReceitasComponent } from '../Components/receitas/receitas.component';

@NgModule({
  declarations: [],
  imports: [NgbModule, RouterModule],
})
export class AppModule {}

export const routes: Routes = [
  { path: 'criar-receita', component: CriarReceitaComponent },
  { path: 'receitas', component: ReceitasComponent },
  { path: 'home', component: HomeComponentComponent },
  { path: '**', component: HomeComponentComponent },
];
