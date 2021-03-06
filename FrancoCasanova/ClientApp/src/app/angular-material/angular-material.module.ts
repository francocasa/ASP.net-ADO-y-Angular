import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


// Angular Material
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatCardModule} from '@angular/material/card';
import {MatTableModule } from "@angular/material/table";

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatToolbarModule, 
    MatButtonModule, 
    MatProgressBarModule,
    MatCardModule,
    MatTableModule
  ],
  exports:[
    MatToolbarModule, 
    MatButtonModule, 
    MatProgressBarModule,
    MatCardModule,
    MatTableModule
  ]
})
export class AngularMaterialModule { }
