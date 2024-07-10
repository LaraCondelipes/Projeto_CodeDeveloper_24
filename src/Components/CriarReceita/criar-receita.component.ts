import { Component, OnInit, Input } from '@angular/core';
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

@Component({
  selector: 'app-criar-receita',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterOutlet, RouterModule],
  templateUrl: './criar-receita.component.html',
  styleUrl: './criar-receita.component.css',
})
export class CriarReceitaComponent implements OnInit {
  submitForm: FormGroup;
  /*   @Input() categorias!: Categorias;
  model: any;
  ingredients: any; */

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
      ingredientId: [null, Validators.required],
      quantidade: [null, Validators.required],
      unidade: ['', Validators.required],
    });
  }
  //adicionar um novo grupo de formulários de ingredientes ao FormArray de ingredientes
  addIngredient(): void {
    this.ingredients.push(this.createIngredient());
  }

  //remover um grupo de formulários de ingredientes do FormArray de ingredientes
  removeIngredient(index: number): void {
    if (this.ingredients.length > 1) {
      this.ingredients.removeAt(index);
    }
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

  onSubmit(): void {
    if (this.submitForm.valid) {
      const ingredientsArray = this.submitForm.value.ingredients;
      console.log(ingredientsArray);
      // Handle the form submission, e.g., send the array to a server or further process it
    } else {
      console.log('Form is invalid');
    }
  }

  getFormValuesAsArray(): any[] {
    const formValues = this.submitForm.value;
    return Object.values(formValues); // Transform the form values into an array
  }
}
