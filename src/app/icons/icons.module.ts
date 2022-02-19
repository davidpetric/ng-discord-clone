import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { allIcons } from 'angular-feather/icons';
import { FeatherModule } from 'angular-feather';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FeatherModule.pick(allIcons)
  ],
  exports: [
    FeatherModule
  ]
})
export class IconsModule { }
