import { Component, OnInit, ViewChild} from '@angular/core';
import { Router } from '@angular/router';
import { PersonalModel } from '../models/personal';
import { PersonalServiceService } from '../services/personal-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements OnInit {
  data:PersonalModel[] = [];
  displayedColumns: string[] = ['IdPersonal', 'ApPaterno', 'ApMaterno', 'Nombre1', 'Nombre2', 'NombreCompleto', 'FchNac', 'FchIngreso', 'eliminar', 'hijo', 'modificar'];
  base;
  index;


  constructor(private personalService: PersonalServiceService, private router:Router) {
  }

  ngOnInit(): void {
    this.read()
  }

  read()
  {
    this.personalService.listar().subscribe(
      (respuesta:PersonalModel[]) => this.data = respuesta
    )

  }

  insertarPersonal()
  {
    this.router.navigate(['/insert'])
  }

  eliminarPersonal(idPersonal)
  {
    this.personalService.eliminar(idPersonal).subscribe();
    this.ngOnInit();
  }

  hijos(idPersonal)
  {
    
    this.router.navigate(['/hijos', idPersonal])
  }

  modificar(idPersonal)
  {
    this.router.navigate(['/modificar', idPersonal])
  }

}



