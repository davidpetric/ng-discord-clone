import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class NavbarService {
  public isMembersVisible: boolean = true;
  constructor() {}
}
