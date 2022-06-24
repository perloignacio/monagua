import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HorariosActividadesComponent } from './horarios-actividades.component';

describe('HorariosActividadesComponent', () => {
  let component: HorariosActividadesComponent;
  let fixture: ComponentFixture<HorariosActividadesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HorariosActividadesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HorariosActividadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
