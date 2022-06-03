import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss'],
})
export class TitleComponent implements OnInit {
  @Input() titulo!: string;
  @Input() icone = 'fa fa-user';
  @Input() subtitulo = 'Desde 2021'; 
  @Input() botaoListar = false;

  constructor() {}

  ngOnInit(): void {}
}
