import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { HomeComponentComponent } from '../Components/Home/home-component.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HomeComponentComponent],
  templateUrl: './app.component.html',

  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  data: any;
  title = 'LivrodeReceitas';

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    /* this.http.get('/api/data').subscribe({
      next: (response) => (this.data = response),
      error: (error) => console.error('Erro:', error),
      complete: () => console.log('Complete'),
    }); */
  }
}
