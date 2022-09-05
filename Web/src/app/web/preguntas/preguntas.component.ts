import { Component, OnInit } from '@angular/core';
import { Preguntas } from 'src/app/models/Preguntas.model';
import { PreguntasService } from 'src/app/services/preguntas/preguntas.service';

@Component({
  selector: 'app-preguntas',
  templateUrl: './preguntas.component.html',
  styleUrls: ['./preguntas.component.scss']
})
export class PreguntasComponent implements OnInit {
  preguntas:Preguntas[]=[];
  constructor(private srvPreguntas:PreguntasService) {
    this.srvPreguntas.todas().subscribe((lp)=>{
      this.preguntas=lp;
    })
   }

  ngOnInit(): void {
  }

}
