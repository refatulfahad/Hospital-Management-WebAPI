import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {
  basePath:string="http://localhost:5213/api/Doctor/GetDoctorList";
  constructor(private http:HttpClient) { }

  public getAllDoctors():Observable<any>{
    //console.log(1);
    return this.http.get(this.basePath);
  }
  public addDoctor(doctor:any):Observable<any>{
    return this.http.post("http://localhost:5213/api/Doctor/AddDoctor",doctor);
   }
  public deleteDoctor(id:any):Observable<any>{
   
    return this.http.delete("http://localhost:5213/api/Doctor/DeleteDoctor/"+id);
  }
  public updateDoctor(data:any):Observable<any>{
    return this.http.put("http://localhost:5213/api/Doctor/UpdateDoctor/"+data.id,data);
  } 
}
