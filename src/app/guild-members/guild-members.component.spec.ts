import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuildMembersComponent } from './guild-members.component';

describe('GuildMembersComponent', () => {
  let component: GuildMembersComponent;
  let fixture: ComponentFixture<GuildMembersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuildMembersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuildMembersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
