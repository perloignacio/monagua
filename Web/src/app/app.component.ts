import { Component } from '@angular/core';
import { Paises } from './models/Paises.model';
import { WebService } from './services/web/web.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Web';
  lisapaises:Paises[]=[];
  constructor(private servicioPais:WebService) {
    this.servicioPais.Paises().subscribe((array)=>{
      console.log(array);
      this.lisapaises=array;
    })
  }
}
