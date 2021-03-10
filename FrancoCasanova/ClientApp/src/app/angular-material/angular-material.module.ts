import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


// Angular Material
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule } from "@angular/material/table";
import {MatInputModule} from '@angular/material/input';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatToolbarModule, 
    MatButtonModule, 
    MatTableModule,
    MatInputModule
  ],
  exports:[
    MatToolbarModule, 
    MatButtonModule, 
    MatTableModule,
    MatInputModule
  ]
})
export class AngularMaterialModule { }
