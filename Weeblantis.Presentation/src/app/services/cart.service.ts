import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { IProduct } from '../models';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  private _cart: Subject<IProduct[]> = new Subject<IProduct[]>();
  items: IProduct[] = [];
  constructor() {}

  addToCart(product: IProduct) {
    this.items.push(product);
    this._cart.next(this.items);
  }
  removeFromCart(index: number) {
    this.items = this.items.filter((_item) => _item.id !== index);
    this._cart.next(this.items);
  }

  getItems() {
    debugger;
    return this._cart.asObservable();
  }

  getTotal() {
    return this.items.reduce((sum, current) => sum + current.price, 0);
  }

  clearCart() {
    this.items = [];
    this._cart.next(this.items);
  }
}
