import { Injectable } from '@angular/core';
import { NotifierService } from 'angular-notifier';
import { BehaviorSubject } from 'rxjs';
import { IProduct } from '../models';
import { ProductService } from '../services';

@Injectable({
  providedIn: 'root',
})
export class ProductStore {
  private _productsList: BehaviorSubject<IProduct[]> = new BehaviorSubject<any>(
    ''
  );
  constructor(
    private productService: ProductService,
    private notifierService: NotifierService
  ) {
    this.loadInitialProducts();
  }

  loadInitialProducts() {
    this.productService.getAllProducts().subscribe(
      (products: IProduct[]) => {
        this._productsList.next(products);
      },
      (error) => {
        this.notifierService.notify(
          'error',
          'Unable to retrieve product products'
        );
      }
    );
  }

  get products() {
    return this._productsList.asObservable();
  }

  filterProductsByCategory(categoryId: number) {
    this.productService
      .getAllProductsByCategoryId(categoryId)
      .subscribe((products) => {
        this._productsList.next(products);
      });
  }
}
