import { Component } from '@angular/core';
import {Router} from "@angular/router";
import {AddWarehouseRequest} from "../../models/add-warehouse-request.model";
import {Subscription} from "rxjs";
import {WarehouseService} from "../../services/warehouse.service";


@Component({
  selector: 'app-add-warehouse',
  templateUrl: './add-warehouse.component.html',
  styleUrls: ['./add-warehouse.component.css']
})
export class AddWarehouseComponent {
  model: AddWarehouseRequest;
  private addCategorySubscribtion?: Subscription;

  constructor(private warehouseService: WarehouseService,
              private router: Router) {
    this.model = {
      wareName: '',
      display: '',
      createdBy: '',
      note: '',
      createdDate:new Date(),
      updatedDate:new Date(),

    };
  }
  onFormSubmit() {
    this.addCategorySubscribtion = this.warehouseService.addWarehouse(this.model)
      .subscribe({
        next: (response) => {
          this.router.navigateByUrl('/admin/warehouse');

        },
        error: (err) => {
          console.error('Error adding warehouse:', err);
          alert('An error occurred while adding the warehouse.');
        }
      });
  }


  ngOnDestroy(): void {
    this.addCategorySubscribtion?.unsubscribe();
  }
}
