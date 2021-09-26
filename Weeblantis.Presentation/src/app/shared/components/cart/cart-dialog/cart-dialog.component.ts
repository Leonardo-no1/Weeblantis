import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IProduct } from 'src/app/models';
import { UserService } from 'src/app/services';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-cart-dialog',
  templateUrl: './cart-dialog.component.html',
  styleUrls: ['./cart-dialog.component.scss'],
})
export class CartDialogComponent implements OnInit {
  constructor(
    private cartService: CartService,
    private userService: UserService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    debugger;
    this.cartItems = data;
  }
  cartItems?: IProduct[];
  ngOnInit(): void {}
  removeFromCart(id: number) {
    debugger;
    this.cartService.removeFromCart(id);
    this.cartService
      .getItems()
      .subscribe((results) => (this.cartItems = results));
  }
  total() {
    return this.cartItems.reduce((sum, current) => sum + current.price, 0);
  }
}
