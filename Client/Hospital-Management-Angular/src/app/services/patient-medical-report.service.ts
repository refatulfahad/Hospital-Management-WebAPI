import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PatientMedicalReportService {

  constructor(private http:HttpClient) { }
  addPatientReport(model:any):Observable<any>{
    return this.http.post("http://localhost:5213/api/MedicalReport",model);
  }
  getPatientReports():Observable<any>{
    return this.http.get("http://localhost:5213/api/MedicalReport");
  }
}
