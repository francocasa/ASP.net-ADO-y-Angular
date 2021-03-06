import {AfterViewInit, Component, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements AfterViewInit {
  displayedColumns: string[] = ['IdPersonal', 'ApPaterno', 'ApMaterno', 'Nombre1', 'Nombre2', 'NombreCompleto', 'FchNac', 'FchIngreso'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
}

export interface PeriodicElement {
  IdPersonal: number;
  ApPaterno: string;
  ApMaterno: string;
  Nombre1: string;
  Nombre2: string;
  NombreCompleto: string;
  FchNac: string;
  FchIngreso: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
];