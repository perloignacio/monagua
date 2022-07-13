import { Component, OnInit } from '@angular/core';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})
export class ComprasComponent implements OnInit {
  assets:string=environment.assets;
  constructor(public srvCompra:ComprasService) { }

  ngOnInit(): void {
  }

}
