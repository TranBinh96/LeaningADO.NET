import {Component, OnInit} from '@angular/core';
import {Observable, Subscription} from "rxjs";
import {Warehouse} from "../models/warehouse.model";
import {WarehouseService} from "../services/warehouse.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-warehouse-list',
  templateUrl: './warehouse-list.component.html',
  styleUrls: ['./warehouse-list.component.css']
})
export class WarehouseListComponent implements  OnInit{
  warehouse$?: Observable<Warehouse[]>;
  paramsSubscription?: Subscription;
  id: number | null = null;
  constructor(private warehouseService: WarehouseService,
              private router: Router) {
  }
  ngOnInit(): void {
   this.loadWarehouses();

  }
  loadWarehouses(): void {
    this.warehouse$ = this.warehouseService.getAllWarehouse();
  }
  onDelete(id :number): void {
    this.warehouseService.deleteWarehouse(id)
      .subscribe({
        next: (response) => {
          this.loadWarehouses();
        }
      })

  }

}
