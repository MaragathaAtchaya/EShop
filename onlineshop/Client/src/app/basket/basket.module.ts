import { NgModule } from '@angular/core';
//import { BasketComponent } from './basket.component';
import { BasketRoutingModule } from './basket-routing.module';
import { BasketnewComponent } from './basketnew.component';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    //BasketComponent,
    BasketnewComponent
  ],
  imports: [
    CommonModule,
    BasketRoutingModule,
    SharedModule
  ]
})
export class BasketModule {

 }
