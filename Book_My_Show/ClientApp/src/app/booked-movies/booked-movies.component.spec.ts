/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { BookedMoviesComponent } from './booked-movies.component';

let component: BookedMoviesComponent;
let fixture: ComponentFixture<BookedMoviesComponent>;

describe('booked-movies component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ BookedMoviesComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(BookedMoviesComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});