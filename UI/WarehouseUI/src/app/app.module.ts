import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {FormsModule} from "@angular/forms";
import {NavbarComponent} from "./core/conponents/navbar/navbar.component";
import { WarehouseListComponent } from './features/warehouse/warehouse-list/warehouse-list.component';
import { AddWarehouseComponent } from './features/warehouse/add-warehouse/add-warehouse/add-warehouse.component';
import { EditWarehouseComponent } from './features/warehouse/edit-warehouse/edit-warehouse.component';
import {LoginComponent} from "./features/auth/login/login.component";
import {AuthInterceptor} from "./core/interceptors/auth.interceptor";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    WarehouseListComponent,
    AddWarehouseComponent,
    EditWarehouseComponent,
    LoginComponent,
  ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule
    ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
