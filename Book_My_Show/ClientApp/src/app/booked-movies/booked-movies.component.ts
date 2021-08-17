import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Movie } from '../model-interface/MovieModel';
import { Theatre } from '../model-interface/TheatreModel';
import { UserBag } from '../model-interface/UserBagModel';

@Component({
    selector: 'app-booked-movies',
    templateUrl: './booked-movies.component.html',
    styleUrls: ['./booked-movies.component.css']
})
/** booked-movies component*/
export class BookedMoviesComponent {
  public _baseUrl: string;
  public _http: HttpClient;
  public userBags: UserBag[];
  public movieName: string[];
  public theatreName: string[];
  public city: string[];
  public theatre: Theatre;
  public movie: Movie;
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this._http = http;
    this._baseUrl = baseUrl;
    http.get<UserBag[]>(baseUrl + "api/UserBag/userbags/user").subscribe(
      (result) => {
        this.userBags = result;
      },
      (error) => console.error(error)
    );
  }
  }
