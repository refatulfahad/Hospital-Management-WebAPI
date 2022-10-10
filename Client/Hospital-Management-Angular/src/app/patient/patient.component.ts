import { Component, OnInit } from '@angular/core';
import { IDropdownSettings } from 'ng-multiselect-dropdown';
import { DoctorService } from '../services/doctor.service';
import { PatientService } from '../services/patient.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import {FormControl} from '@angular/forms';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {
  //toppings = new FormControl('');
  patients:any;
  hId=0;
  patientId:any;
  doctors:[]=[];
  model:any={
    id:'',
    name:'',
    age:'',
    gender:'',
    phnNumber:'',
    doctorId:[]
  }
  detailsDoctors:any;
  val:number=0;
  Id:any;
  dropdownList:any;
  dropdownSettings:IDropdownSettings={};
  selectedItems:any;
  //@ts-ignore
  dropDownForm:FormGroup=this.fb.group({
    myItems:[]
    //this.dropDownForm.value;
  });
 
  // dropDownForm=new FormGroup({
  //   myItems:new FormControl([])
  // });
  
  constructor(private service:PatientService,private doctorService:DoctorService,private fb: FormBuilder) { 
    this.getAllPatients();
  }
  
  ngOnInit(): void {
    
    
    // this.dropdownList = [
    //   { item_id: 1, item_text: 'Item1' },
    //   { item_id: 2, item_text: 'Item2' },
    //   { item_id: 3, item_text: 'Item3' },
    //   { item_id: 4, item_text: 'Item4' },
    //   { item_id: 5, item_text: 'Item5' }
    // ];
    // this.dropdownSettings = {
    //   idField: 'item_id',
    //   textField: 'item_text',
    // };
  }
  getAllPatients(){
    this.service.getAllPatients().subscribe((data)=>{
      //console.warn("data",data);      
      this.patients=data
    });
  }
  backToList(){
    this.hId=0;
  }
  addPatienthId(){
    this.hId=1;
    this.doctorService.getAllDoctors().subscribe((data)=>{
      //console.warn("data",data);      
      this.doctors=data
      let tmp=[];
      for(var val of data) {
        tmp.push({ item_id: val.id, item_text: val.id });
        
      }
      //console.log(tmp);
      this.dropdownList=tmp;
    });

    this.dropdownSettings = {
      idField: 'item_id',
      textField: 'item_text',
      noDataAvailablePlaceholderText: "There is no item availabale to show",
      allowSearchFilter: true
    };

  }
  saveBook(){
    for(var data of this.selectedItems)
      {
        this.model.doctorId.push(data.item_id);
      }
    if(this.model.id==''){
      this.service.addPatient(this.model).subscribe(result=>{
        //alert(`New book added with id=${result.id}`);
        console.log(this.model);
        this.hId=0;
        this.getAllPatients();
      });
    }
    else{
      console.log(this.selectedItems);      
      console.log(this.model.doctorId);
      this.service.updatePatient(this.model).subscribe(result=>{
        //alert(`New book added with id=${result.id}`);
        console.log(this.model);
        this.hId=0;
        this.getAllPatients();
      });
    }
    this.hId=0;
    this.model={};
    this.selectedItems="";
  }
  onItemSelect(item: any) {
    //console.log(this.selectedItems);
    //this.model.selectedItems.push(item.item_id);
    //console.log(this.model.doctorId);
  }
  updatePatient(data:any){
    this.addPatienthId();
    this.hId=1;
    //this.model.id=data.id;
    this.model=data;
    this.model.doctorId=[];
     
    this.service.appointmentId(data.id).subscribe((result)=>{
      //console.warn("data",data); 
    this.Id=result;      
    let tmp=[];
    //console.log(result);
    for(var val of this.Id) {
      tmp.push({ item_id: val, item_text: val });    
     }
     this.selectedItems=tmp;
     //console.log(this.selectedItems);
    });
    
    // this.selectedItems = [
    //   { item_id: 3, item_text: 'Item3'  },
    //   { item_id: 4,item_text: 'Item4' }
    // ];
    // this.dropDownForm = this.fb.group({
    //   myItems: this.selectedItems    
    // });
  }
  detailsDoctor(id:string){
    this.hId=2;
    this.service.getdetailsDoctors(id).subscribe((data)=>{
      //console.warn("data",data);      
      this.detailsDoctors=data
    });
  }
}
