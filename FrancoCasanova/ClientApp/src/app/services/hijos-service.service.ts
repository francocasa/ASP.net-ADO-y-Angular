import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { HijoModel } from '../models/hijo';

@Injectable({
  providedIn: 'root'
})
export class HijosServiceService {
  url = "";
  

  constructor(@Inject('BASE_URL') baseUrl: string, private httpClient: HttpClient) {
    this.url = baseUrl + 'api/Personal';
  }

  listar()
  {
    return this.httpClient.get(`${this.url}`);
  }

  insertar(hijoModel:HijoModel) {
    return this.httpClient.post(`${this.url}`, hijoModel);
  }

  modificar(hijoModel:HijoModel) {
    return this.httpClient.post(`${this.url}`, hijoModel);
  }

  eliminar(IdDerhab:number) {
    return this.httpClient.delete(`${this.url}/${IdDerhab}`);
  }
}
