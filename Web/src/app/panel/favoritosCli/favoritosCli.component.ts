import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Actividades } from 'src/app/models/Actividades.model';
import { Favoritos } from 'src/app/models/Favoritos.model';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { FavoritosService } from 'src/app/services/favoritos/favoritos.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-favoritosCli',
  templateUrl: './favoritosCli.component.html',
  styleUrls: ['./favoritosCli.component.scss']
})
export class FavoritosCliComponent implements OnInit {

  Favoritos:Favoritos[]=[];
  Actividades:Actividades[]=[];
   
  constructor(private srvShared:SharedService,private srvClientes:ClientesService, private srvWeb:WebService,private route:Router) {
    this.srvClientes.Favoritos().subscribe((fav)=>{
      this.Favoritos=fav;
    })
  }

  
  
  ngOnInit(): void {
  }

}
