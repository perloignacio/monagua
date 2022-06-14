import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  isActive:boolean=false;
  constructor(private srvShared:SharedService) { 
    
    this.srvShared.getActive$().subscribe((b)=>{
      this.isActive=b;
    });
  }
  

  ngOnInit(): void {
  }

}
