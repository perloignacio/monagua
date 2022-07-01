import { Component, OnChanges, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { SharedService } from 'src/app/services/shared/shared.service';


@Component({
  selector: 'app-actividades',
  templateUrl: './actividades.component.html',
  styleUrls: ['./actividades.component.scss']
})
export class ActividadesComponent implements OnInit,OnChanges {
 
  constructor(private srvShared:SharedService,private srvActividad:ActividadesService,private route:Router) {
    
  }
  Nueva(){
    this.srvShared.ObjEdit=null;
    this.route.navigate(['panel/prestador/actividad']);
  }
  ngOnChanges() {
   
  }

  
  ngOnInit(): void {
  }

}
