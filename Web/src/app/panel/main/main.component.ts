import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  constructor(public srvAut:AuthenticationService,private router:Router) { }

  ngOnInit(): void {
  }

  salir(){
    this.srvAut.logout();
    this.router.navigate(["/"])
  }
}
