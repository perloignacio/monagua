import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ComprasService } from 'src/app/services/compras/compras.service';

@Component({
  selector: 'app-gracias',
  templateUrl: './gracias.component.html',
  styleUrls: ['./gracias.component.scss']
})
export class GraciasComponent implements OnInit {
  gracias:boolean=true;
  constructor(public srvCompras:ComprasService,private router:Router) { 
    if(this.router.url=='error'){
      this.gracias=false;
      
    }else{
      this.srvCompras.Limpia();
    }
    
  }

  ngOnInit(): void {
  }

}
