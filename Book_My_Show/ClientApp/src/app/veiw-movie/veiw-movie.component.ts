import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Movie } from '../model-interface/MovieModel';
import { ActivatedRoute, ActivatedRouteSnapshot } from '@angular/router';

@Component({
    selector: 'app-veiw-movie',
    templateUrl: './veiw-movie.component.html',
    styleUrls: ['./veiw-movie.component.css']
})
/** veiw-movie component*/
export class VeiwMovieComponent {
  public movie: Movie;
  public _id: number;
  public _baseUrl: string;
  public _http: HttpClient;
  public _Activatedroute: ActivatedRoute;
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string, Activatedroute: ActivatedRoute)
  {
    this._http = http;
    this._baseUrl = baseUrl;
    this._Activatedroute = Activatedroute;
    this._id = +this._Activatedroute.snapshot.paramMap.get("id");
    http.get<Movie>(baseUrl + "api/Movie/movies/id=" + this._id).subscribe(
      (result) => {
        this.movie = result;
      },
      (error) => console.error(error)
    );
  }
}
