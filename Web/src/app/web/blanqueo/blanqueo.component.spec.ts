import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlanqueoComponent } from './blanqueo.component';

describe('BlanqueoComponent', () => {
  let component: BlanqueoComponent;
  let fixture: ComponentFixture<BlanqueoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BlanqueoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BlanqueoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
