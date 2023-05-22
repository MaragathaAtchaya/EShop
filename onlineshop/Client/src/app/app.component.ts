import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from './models/product';
import { Pagination } from './models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Home';
  products: Product[]=[];

constructor (private http: HttpClient)  {}

ngOnInit(): void {
  this.http.get<Pagination<Product[]>>('https://localhost:5001/onlineshop/products?pagesize=30').subscribe({
    next: Response=> this.products=Response.data, // what to do next
    error: error=>console.log(error), //what to do if any error occurs
    complete: ()=>{
      console.log('Request completed'),
      console.log('extra stmt')
    }

  })
}

}
