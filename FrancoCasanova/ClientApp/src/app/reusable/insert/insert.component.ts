import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PersonalModel } from 'src/app/models/personal';
import { PersonalServiceService } from 'src/app/services/personal-service.service';
import { NgModule } from '@angular/core';

import { Form, NgForm } from '@angular/forms';

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.css']
})
export class InsertComponent implements OnInit {

  id;
  data:PersonalModel[] = [];
  personal:PersonalModel = new PersonalModel;
  modificar:boolean = true;
  IdPersonalText:number;
  ApPaternoText:string='';
  Nombre1Text:string='';
  ApMaternoText:string='';
  Nombre2Text:string='';
  FchIngresoText:string='';
  FchNacText:string='';

  constructor( private activatedRoute:ActivatedRoute, private personalService:PersonalServiceService, private router:Router) { }

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params.id;
    if(this.id === undefined)
    {
      this.modificar = false;
    }
    else
    {
      this.verPersonal();
    }
    
  }

  verPersonal()
  {
    this.personalService.verPersonal(this.id).subscribe((respuesta:PersonalModel[]) => 
    {this.data = respuesta
      this.IdPersonalText = this.data[0].idPersonal;
      this.ApPaternoText = this.data[0].apPaterno;
      this.Nombre1Text = this.data[0].nombre1;
      this.ApMaternoText = this.data[0].apMaterno;
      this.Nombre2Text = this.data[0].nombre2;
      this.FchIngresoText = this.data[0].fchIngreso;
      this.FchNacText = this.data[0].fchNac;
    })
  }

  llenarDatos(formTemplate:NgForm)
  {
    return true;
  }

  guardarPersonal(formTemplate:NgForm)
  {
    this.personal.apPaterno = formTemplate.controls.ApPaterno.value;
    this.personal.nombre1 = formTemplate.controls.Nombre1.value     
    this.personal.apMaterno = formTemplate.controls.ApMaterno.value     
    this.personal.nombre2 = formTemplate.controls.Nombre2.value     
    this.personal.fchIngreso = formTemplate.controls.FchIngreso.value     
    this.personal.fchNac = formTemplate.controls.FchNac.value 
    this.personal.nombreCompleto = 'sdf';

    if (this.modificar) {
      
      this.personal.idPersonal = Number(this.id);
      this.personalService.modificar(this.personal).subscribe(() => this.router.navigate(['']));
      
    }
    else
    {
    this.personal.idPersonal = formTemplate.controls.IdPersonal.value;
      this.personalService.insertar(this.personal).subscribe( () => 
      this.router.navigate(['']));
    }


    
  }

}
