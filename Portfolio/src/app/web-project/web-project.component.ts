import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-web-project',
  template: `
  <div class="container">
    <h1 class="text-light text-center">{{name}}</h1>
    <pre class="text-light text-center">{{description}}</pre>
    <div *ngIf="hasBootstrap" class="text-light offset-md-3"><app-skill name="Bootstrap" imagePath="./assets/images/thumbnails/bootstrap-solid.svg"></app-skill></div>
  </div>`,
  styleUrls: ['./web-project.component.less']
})
export class WebProjectComponent implements OnInit {

  @Input() name:string;
  @Input() description:string;
  @Input() technologies:string;

  private technologiesList:string[];
  private hasBootstrap = () => this.technologiesList.includes("Bootstrap");

  constructor() { }

  ngOnInit() {
    this.technologiesList = this.technologies.split(",");
    this.technologiesList.includes(`Bootstrap`)
  }

}