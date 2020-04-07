import { TestBed } from '@angular/core/testing';

import { ContagionService } from './contagion.service';

describe('ContagionService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ContagionService = TestBed.get(ContagionService);
    expect(service).toBeTruthy();
  });
});
