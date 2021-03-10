import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HijoModel } from '../models/hijo';
import { HijosServiceService } from '../services/hijos-service.service';

@Component({
  selector: 'app-hijos',
  templateUrl: './hijos.component.html',
  styleUrls: ['./hijos.component.css']
})
export class HijosComponent implements OnInit {

  data:HijoModel[] = []
  id;
  displayedColumns: string[] = ['idDerHab', 'IdPersonal', 'ApPaterno', 'ApMaterno', 'Nombre1', 'Nombre2', 'NombreCompleto', 'FchNac', 'eliminar', 'modificar'];

  constructor(private activatedRoute:ActivatedRoute, private hijosService:HijosServiceService, private router:Router) { }

  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params.id;
    this.read(this.id);
  }

  read(id)
  {
    this.hijosService.listar(id).subscribe(
      (respuesta:HijoModel[]) => this.data = respuesta
    )

  }

  eliminarHijo(idDerHab)
  {
    
    this.hijosService.eliminar(idDerHab).subscribe();
    this.ngOnInit();
  }

  
  insertarHijo()
  {
    this.router.navigate(['/insertarHijo', this.id])
  }

  modificarHijo(idDerHab)
  {
    this.router.navigate(['/modificarHijo', idDerHab])
  }

}
