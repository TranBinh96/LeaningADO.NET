import {Component, OnDestroy, OnInit} from '@angular/core';
import {Subscription} from "rxjs";
import {ActivatedRoute, Router} from "@angular/router";
import {WarehouseService} from "../services/warehouse.service";
import {Warehouse} from "../models/warehouse.model";
import {UpdateWarehouseRequest} from "../models/update-warehouse-request.model";

@Component({
  selector: 'app-edit-warehouse',
  templateUrl: './edit-warehouse.component.html',
  styleUrls: ['./edit-warehouse.component.css']
})
export class EditWarehouseComponent implements  OnInit ,OnDestroy{
  id: number | null = null;
  paramsSubscription?: Subscription;
  editCategorySubscription?: Subscription;
  warehouse?: Warehouse;

  constructor(private route: ActivatedRoute,
              private warehouseService: WarehouseService,
              private router: Router) {
  }
  ngOnInit(): void {
    this.paramsSubscription = this.route.paramMap.subscribe({
      next: (params) => {
        const idParam = params.get('id');

        if (idParam) {
          this.id = Number(idParam);

          if (!isNaN(this.id)) {
            this.warehouseService.getWarehouseById(this.id)
              .subscribe({
                next: (response) => {
                  this.warehouse = response;
                },
                error: (err) => {
                  console.error('Error fetching warehouse:', err);
                }
              });
          } else {
            console.error('Invalid ID');
          }
        }
      }
    });
  }
  onFormSubmit(): void {
    const updateWarehouseRequest: UpdateWarehouseRequest = {
      wareName: this.warehouse?.wareName ?? '',
      display: this.warehouse?.display ?? '',
      note: this.warehouse?.note ?? '',
      createdBy: this.warehouse?.createdBy ?? '',
      createdDate: new Date(),
      updatedDate: new  Date(),

    };

    if (this.id) {
      this.editCategorySubscription = this.warehouseService.updateWarehouse(this.id, updateWarehouseRequest)
        .subscribe({
          next: (response) => {
            this.router.navigateByUrl('/admin/warehouse');
          }
        });
    }
  }
  ngOnDestroy(): void {
    this.paramsSubscription?.unsubscribe();
    this.editCategorySubscription?.unsubscribe();
  }

}
