import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contacto } from 'src/app/models/Contacto.model';
import { ContactoService } from 'src/app/services/contacto/contacto.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-contacto',
  templateUrl: './contacto.component.html',
  styleUrls: ['./contacto.component.scss']
})
export class ContactoComponent implements OnInit {
  obj:Contacto=new Contacto();
  constructor(private srvContacto:ContactoService,private route:Router) { }

  Enviar(){
    this.srvContacto.Enviar(this.obj).subscribe((band)=>{
      if(band){
        Swal.fire("Ok","Su consulta se envio correctamente, en la brevedad nos estaremos respondiendo",'success');
        this.obj=new Contacto();
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  ngOnInit(): void {
  }

}
