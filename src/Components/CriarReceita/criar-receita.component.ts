import { Component, OnInit, Input } from '@angular/core';
import { RouterModule, Router, RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Categorias } from '../../app/models/categorias';
import { CategoriasService } from '../../app/services/categorias.service';
import { IngredientesService } from '../../app/services/ingredientes.service';
import { Ingredientes } from '../../app/models/ingredientes';
import { FormControl, FormGroup, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-criar-receita',
  standalone: true,
  imports: [CommonModule, RouterOutlet, RouterModule],
  templateUrl: './criar-receita.component.html',
  styleUrl: './criar-receita.component.css',
})
export class CriarReceitaComponent implements OnInit {
  @Input() categorias!: Categorias;

  constructor(
    private CategoriasService: CategoriasService,
    private IngredientesService: IngredientesService
  ) {}

  public categoria: Categorias[] = [];
  public ingredientes: Ingredientes[] = [];

  submitForm = new FormGroup({
    ingredienteId: new FormControl(0),
    quantidade: new FormControl(0),
    unidade: new FormControl(''),
  });

  ngOnInit() {
    this.getAllCategorias();
    //this.getCategoriaById();
    this.getAllIngredientes();
  }

  getCategoriaById() {
    //quando o componente carregar, faz a chamada ao servidor
    this.CategoriasService.getCategoriasById(1).subscribe((response) => {
      console.log(response);
    });
  }

  getAllCategorias() {
    //quando o componente carregar, faz a chamada ao servidor
    this.CategoriasService.getAll().subscribe((response) => {
      console.log(response);
      this.categoria = response;
    });
  }

  getAllIngredientes() {
    //quando o componente carregar, faz a chamada ao servidor
    this.IngredientesService.getAll().subscribe((response) => {
      console.log(response);
      this.ingredientes = response;
    });
  }

  public testMethod() {
    console.log('upsssss');
  }

  onSubmit() {
    console.log('ENTROU!!!!!!!!!!!!!!!');
    console.log(
      'ingredienteId - ' + this.submitForm.controls.ingredienteId.value
    );
    console.log('quantidade - ' + this.submitForm.controls.quantidade.value);
    console.log('unidade - ' + this.submitForm.controls.unidade.value);
  }
}
