import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HijoModel } from '../models/hijo';
import { HijosServiceService } from '../services/hijos-service.service';

@Component({
  selector: 'app-insertar-hijo',
  templateUrl: './insertar-hijo.component.html',
  styleUrls: ['./insertar-hijo.component.css']
})
export class InsertarHijoComponent implements OnInit {

  id
  hijo:HijoModel = new HijoModel;
  data:HijoModel[] = [];

  modificar:boolean = true;
  IdPersonalText:number;
  ApPaternoText:string='';
  Nombre1Text:string='';
  ApMaternoText:string='';
  Nombre2Text:string='';
  IdDerHabText:number;
  FchNacText:string='';

  constructor( private activatedRoute:ActivatedRoute, private hijosService:HijosServiceService, private router:Router) { }

  ngOnInit() {
    
    this.id = this.activatedRoute.snapshot.params.id;

    if(this.router.url.split('/')[1] == 'modificarHijo')
    {
      this.modificar = true
      this.hijo.idDerHab = Number(this.id);
      this.verHijo();
    }
    else
    {
      this.modificar = false;
      this.hijo.idPersonal = Number(this.id);
    }

    
  }

  guardarHijo(formTemplate:NgForm)
  {
    this.hijo.apPaterno = formTemplate.controls.ApPaterno.value;
    this.hijo.nombre1 = formTemplate.controls.Nombre1.value;
    this.hijo.apMaterno = formTemplate.controls.ApMaterno.value;
    this.hijo.nombre2 = formTemplate.controls.Nombre2.value;
    this.hijo.fchNac = formTemplate.controls.FchNac.value;
    this.hijo.nombreCompleto = ""

    if(this.modificar)
    {
      console.log(this.hijo)
      this.hijosService.modificar(this.hijo).subscribe(() => this.router.navigate(['hijos', this.hijo.idPersonal]));
    }
    else
    {
      this.hijo.idDerHab = Number(formTemplate.controls.IdDerHab.value);
      
      console.log(this.hijo)
      this.hijosService.insertar(this.hijo).subscribe( () =>
        this.router.navigate(['hijos', this.id]));

    }
    
  }

  verHijo()
  {
    this.hijosService.verHijo(this.id).subscribe((respuesta:HijoModel[]) => 
    {
      this.data = respuesta;
      this.IdPersonalText = this.data[0].idPersonal;
      this.ApPaternoText = this.data[0].apPaterno;
      this.Nombre1Text = this.data[0].nombre1;
      this.ApMaternoText = this.data[0].apMaterno;
      this.Nombre2Text = this.data[0].nombre2;
      this.IdDerHabText = this.data[0].idDerHab;
      this.FchNacText = this.data[0].fchNac;

      this.hijo.idPersonal = Number(this.data[0].idPersonal);
    })
  }




}
