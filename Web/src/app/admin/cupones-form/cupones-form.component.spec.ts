import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CuponesFormComponent } from './cupones-form.component';

describe('CuponesFormComponent', () => {
  let component: CuponesFormComponent;
  let fixture: ComponentFixture<CuponesFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CuponesFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CuponesFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
