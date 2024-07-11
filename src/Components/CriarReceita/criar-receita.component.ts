import { Component, OnInit, Input, forwardRef } from '@angular/core';
import { RouterModule, Router, RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Categorias } from '../../app/models/categorias';
import { CategoriasService } from '../../app/services/categorias.service';
import { IngredientesService } from '../../app/services/ingredientes.service';
import { Ingredientes } from '../../app/models/ingredientes';
import {
  FormBuilder,
  FormGroup,
  Validator,
  ReactiveFormsModule,
  Validators,
  FormArray,
} from '@angular/forms';
import { NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'app-criar-receita',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterOutlet, RouterModule],
  templateUrl: './criar-receita.component.html',
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => CriarReceitaComponent),
      multi: true,
    },
  ],
  styleUrl: './criar-receita.component.css',
})

///////
export class CriarReceitaComponent implements OnInit {
  submitForm: FormGroup;
  @Input() categorias!: Categorias;
  model: any;
  /* ingredients: any; */

  constructor(
    private CategoriasService: CategoriasService,
    private IngredientesService: IngredientesService,
    private fb: FormBuilder
  ) {
    this.submitForm = this.fb.group({
      ingredients: this.fb.array([]), // Initialize the FormArray
    });
  }

  public categoria: Categorias[] = [];
  public ingredientes: Ingredientes[] = [];

  /*   submitForm = new FormGroup({
    ingredienteId: new FormControl(0),
    quantidade: new FormControl(0),
    unidade: new FormControl(''),
  }); */

  ngOnInit(): void {
    this.addIngredient(); //diciona um grupo inicial de formulários de ingredientes
    this.getAllCategorias();
    //this.getCategoriaById();
    this.getAllIngredientes();
  }

  // Getter for ingredients FormArray
  get ingredients(): FormArray {
    return this.submitForm.get('ingredients') as FormArray;
  }

  // criar um novo grupo de formulários de ingredientes
  createIngredient(): FormGroup {
    return this.fb.group({
      ingredientId: [null], //, Validators.required],
      quantidade: [null],
      unidade: [''],
    });
  }

  //adicionar um novo grupo de formulários de ingredientes ao FormArray de ingredientes
  addIngredient(): void {
    console.log('adding ingredient');
    this.ingredients.push(this.createIngredient());
    console.log(
      'dados actuais - ' + JSON.stringify(this.submitForm.value.ingredients)
    );
  }

  //remover um grupo de formulários de ingredientes do FormArray de ingredientes
  removeIngredient(index: number): void {
    if (this.ingredients.length > 1) {
      this.ingredients.removeAt(index);
    }
  }

  ////////////////////////////

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
      console.log('Ingredientes da BD - ' + JSON.stringify(response));
      this.ingredientes = response;
    });
  }

  onSubmit(): void {
    if (this.submitForm.valid) {
      const ingredientsArray = this.submitForm.value.ingredients;
      console.log(ingredientsArray);
      console.log(this.submitForm);
      // Handle the form submission, e.g., send the array to a server or further process it
    } else {
      console.log('Form is invalid');
    }
  }

  ingredienteSelecionado = '';
  onSelectChange(ingrediente: string, index: number) {
    this.ingredienteSelecionado = ingrediente;

    console.log('length - ' + (this.ingredients.length - 1));
    console.log('index - ' + index);
    length = this.ingredients.length - 1;
    //this.ingredients.at(length).ingredientId = ingrediente;
    this.submitForm.value.ingredients[index].ingredientId = ingrediente;

    console.log(
      'dados actuais - ' + JSON.stringify(this.submitForm.value.ingredients)
    );
  }
}
