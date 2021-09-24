import { Component, OnInit } from '@angular/core';
import { NotifierService } from 'angular-notifier';
import { Subscription } from 'rxjs';
import { IProduct } from '../models';
import { ProductService } from '../services';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  constructor(
    private productService: ProductService,
    private notifierService: NotifierService
  ) {}
  productList!: IProduct[];
  subscription!: Subscription;
  lowStock = 30;

  quantity: number = 0;
  ngOnInit(): void {
    this.subscription = this.productService.getAllProducts().subscribe(
      (products: IProduct[]) => {
        this.productList = products;
      },
      (error) => {
        this.notifierService.notify(
          'error',
          'Unable to retrieve product products'
        );
      }
    );
  }
}
