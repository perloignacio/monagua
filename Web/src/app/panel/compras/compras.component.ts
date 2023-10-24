import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Actividades } from 'src/app/models/Actividades.model';
import { Compras } from 'src/app/models/Compras.model';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { SlugifyPipe } from 'src/app/models/slugfy.pipe';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { FavoritosService } from 'src/app/services/favoritos/favoritos.service';
import { MensajesService } from 'src/app/services/mensajes/mensajes.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';
import { ComentarComponent } from 'src/app/shared/comentar/comentar.component';
import { ComentariosComponent } from 'src/app/shared/comentarios/comentarios.component';
import { MensajesComponent } from 'src/app/shared/mensajes/mensajes.component';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})

export class ComprasComponent implements OnInit {
  ArrObj:ComprasDetalle[]=[];
  slug:SlugifyPipe=new SlugifyPipe();
  OriginalArr:ComprasDetalle[]=[];
  assets:string=environment.assets;
  constructor(private srvObj:ComprasService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute,public authService:AuthenticationService,private modal:NgbModal,private srvMensajes:MensajesService,private srvFav:FavoritosService)  {
    
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {
      
      this.srvObj.Mostrar().subscribe((lista)=>{
        this.ArrObj=lista;
      })
    })
  }

  favorito(obj:Actividades){
    
    let u=this.authService.currentUserValue;
    
    if(u!=null && u.ClientesEntity!=null){
      this.srvFav.Agregar(obj.IdActividad).subscribe((b)=>{
        if(b){
          Swal.fire("Ok","La actividad se guardo en favoritos","success");    
        }
      },(err)=>{
        Swal.fire("Upps",err.error.Message,"warning");    
      })
    }else{
      Swal.fire("upps","debe estar logueado para poder agregar a favoritos","warning");
    }
  }

  Comentarios(obj:ComprasDetalle){
    const modalRef = this.modal.open(ComentarComponent,{ size: 'lg' });
    modalRef.componentInstance.Actividades = obj;
    modalRef.componentInstance.showmore = false;
    if(this.authService.currentUserValue.PrestadoresEntity){
      modalRef.componentInstance.premiteResponder = true;
    }
    
    modalRef.componentInstance.IdCompraDetalle = obj.IdCompraDetalle;
  }
  async GetNoLeidos(obj:ComprasDetalle){
    return await this.srvMensajes.NoLeidos(obj.IdCompraDetalle);
  }
  Mensajes(obj:ComprasDetalle){
    const modalRef = this.modal.open(MensajesComponent,{ size: 'lg' });
    modalRef.componentInstance.IdCompraDetalle = obj.IdCompraDetalle;
    
  }
  ficha(cd:ComprasDetalle){
    this.router.navigate([`/actividad/${this.slug.transform(cd.ActividadesEntity.Nombre)}/${cd.IdActividad}`])
  }
  Borrar(cd:ComprasDetalle){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea cancelar la reserva?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.AnularActividad(cd.IdCompraDetalle).subscribe((b)=>{
          if(b){
            Swal.fire("Ok","La reserva se cancelo correctamente",'success');  
            this.cargar();
          }
        },(err)=>{

          Swal.fire("Upps",err.error.Message,'warning');
        })
      }
    });
  }
  
  ngOnInit(): void {
  }

}
