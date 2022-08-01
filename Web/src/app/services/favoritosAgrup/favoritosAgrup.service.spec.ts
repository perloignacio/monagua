import { TestBed } from '@angular/core/testing';

import { FavoritosAgrupService } from './favoritosAgrup.service';

describe('FavoritosAgrupService', () => {
  let service: FavoritosAgrupService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FavoritosAgrupService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
