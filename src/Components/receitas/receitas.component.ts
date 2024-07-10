import { OnInit } from '@angular/core';
import { Component, Input } from '@angular/core';
import { Receitas } from '../../app/models/receitas';
import { ReceitasService } from '../../app/services/receitas.service';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-receitas',
  standalone: true,
  imports: [CommonModule, RouterOutlet, RouterModule],
  templateUrl: './receitas.component.html',
  styleUrl: './receitas.component.css',
})
export class ReceitasComponent implements OnInit {
  //adicionar propriedade Input
  @Input() Receitas!: Receitas;

  constructor(private ReceitasService: ReceitasService) {}

  public receitas: Receitas[] = [];

  ngOnInit() {
    //quando o componente carregar, fazer o metodo getAllReceitas
    this.getAllreceitas();
  }

  getAllreceitas() {
    //quando o componente carregar, faz a chamada ao servidor
    this.ReceitasService.getAll().subscribe((response) => {
      this.receitas = response;
    });
  }
}
