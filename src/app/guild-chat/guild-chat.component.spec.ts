import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuildChatComponent } from './guild-chat.component';

describe('GuildChatComponent', () => {
  let component: GuildChatComponent;
  let fixture: ComponentFixture<GuildChatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuildChatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuildChatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
