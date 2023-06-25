import { TestBed } from '@angular/core/testing';

import { TraindetailsService } from './traindetails.service';

describe('TraindetailsService', () => {
  let service: TraindetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TraindetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
