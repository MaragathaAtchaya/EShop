import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Route, RouterModule, Routes } from '@angular/router';
import { BasketnewComponent } from './basketnew.component';

const routes: Routes=[
  {path: '', component: BasketnewComponent}
]

@NgModule({
   declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class BasketRoutingModule { }
