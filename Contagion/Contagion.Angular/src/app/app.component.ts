import { Component } from '@angular/core';
import { Contagion } from './contagion.model';
import { ContagionService } from './contagion.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  contagion: Contagion;

  constructor(private contagionService: ContagionService) {
    this.contagion = new Contagion();
  }
}
