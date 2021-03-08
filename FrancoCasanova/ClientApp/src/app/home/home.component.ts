import { Component, OnInit, ViewChild} from '@angular/core';
import { PersonalModel } from '../models/personal';
import { PersonalServiceService } from '../services/personal-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements OnInit {
  data:PersonalModel[] = [];
  displayedColumns: string[] = ['IdPersonal', 'ApPaterno', 'ApMaterno', 'Nombre1', 'Nombre2', 'NombreCompleto', 'FchNac', 'FchIngreso'];
  base;


  constructor(private personalService: PersonalServiceService) {
  }

  ngOnInit(): void {
    this.read()
  }

  read()
  {
    this.personalService.listar().subscribe(
      (respuesta:PersonalModel[]) => this.data = respuesta
    )

    setTimeout(() => {
      
      this.base = this.data;
        
      
      console.log(this.data[0].ApMaterno )
      
      console.log("asdasd")
      console.log(this.data[0])
    }, 1000);
  }

}



