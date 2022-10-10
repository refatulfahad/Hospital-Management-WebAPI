import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DoctorComponent } from './doctor/doctor.component';
import { PatientBillComponent } from './patient-bill/patient-bill.component';
import { PatientMedicalReportComponent } from './patient-medical-report/patient-medical-report.component';
import { PatientComponent } from './patient/patient.component';
import { PatientService } from './services/patient.service';

const routes: Routes = [
  {path:'doctor-list',component:DoctorComponent},
  {path:'patient-list',component:PatientComponent},
  {path:'patientBill-list',component:PatientBillComponent},
  {path:'patientMedicalReport-list',component:PatientMedicalReportComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
