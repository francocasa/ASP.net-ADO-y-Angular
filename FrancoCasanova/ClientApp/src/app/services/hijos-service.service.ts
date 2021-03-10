import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { HijoModel } from '../models/hijo';

@Injectable({
  providedIn: 'root'
})
export class HijosServiceService {
  url = "";
  

  constructor(@Inject('BASE_URL') baseUrl: string, private httpClient: HttpClient) {
    this.url = baseUrl + 'api/Hijos';
  }

  listar(idPersonal)
  {
    return this.httpClient.get(`${this.url}/${idPersonal}/hijos`);
  }

  verHijo(idDerHab)
  {
    return this.httpClient.get(`${this.url}/${idDerHab}/datos`);
  }

  insertar(hijoModel:HijoModel) {
    return this.httpClient.post(`${this.url}`, hijoModel);
  }

  modificar(hijoModel:HijoModel) {
    return this.httpClient.put(`${this.url}`, hijoModel);
  }

  eliminar(idDerHab:number) {
    return this.httpClient.delete(`${this.url}/${idDerHab}`);
  }

  



}
