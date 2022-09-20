import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Compras } from 'src/app/models/Compras.model';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})

export class ComprasComponent implements OnInit {
  ArrObj:Compras[]=[];
  OriginalArr:Compras[]=[];
  
  constructor(private srvObj:ComprasService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute)  {
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {
      
      this.srvObj.Mostrar().subscribe((lista)=>{
        this.ArrObj=lista;
      })
    })
  }

    ngOnInit(): void {
  }

}
