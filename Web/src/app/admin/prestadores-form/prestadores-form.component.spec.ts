import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrestadoresFormComponent } from './prestadores-form.component';

describe('PrestadoresFormComponent', () => {
  let component: PrestadoresFormComponent;
  let fixture: ComponentFixture<PrestadoresFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PrestadoresFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PrestadoresFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
