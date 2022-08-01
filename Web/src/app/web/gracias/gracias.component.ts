import { Component, OnInit } from '@angular/core';
import { ComprasService } from 'src/app/services/compras/compras.service';

@Component({
  selector: 'app-gracias',
  templateUrl: './gracias.component.html',
  styleUrls: ['./gracias.component.scss']
})
export class GraciasComponent implements OnInit {

  constructor(public srvCompras:ComprasService) { 
    this.srvCompras.Limpia();
  }

  ngOnInit(): void {
  }

}
