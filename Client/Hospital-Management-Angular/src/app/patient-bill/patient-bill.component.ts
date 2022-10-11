import { Component, OnInit } from '@angular/core';
import { PatientBillService } from '../services/patient-bill.service';

@Component({
  selector: 'app-patient-bill',
  templateUrl: './patient-bill.component.html',
  styleUrls: ['./patient-bill.component.css']
})
export class PatientBillComponent implements OnInit {
  hId:number=0;
  model:any={
    billType:'',
    billAmount:'',
    date:'',
    patientId:''
  }
  searchId:string="";
  patientBills:any;
  constructor(private service:PatientBillService) {
    
   }

  ngOnInit(): void {   
      // this.service.getPatientBills().subscribe((data)=>{
      //   console.warn("data",data);      
      //   this.patientBills=data
      // });
  }
  addPatientBillHId(){
    this.hId=1;
  }
  savePatientBill(){
    this.service.addPatientBill(this.model).subscribe(result=>{
      alert(`New book added with id=${result.id}`);
      console.log(this.model);
    });
    //console.log(this.model);
    this.hId=0;
    this.model={};
  }
  backToList(){
    this.hId=0;
  }
  OnSubmit(id:string){
      console.log(id);
      this.service.getPatientBills(id).subscribe((data)=>{
        console.warn("data",data);      
        this.patientBills=data
      });
  }
}
