import { Component, OnInit } from '@angular/core';
import { PatientMedicalReportService } from '../services/patient-medical-report.service';

@Component({
  selector: 'app-patient-medical-report',
  templateUrl: './patient-medical-report.component.html',
  styleUrls: ['./patient-medical-report.component.css']
})
export class PatientMedicalReportComponent implements OnInit {
  hId=0;
  model:any={
    patientProblem:'',
    medicalTest:'',
    medicalResult:'',
    date:'',
    patientId:0
  }
  searchId:string="";
  patientReports:any;
  constructor(private service:PatientMedicalReportService) {
    service.getPatientReports().subscribe((data)=>{
      console.warn("data",data);      
      this.patientReports=data
    });
   }

  ngOnInit(): void {
  }
  savePatientReport(){
    this.service.addPatientReport(this.model).subscribe(result=>{
      alert(`New book added with id=${result.id}`);
      console.log(this.model);
    });
    //console.log(this.model);
    this.hId=0;
    this.model={};
  }
  addPatientBillHId(){
    this.hId=1;
  }
  backToList(){
    this.hId=0;
  }
}
