import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  cliente:boolean=true;
  constructor(private srvAut:AuthenticationService,private router:Router) { 
    
  }
  
  ngOnInit(): void {
    this.srvAut.currentUser.subscribe((u)=>{
      if(u.ClientesEntity){
        this.cliente=true;
      }else{
        this.cliente=false;
      }
    })
    
  }

  salir(){
    this.srvAut.logout();
    this.router.navigate(["/"])
  }
}
