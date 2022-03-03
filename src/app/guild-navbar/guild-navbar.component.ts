import { Component, OnInit } from '@angular/core';
import { NavbarService } from '../services/navbar/navbar.service';

@Component({
  selector: 'app-guild-navbar',
  templateUrl: './guild-navbar.component.html',
  styleUrls: ['./guild-navbar.component.css'],
})
export class GuildNavbarComponent implements OnInit {
  constructor(navbarService: NavbarService) {}

  ngOnInit(): void {}
}
