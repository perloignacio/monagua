import { Component, OnInit } from '@angular/core';
import { Compras } from 'src/app/models/Compras.model';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})
export class ComprasComponent implements OnInit {
  ArrObj:Compras[]=[];
  constructor() { }

  ngOnInit(): void {
  }

}
