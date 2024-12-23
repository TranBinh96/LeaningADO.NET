import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {WarehouseListComponent} from "./features/warehouse/warehouse-list/warehouse-list.component";
import {AddWarehouseComponent} from "./features/warehouse/add-warehouse/add-warehouse/add-warehouse.component";
import {EditWarehouseComponent} from "./features/warehouse/edit-warehouse/edit-warehouse.component";



const routes: Routes = [
  { path: 'admin/warehouse', component: WarehouseListComponent },
  { path: 'admin/warehouse/add', component: AddWarehouseComponent },
  { path: 'admin/warehouse/:id', component: EditWarehouseComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
