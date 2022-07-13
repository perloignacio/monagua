import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Route, Router, RouterStateSnapshot } from '@angular/router';
import { AuthenticationService } from '../authentication/authentication.service';
import { SharedService } from '../shared/shared.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService {

  constructor(private svcShared:AuthenticationService,private router:Router) { }
  canLoad(route: Route): boolean {
    let url: string = route.path;
    
    if (this.svcShared.currentUserValue!=null) {
	    if(url.includes("admin")){
        if(this.svcShared.currentUserValue.ClientesEntity!=null || this.svcShared.currentUserValue.PrestadoresEntity!=null){
          return false;
        }else{
          return true;
        }
      }else{
        return true;
      }
    }else{
      this.router.navigate([ '/login']);
      return false;
    }

  }

  canActivate(route: ActivatedRouteSnapshot,state: RouterStateSnapshot): boolean {
   
    if (this.svcShared.currentUserValue!=null) {
	    return true;
    }else{
      this.router.navigate([ '/login']);
      return false;
    }


  }
}
