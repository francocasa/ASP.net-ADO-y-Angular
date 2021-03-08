import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


// Angular Material
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule } from "@angular/material/table";

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatToolbarModule, 
    MatButtonModule, 
    MatTableModule
  ],
  exports:[
    MatToolbarModule, 
    MatButtonModule, 
    MatTableModule
  ]
})
export class AngularMaterialModule { }
