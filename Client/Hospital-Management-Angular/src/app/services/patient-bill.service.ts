import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PatientBillService {

  constructor(private http:HttpClient) { }
  addPatientBill(model:any):Observable<any>{
    return this.http.post("http://localhost:5213/api/PatientBill",model);
  }
  getPatientBills():Observable<any>{
    return this.http.get("http://localhost:5213/api/PatientBill");
  }
}
