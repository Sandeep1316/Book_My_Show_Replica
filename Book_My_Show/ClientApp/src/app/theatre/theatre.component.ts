import { Component, Inject } from '@angular/core';
import { Movie } from '../model-interface/MovieModel';
import { ActivatedRoute, ActivatedRouteSnapshot, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Theatre } from '../model-interface/TheatreModel';
import { Ticket } from '../model-interface/TicketModel';

@Component({
    selector: 'app-theatre',
    templateUrl: './theatre.component.html',
  styleUrls: ['./theatre.component.css']
})
/** theatre component*/
export class TheatreComponent {
  public router: Router;
  public ticket: Ticket;
  public movie: Movie;
  public theatres: Theatre[];
  public selectedTheatre: Theatre;
  public count: number = 1;
  public _id1: number;
  public _baseUrl: string;
  public _http: HttpClient;
  public _Activatedroute: ActivatedRoute;
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string, Activatedroute: ActivatedRoute) {
    this._http = http;
    this._baseUrl = baseUrl;
    this._Activatedroute = Activatedroute;
    this._id1 = +this._Activatedroute.snapshot.paramMap.get("id");
    http.get<Theatre[]>(baseUrl + "api/Theatre/theatres/id=" + this._id1 + "/city=" + sessionStorage.getItem('selectedCity')).subscribe(
      (result) => {
        this.theatres = result;
      },
      (error) => console.error(error)
    );
    http.get<Movie>(baseUrl + "api/Movie/movies/id=" + this._id1).subscribe(
      (result) => {
        this.movie = result;
      },
      (error) => console.error(error)
    );
  }
  increment() {
    this.count+=1;
  }
  decrement() {
    if (this.count > 0) {
      this.count-=1;
    }
  }
  BookTickets(theatreId: number) {
    this._http.get<Ticket>(this._baseUrl + "api/Ticket/tickets/id1=" + this._id1 + "/id2=" + theatreId).subscribe(
      (result) => {
        this.ticket = result;
      },
      (error) => console.error(error)
    );
    this._http.post(this._baseUrl + "api/UserBag/addmovie/id1=" + this._id1 + "/id2=" + theatreId + "/id3=" + this.count + "/id4=" + this.ticket.screenId, this._id1).subscribe();
    alert("Booked tickets Successfully");
    let currentUrl = this.router.url;
    this.router.navigate([currentUrl]);
  }
}
