import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {
  basePath:string="http://localhost:5213/api/Doctor/getDoctorList";
  constructor(private http:HttpClient) { }

  public getAllDoctors():Observable<any>{
    //console.log(1);
    return this.http.get(this.basePath);
  }
  public addDoctor(doctor:any):Observable<any>{
    return this.http.post("http://localhost:5213/api/Doctor/addDoctor",doctor);
   }
  public deleteDoctor(id:any):Observable<any>{
   
    return this.http.delete("http://localhost:5213/api/Doctor/deleteDoctor/"+id);
  }
  public updateDoctor(data:any):Observable<any>{
    return this.http.put("http://localhost:5213/api/Doctor/updateDoctor/"+data.id,data);
  } 
}
