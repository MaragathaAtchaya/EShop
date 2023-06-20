import { Component } from '@angular/core';
import { BasketService } from './basket.service';
import { BasketItem } from '../shared/models/basket';

@Component({
  selector: 'app-basketnew',
  templateUrl: './basketnew.component.html',
  styleUrls: ['./basketnew.component.scss']
})
export class BasketnewComponent {

constructor(public basketService: BasketService){}

incrementItem(item: BasketItem){
  this.basketService.addItemToBasket(item);
}

removeItem(id: number, quantity: number){
  this.basketService.removeItemFromBasket(id, quantity);
}


}
