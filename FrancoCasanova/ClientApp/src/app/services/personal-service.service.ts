import { Inject, Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { PersonalModel } from '../models/personal';

@Injectable({
  providedIn: 'root'
})
export class PersonalServiceService {
  url = "";
  

  constructor(@Inject('BASE_URL') baseUrl: string, private httpClient: HttpClient) {
    this.url = baseUrl + 'api/Personal';
  }

  listar()
  {
    return this.httpClient.get(`${this.url}`);
  }

  verPersonal(idPersonal)
  {
    return this.httpClient.get(`${this.url}/${idPersonal}`);
  }

  insertar(personalModel:PersonalModel) {
    return this.httpClient.post(`${this.url}`, personalModel);
  }

  modificar(personalModel:PersonalModel) {
    return this.httpClient.put(`${this.url}`, personalModel);
  }

  eliminar(IdPersonal:number) {
    return this.httpClient.delete(`${this.url}/${IdPersonal}`);
  }
}
