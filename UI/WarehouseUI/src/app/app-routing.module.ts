import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {WarehouseListComponent} from "./features/warehouse/warehouse-list/warehouse-list.component";
import {AddWarehouseComponent} from "./features/warehouse/add-warehouse/add-warehouse/add-warehouse.component";
import {EditWarehouseComponent} from "./features/warehouse/edit-warehouse/edit-warehouse.component";
import {LoginComponent} from "./features/auth/login/login.component";
import {authGuard} from "./features/auth/guards/auth.guard";




const routes: Routes = [
  { path: 'admin/warehouse', component: WarehouseListComponent , canActivate: [authGuard]},
  { path: 'admin/warehouse/add', component: AddWarehouseComponent, canActivate: [authGuard] },
  { path: 'admin/warehouse/:id', component: EditWarehouseComponent, canActivate: [authGuard] },
  { path: 'login', component: LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
