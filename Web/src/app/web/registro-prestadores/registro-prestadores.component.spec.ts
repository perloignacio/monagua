import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroPrestadoresComponent } from './registro-prestadores.component';

describe('RegistroPrestadoresComponent', () => {
  let component: RegistroPrestadoresComponent;
  let fixture: ComponentFixture<RegistroPrestadoresComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistroPrestadoresComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistroPrestadoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
