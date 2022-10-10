import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class PatientService {

  constructor(private http:HttpClient) { }
  public getAllPatients():Observable<any>{
    //console.log(1);
    return this.http.get("http://localhost:5213/api/Patient/getAllPatients");
  }
  addPatient(model:any):Observable<any>{
    return this.http.post("http://localhost:5213/api/Patient/addPatient",model);
  }
  appointmentId(id:string){
    return this.http.get("http://localhost:5213/api/Patient/appointmentId/"+id); 
  }
  updatePatient(model:any){
    return this.http.put("http://localhost:5213/api/Patient/updatePatient/"+model.id,model);
  }
  getdetailsDoctors(id:string){
    return this.http.get("http://localhost:5213/api/Patient/detailsPatient/"+id); 
  }
}
