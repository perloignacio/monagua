import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoritosDetalleComponent } from './favoritos-detalle.component';

describe('FavoritosDetalleComponent', () => {
  let component: FavoritosDetalleComponent;
  let fixture: ComponentFixture<FavoritosDetalleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavoritosDetalleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavoritosDetalleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
