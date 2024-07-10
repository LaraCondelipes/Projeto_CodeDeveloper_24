import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayReceitaComponent } from './display-receita.component';

describe('DisplayReceitaComponent', () => {
  let component: DisplayReceitaComponent;
  let fixture: ComponentFixture<DisplayReceitaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DisplayReceitaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisplayReceitaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
