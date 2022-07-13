import { Component, OnInit } from '@angular/core';
import { Actividades } from 'src/app/models/Actividades.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  Actividades:Actividades[]=[];
  constructor(private srvActividades:ActividadesService) {
    this.srvActividades.todos().subscribe((la)=>{
      this.Actividades=la;
    })
  }

  ngOnInit(): void {
  }

}
