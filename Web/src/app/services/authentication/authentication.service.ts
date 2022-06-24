import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})

export class AuthenticationService {

  private currentUserSubject: BehaviorSubject<Usuarios>;
  public currentUser: Observable<Usuarios>;

  constructor(private http: HttpClient) {
      this.currentUserSubject = new BehaviorSubject<Usuarios>(JSON.parse(localStorage.getItem('currentUser')));
      this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): Usuarios {

      return this.currentUserSubject.value;
  }

  login(username: string, password: string) {
      return this.http.get<Usuarios>(`${environment.apiUrl}usuarios/login?usuario=${username}&contra=${password}`)
          .pipe(map(user => {
              // store user details and jwt token in local storage to keep user logged in between page refreshes
              if(user!=null){
                localStorage.setItem('currentUser', JSON.stringify(user));
                this.currentUserSubject.next(user);
                return user;
              }else{
                return null;
              }

          }));
  }

  logout() {
      // remove user from local storage to log user out

      localStorage.removeItem('currentUser');
      this.currentUserSubject.next(null);
  }
  Recuperar(email:string){
    return this.http.get<boolean>(environment.apiUrl + `usuarios/recuperar/?usuario=`+email, httpOptions)
  }
  Blanqueo(formdata){
    return this.http.post<boolean>(environment.apiUrl + `usuarios/blanqueo/`,formdata, httpOptions)
  }
}
