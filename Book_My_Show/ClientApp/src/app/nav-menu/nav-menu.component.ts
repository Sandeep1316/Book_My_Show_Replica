import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { Movie } from '../model-interface/MovieModel';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  moviesInCity: Movie[];
  cities: Array<string> = ["Hyderabad", "Kakinada", "Bengaluru", "Kadapa", "Chennai", "Tirupathi", "Kolkata"];
  selectedCity: string;
  http: HttpClient;
  baseUrl: string;
  router: Router;
  currentUrl: string;
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,_router: Router) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.router = _router;
  }
  ngOnInit() {
    this.selectedCity = sessionStorage.getItem('selectedCity');
  }
  Selected() {
    sessionStorage.setItem('selectedCity', this.selectedCity);
    this.http.get<Movie[]>(this.baseUrl + 'api/Movie/movies/city=' + sessionStorage.getItem('selectedCity')).subscribe(
      (result) => {
        this.moviesInCity = result;
      },
      (error) => console.error(error)
    );
    this.currentUrl = this.router.url;
    this.router.onSameUrlNavigation = 'reload';
    this.router.navigate([this.currentUrl]);
  }
}
