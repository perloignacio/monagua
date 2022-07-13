import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CalendarEvent, CalendarEventAction, CalendarView } from 'angular-calendar';
import { isSameDay, isSameMonth } from 'date-fns';
import * as moment from 'moment';
import { Subject } from 'rxjs';
import { Actividades } from 'src/app/models/Actividades.model';
import { ActividadesHorarios } from 'src/app/models/ActividadesHorarios.model';

import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
import { HorarioComponent } from '../horario/horario.component';
const colors: any = {
  red: {
    primary: '#ad2121',
    secondary: '#FAE3E3',
  },
  blue: {
    primary: '#1e90ff',
    secondary: '#D1E8FF',
  },
  yellow: {
    primary: '#e3bc08',
    secondary: '#FDF1BA',
  },
};
@Component({
  selector: 'app-horarios-actividades',
  templateUrl: './horarios-actividades.component.html',
  styleUrls: ['./horarios-actividades.component.scss']
})
export class HorariosActividadesComponent implements OnInit {

  view: CalendarView = CalendarView.Month;
  CalendarView = CalendarView;
  viewDate: Date = new Date();
  nEvento:ActividadesHorarios=new ActividadesHorarios();
  Eventos:ActividadesHorarios[]=[];
  IdActividad:number;
  ngOnInit(): void {

  }
  actions: CalendarEventAction[] = [
    {
      label: '<i class="fas fa-fw fa-pencil-alt"></i>',
      a11yLabel: 'Modificar',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        this.handleEvent('Edited', event);
      },
    },
    {
      label: '<i class="fas fa-fw fa-trash-alt"></i>',
      a11yLabel: 'Borrar',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        
        this.deleteEvent(event);
      },
    },
  ];

  refresh = new Subject<void>();
  events: CalendarEvent[] = []
  activeDayIsOpen: boolean = true;

  constructor(private modal: NgbModal,private srvHorarios:ActividadesService,private srvShared:SharedService,private route:ActivatedRoute) {
    this.route.params.subscribe(val => {
      this.IdActividad=val["id"];
      this.cargadatos()  
    })
    
  }

  cargadatos(){
   
    this.events=[];
    this.srvHorarios.HorariosByActividad(this.IdActividad).subscribe((el)=>{
      this.Eventos=el;
      
      el.forEach((ev)=>{
        let desde: moment.Moment = moment(ev.FechaInicio);
        let hasta: moment.Moment = moment(ev.FechaFin);
        
        let e:CalendarEvent={
          id:ev.id+"-"+ev.idCalendar,
          start: new Date(desde.format("LLLL")),
          end: new Date(hasta.format("LLLL")),
          title: `${ev.ActividadesEntity.Nombre} - ${desde.format("DD-MM-YYYY HH:mm")} - ${hasta.format("DD-MM-YYYY HH:mm")}`,
          color: colors.red,
          actions: this.actions,
        }
       
        this.events.push(e);
      })
      
      this.refresh.next();
    })
  }
  dayClicked({ date, events }: { date: Date; events: CalendarEvent[] }): void {
    
    if (isSameMonth(date, this.viewDate)) {
      if (
        (isSameDay(this.viewDate, date) && this.activeDayIsOpen === true) ||
        events.length === 0
      ) {
        this.activeDayIsOpen = false;
      } else {
        this.activeDayIsOpen = true;
      }
      this.viewDate = date;
    }
  }

  

  nuevo(){
    this.srvShared.objModal;
    this.srvShared.IdActividad=this.IdActividad;
    this.srvShared.AccionModal="Agregar";
    this.abremodal();
  }
  handleEvent(action: string, event: CalendarEvent): void {
    
    let id=event.id.toString().split("-")[1];
    this.srvShared.objModal=this.Eventos.find((e)=>e.idCalendar.toString()==id);
    
    this.srvShared.AccionModal="Editar";
    this.abremodal();
  }
  abremodal(){
    this.modal.open(HorarioComponent, { size: 'lg' }).result.then((result) => {
      this.route.params.subscribe(val => {
        this.cargadatos();  
      })
       /* To subscribe data from Modal */

      }, (reason)=>{ 
      
        /*Leave empty or handle reject*/

      });
   
     
  }
 

  deleteEvent(eventToDelete: CalendarEvent) {
    
    this.srvShared.objModal=this.Eventos.find((e)=>e.id+"-"+e.idCalendar==eventToDelete.id);
    this.srvShared.AccionModal="Borrar";
    this.abremodal();
    
  }

  setView(view: CalendarView) {
    this.view = view;
  }

  closeOpenMonthViewDay() {
    this.activeDayIsOpen = false;
  }

}
