export class UserBag {
  userBagId: number;
  userId: string;
  movieName: string;
  theatreName: string;
  city: string;
  screenId: number;
  tickets: number;
  constructor(userBagId: number,
    userId: string,
    movieName: string,
    theatreName: string,
    city: string,
    screenId: number,
    tickets: number) {
    this.userBagId = userBagId;
    this.userId = userId;
    this.movieName = movieName;
    this.theatreName = theatreName;
    this.city = city;
    this.screenId = screenId;
    this.tickets = tickets;
  }
}
