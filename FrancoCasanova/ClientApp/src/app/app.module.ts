import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';

import { AngularMaterialModule } from "./angular-material/angular-material.module";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { InsertComponent } from './reusable/insert/insert.component';
import { HijosComponent } from './hijos/hijos.component';
import { InsertarHijoComponent } from './insertar-hijo/insertar-hijo.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    InsertComponent,
    HijosComponent,
    InsertarHijoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AngularMaterialModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'insert', component: InsertComponent},
      { path: 'modificar/:id', component: InsertComponent},
      { path: 'insertarHijo/:id', component: InsertarHijoComponent},
      { path: 'modificarHijo/:id', component: InsertarHijoComponent},
      { path: 'hijos/:id', component: HijosComponent},
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
