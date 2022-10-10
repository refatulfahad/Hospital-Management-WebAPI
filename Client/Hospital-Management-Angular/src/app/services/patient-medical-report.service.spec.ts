import { TestBed } from '@angular/core/testing';

import { PatientMedicalReportService } from './patient-medical-report.service';

describe('PatientMedicalReportService', () => {
  let service: PatientMedicalReportService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PatientMedicalReportService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
