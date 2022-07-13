import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Actividades } from 'src/app/models/Actividades.model';
import { SlugifyPipe } from 'src/app/models/slugfy.pipe';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-actividad',
  templateUrl: './actividad.component.html',
  styleUrls: ['./actividad.component.scss']
})
export class ActividadComponent implements OnInit {
  assets:string=environment.assets;
  foto:string="";
  obj:Actividades;
  slug:SlugifyPipe=new SlugifyPipe();
  @Input()
  set Actividades(value: Actividades) {
    
    this.foto=value.Fotos.split(",")[0]
    this.obj=value;
    
  }

  ficha(){
    this.router.navigate([`/actividad/${this.slug.transform(this.obj.Nombre)}/${this.obj.IdActividad}`])
  }
  constructor(private router:Router) { }

  ngOnInit(): void {
  }

}
