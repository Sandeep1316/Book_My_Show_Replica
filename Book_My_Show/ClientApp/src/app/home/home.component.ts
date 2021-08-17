import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { last } from 'rxjs/operators';
import { Movie } from '../model-interface/MovieModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ["./home.component.css"]
})
export class HomeComponent {
  public airingMovies: Movie[];
  public baseUrl: string;
  public http: HttpClient;
  constructor(_http: HttpClient, @Inject("BASE_URL") _baseUrl: string) {
    this.baseUrl = _baseUrl;
    this.http = _http;
  }
  ngOnInit() {
    if (sessionStorage.getItem('selectedCity')) {
      this.http.get<Movie[]>(this.baseUrl + 'api/Movie/movies/city=' + sessionStorage.getItem('selectedCity')).subscribe(
        (result) => {
          this.airingMovies = result;
        },
        (error) => console.error(error)
      );
    }
    else {
      this.http.get<Movie[]>(this.baseUrl + 'api/Movie/movies').subscribe(
        (result) => {
          this.airingMovies = result;
        },
        (error) => console.error(error)
      );
    }
  }
}

