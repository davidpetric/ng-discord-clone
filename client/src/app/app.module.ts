import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SideMenuComponent } from './side-menu/side-menu.component';
import { GuildSideMenuComponent } from './guild-side-menu/guild-side-menu.component';
import { GuildChatComponent } from './guild-chat/guild-chat.component';
import { GuildMembersComponent } from './guild-members/guild-members.component';
import { IconsModule } from './icons/icons.module';
import { GuildNavbarComponent } from './guild-navbar/guild-navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    SideMenuComponent,
    GuildSideMenuComponent,
    GuildChatComponent,
    GuildMembersComponent,
    GuildNavbarComponent
  ],
  imports: [
    BrowserModule,
    IconsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
