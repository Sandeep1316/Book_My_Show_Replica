export class Ticket {
  id: number;
  movieId: number;
  theatreId: number;
  screenId: number;
  constructor(id: number,
    movieId: number,
    theatreId: number,
    screenId: number) {
    this.id = id;
    this.movieId = movieId;
    this.theatreId = theatreId;
    this.screenId = screenId;
  }
}
