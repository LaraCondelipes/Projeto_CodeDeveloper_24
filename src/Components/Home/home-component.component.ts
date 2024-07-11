import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { CriarReceitaComponent } from '../CriarReceita/criar-receita.component';
import { CommonModule } from '@angular/common';
import { Receitas } from '../../app/models/receitas';
import { ReceitasComponent } from '../receitas/receitas.component';
import { ReceitasService } from '../../app/services/receitas.service';
import { DisplayReceitaComponent } from '../display-receita/display-receita.component';

@Component({
  selector: 'app-home-component',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    RouterModule,
    ReceitasComponent,
    CriarReceitaComponent,
  ],
  templateUrl: './home-component.component.html',

  styleUrl: './home-component.component.css',
})
export class HomeComponentComponent {
  //criação da instância
  receitas: Receitas[] = [];
}
