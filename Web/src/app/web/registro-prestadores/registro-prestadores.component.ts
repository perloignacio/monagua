import { Component, OnInit } from '@angular/core';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-registro-prestadores',
  templateUrl: './registro-prestadores.component.html',
  styleUrls: ['./registro-prestadores.component.scss']
})
export class RegistroPrestadoresComponent implements OnInit {
  obj:Prestadores=new Prestadores();
  constructor(private srvShared:SharedService) { }

  ngOnInit(): void {
  }

}
