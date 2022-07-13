import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-top',
  templateUrl: './top.component.html',
  styleUrls: ['./top.component.scss']
})
export class TopComponent implements OnInit {

  isActive:boolean=false;
  constructor(private route:Router,private srvShared:SharedService) { 
    this.srvShared.getActive$().subscribe((b)=>{
      this.isActive=b;
     
    });
  }
  cambiaActive(){
    
    this.srvShared.setActive(!this.isActive);
  }
  Salir(){
    
  }
  ngOnInit(): void {
  }

}
