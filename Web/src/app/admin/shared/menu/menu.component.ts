import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {

  constructor(private srvAut:AuthenticationService,private route:Router) { }

  ngOnInit(): void {
  }
  Salir(){
    this.srvAut.logout();
    this.route.navigate(["/"])
  }

}
