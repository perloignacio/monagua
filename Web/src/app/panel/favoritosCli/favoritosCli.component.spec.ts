import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoritosCliComponent } from './favoritosCli.component';

describe('FavoritosCliComponent', () => {
  let component: FavoritosCliComponent;
  let fixture: ComponentFixture<FavoritosCliComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavoritosCliComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavoritosCliComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
