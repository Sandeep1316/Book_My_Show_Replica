export class Movie {
  movieId: number;
  movieName: string;
  imdbRating: string;
  actorName: string;
  actressName: string;
  category: string;
  genre: string;
  releaseDate: string;
  constructor(
    movieId: number,
    movieName: string,
    imdbRating: string,
    actorName: string,
    actressName: string,
    category: string,
    genre: string,
    releaseDate: string) {
    this.movieId = movieId;
    this.movieName = movieName;
    this.imdbRating = imdbRating;
    this.actorName = actorName;
    this.actressName = actressName;
    this.category = category;
    this.genre = genre;
    this.releaseDate = releaseDate;
  }
}
