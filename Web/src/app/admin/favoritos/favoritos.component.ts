import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FavoritosAgrupService } from 'src/app/services/favoritosAgrup/favoritosAgrup.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
import { FavoritosAgrup } from 'src/app/models/FavoritosAgrup.model';

@Component({
  selector: 'app-favoritos',
  templateUrl: './favoritos.component.html',
  styleUrls: ['./favoritos.component.scss']
})
export class FavoritosComponent implements OnInit {

  ArrObj:FavoritosAgrup[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:FavoritosAgrup[]=[];
  strFiltro="";
  constructor(private srvObj:FavoritosAgrupService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {
            
      this.srvObj.todosAdmin().subscribe((lista)=>{
        this.OriginalArr=lista;
        this.collectionSize=this.OriginalArr.length;
        this.refreshData();
      })
    })
  }

  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }

  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.total.toString().includes(term) 
      || obj.IdActividad.toString().includes(term) 
      || obj.Nombre.toString().includes(term)
        
          
    });
  }
  ngOnInit(): void {
  }
  
  Ver(obj:FavoritosAgrup){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/favoritos-detalle']);
  }
  
}
