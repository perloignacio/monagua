import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalActualizaActividadComponent } from './modal-actualiza-actividad.component';

describe('ModalActualizaActividadComponent', () => {
  let component: ModalActualizaActividadComponent;
  let fixture: ComponentFixture<ModalActualizaActividadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalActualizaActividadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalActualizaActividadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
