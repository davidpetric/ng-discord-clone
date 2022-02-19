import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SideMenuComponent } from './side-menu/side-menu.component';
import { GuildSideMenuComponent } from './guild-side-menu/guild-side-menu.component';
import { GuildChatComponent } from './guild-chat/guild-chat.component';
import { GuildMembersComponent } from './guild-members/guild-members.component';
import { IconsModule } from './icons/icons.module';

@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    GuildSideMenuComponent,
    GuildChatComponent,
    GuildMembersComponent
  ],
  imports: [
    BrowserModule,
    IconsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
