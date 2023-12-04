import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { PrestadoresService } from 'src/app/services/prestadores/prestadores.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-prestadores-form',
  templateUrl: './prestadores-form.component.html',
  styleUrls: ['./prestadores-form.component.scss']
})
export class PrestadoresFormComponent implements OnInit {

  VerDatos:boolean=true;
  obj:Prestadores;
  assets:string=environment.assets;
  constructor(private srvObj:PrestadoresService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Prestadores;
      if(this.obj!=null){
        this.VerDatos=false;
      }else{
        this.obj=new Prestadores();
      }
      
   }
  
  Volver(){
    history.back();
  }

  ngOnInit(): void {
  }

}
