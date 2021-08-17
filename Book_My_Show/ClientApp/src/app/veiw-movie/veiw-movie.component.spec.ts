/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { VeiwMovieComponent } from './veiw-movie.component';

let component: VeiwMovieComponent;
let fixture: ComponentFixture<VeiwMovieComponent>;

describe('veiw-movie component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ VeiwMovieComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(VeiwMovieComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});