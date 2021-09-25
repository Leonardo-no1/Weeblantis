import { Component, OnInit } from '@angular/core';
import { NotifierService } from 'angular-notifier';
import { Subscription } from 'rxjs';
import { IProduct } from '../models';
import { ProductService } from '../services';
import { ProductStore } from '../stores/product-store';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  constructor(
    private productStore: ProductStore,
    private notifierService: NotifierService
  ) {}
  productList!: IProduct[];
  subscription!: Subscription;
  lowStock = 30;

  quantity: number = 0;
  ngOnInit(): void {
    this.productStore.products.subscribe((products) => {
      this.productList = products;
    });
  }
}
