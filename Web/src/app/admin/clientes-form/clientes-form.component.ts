import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Clientes } from 'src/app/models/Clientes.model';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { SharedService } from 'src/app/services/shared/shared.service';


@Component({
  selector: 'app-clientes-form',
  templateUrl: './clientes-form.component.html',
  styleUrls: ['./clientes-form.component.scss']
})
export class ClientesFormComponent implements OnInit {

  VerDatos:boolean=true;
  obj:Clientes;

  constructor(private srvObj:ClientesService,private srvShared:SharedService,private route:Router) {
      this.obj=this.srvShared.ObjEdit as Clientes;
      if(this.obj!=null){
        this.VerDatos=false;
      }else{
        this.obj=new Clientes();
      }
        
   }
  
   Volver(){
    history.back();
  }

  ngOnInit(): void {
  }

}
