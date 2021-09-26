import { Component, Input, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { IProduct } from 'src/app/models';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent implements OnInit {
  @Input() product: IProduct;
  inCart = false;
  lowStock = 30;
  constructor(private cartService: CartService) {}

  ngOnInit(): void {}

  addToCart(product: IProduct) {
    this.cartService.addToCart(product);
    this.inCart = true;
  }

  removeFromCart(index: number) {
    this.cartService.removeFromCart(index);
    this.inCart = false;
  }
}
