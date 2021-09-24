import { Component, OnInit } from '@angular/core';
import { NotifierService } from 'angular-notifier';
import { Subscription } from 'rxjs';
import { ICategory } from 'src/app/models';
import { ProductService } from 'src/app/services';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.scss'],
})
export class CategoryListComponent implements OnInit {
  constructor(
    private productService: ProductService,
    private notifierService: NotifierService
  ) {}
  categoryList!: ICategory[];
  subscription!: Subscription;
  ngOnInit(): void {
    this.subscription = this.productService.getAllProductCategories().subscribe(
      (categories: ICategory[]) => {
        this.categoryList = categories;
      },
      (error) => {
        this.notifierService.notify(
          'error',
          'Unable to retrieve product categories'
        );
      }
    );
  }
}
