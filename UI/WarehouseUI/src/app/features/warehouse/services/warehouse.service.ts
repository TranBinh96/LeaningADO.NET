import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Warehouse} from "../models/warehouse.model";
import {AddWarehouseRequest} from "../models/add-warehouse-request.model";

import {UpdateWarehouseRequest} from "../models/update-warehouse-request.model";
import {environment} from "../../../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class WarehouseService {

  constructor(private http: HttpClient) { }
  getWarehouseById(id: number): Observable<Warehouse> {
    return this.http.get<Warehouse>(`${environment.apiBaseUrl}/api/ware/${id}`);
  }

  getAllWarehouse(): Observable<Warehouse[]> {
    return this.http.get<Warehouse[]>(`${environment.apiBaseUrl}/api/ware`);
  }

  addWarehouse(model: AddWarehouseRequest): Observable<void> {
    return this.http.post<void>(`${environment.apiBaseUrl}/api/ware?addAuth=true`, model);
  }
  updateWarehouse(id: number, updateCategoryRequest: UpdateWarehouseRequest): Observable<Warehouse> {
    return this.http.put<Warehouse>(`${environment.apiBaseUrl}/api/ware/${id}?addAuth=true`, updateCategoryRequest);
  }
  deleteWarehouse(id: number): Observable<Warehouse> {
    return this.http.delete<Warehouse>(`${environment.apiBaseUrl}/api/ware/${id}?addAuth=true`)
  }

}
