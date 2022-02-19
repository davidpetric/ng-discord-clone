import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuildSideMenuComponent } from './guild-side-menu.component';

describe('GuildSideMenuComponent', () => {
  let component: GuildSideMenuComponent;
  let fixture: ComponentFixture<GuildSideMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuildSideMenuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuildSideMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
