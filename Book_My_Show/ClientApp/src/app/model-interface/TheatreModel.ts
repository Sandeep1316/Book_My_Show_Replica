export class Theatre {
  theatreId: number;
  theatreName: string;
  city: string;
  numberOfHalls: number;
  constructor(theatreId: number,
    theatreName: string,
    city: string,
    numberOfHalls: number) {
    this.theatreId = theatreId;
    this.theatreName = theatreName;
    this.city = city;
    this.numberOfHalls = numberOfHalls;
  }
}
