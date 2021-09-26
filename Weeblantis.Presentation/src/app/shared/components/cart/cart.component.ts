import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { IProduct } from 'src/app/models';
import { CartService } from 'src/app/services/cart.service';
import { CartDialogComponent } from './cart-dialog/cart-dialog.component';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss'],
})
export class CartComponent implements OnInit {
  cartProductCount: number = 0;
  constructor(private cartService: CartService, private dialog: MatDialog) {
    this.cartService.getItems().subscribe((cartItems) => {
      this.cart = cartItems;
    });
  }
  cart: IProduct[] = [];
  ngOnInit(): void {}

  viewCart() {
    let dialogRef = this.dialog.open(CartDialogComponent, {
      height: 'auto',
      maxHeight: '500px',
      width: '100%',
      data: this.cart,
    });
  }
}
