import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Actividades } from 'src/app/models/Actividades.model';
import { Favoritos } from 'src/app/models/Favoritos.model';
import { SlugifyPipe } from 'src/app/models/slugfy.pipe';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { FavoritosService } from 'src/app/services/favoritos/favoritos.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-actividad-shared',
  templateUrl: './actividad.component.html',
  styleUrls: ['./actividad.component.scss']
})
export class ActividadSharedComponent implements OnInit {
  assets:string=environment.assets;
  foto:string="";
  obj:Actividades;
  fav:boolean;
  slug:SlugifyPipe=new SlugifyPipe();
  favoritosService: any;
  @Input()
  set Actividades(value: Actividades) {
    this.foto=value.Fotos.split(",")[0]
    this.obj=value;
  }

  @Input()
  set Favoritos(value: boolean) {
    this.fav=value;
  }

  ficha(){
    this.router.navigate([`/actividad/${this.slug.transform(this.obj.Nombre)}/${this.obj.IdActividad}`])
  }
  constructor(private router:Router, private srvClientes:ClientesService) { }
  
  QuitarFav(){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea eliminar de Favoritos?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvClientes.QuitarFavoritos(this.obj.IdActividad).subscribe((band)=>{
          if(band){
            
            Swal.fire("Ok","Se quitó el registro",'success');

          }
        },(err)=>{
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }
  
  ngOnInit(): void {
  }

}

