import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DoctorService } from '../services/doctor.service';

@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']
})
export class DoctorComponent implements OnInit {
  doctors:any;
  hId=0;

  model:any={
    id:'',
    name:'',
    phnNumber:'',
    specialist:''
  }
  // @ts-ignore
  public doctorForm:FormGroup;
  constructor(private formBuilder:FormBuilder,private service:DoctorService) {
   }
   ngOnInit(): void {
    //this.init();
    this.getAllDoctors();
   }
   getAllDoctors(){
    this.service.getAllDoctors().subscribe((data)=>{
      console.warn("data",data);      
      this.doctors=data
    });
   }
   addDoctorHId(){
    this.hId=1;
   }
  
  public saveBook():void{
    if(this.model.id==''){
      //console.log(this.model);
      this.service.addDoctor(this.model).subscribe(result=>{
        //alert(`New book added with id=${result.id}`);
        this.getAllDoctors();
      });

    }
    else{
       this.service.updateDoctor(this.model).subscribe(result=>{
         //console.log(1);
         this.getAllDoctors();
       });
       
    }
    this.hId=0;
    this.model={};
  }
  // private init():void{
  //   this.doctorForm=this.formBuilder.group({
  //     name:[],
  //     phnNumber:[],
  //     specialist:[]
  //   });
  // }
  deleteDoctor(id:string){
     this.service.deleteDoctor(id)
     .subscribe(
       response=>{
        this.getAllDoctors();
       }
     );     
  }
  updateDoctor(data:any){
    this.hId=1;
    //this.model.id=data.id;
    this.model=data;
  }
  backToList(){
    this.hId=0;
  }
}
