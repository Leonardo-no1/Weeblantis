import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { NotifierService } from 'angular-notifier';
import { Observable, Subscription } from 'rxjs';
import { IProduct } from '../models';
import { ProductService } from '../services';
import { CartService } from '../services/cart.service';
import { ProductStore } from '../stores/product-store';
@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  constructor(
    private productStore: ProductStore,
    private notifierService: NotifierService,
    private cartService: CartService
  ) {
    this.cartService.getItems().subscribe((cartItems) => {
      this.cartItems = cartItems;
    });
  }
  productList: IProduct[];
  inCart = false;
  subscription!: Subscription;
  lowStock = 30;
  cartItems: IProduct[];
  ngOnInit(): void {
    this.productStore.products.subscribe((products) => {
      this.productList = products;
    });
  }
}
