import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ICategory, IProduct } from '../models';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private baseUrl = `${environment.apiUrl}/api`;
  private productRoute = 'product';
  private productCategoryRoute = 'productcategory';
  constructor(private http: HttpClient) {}

  //#region Product methods

  /** Get: get all products */
  getAllProducts(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(`${this.baseUrl}/${this.productRoute}`);
  }
  /** Get: 1 product by productId */
  getProductById(id: number): Observable<IProduct> {
    return this.http.get<IProduct>(
      `${this.baseUrl}/${this.productRoute}/${id}`
    );
  }
  /** Get: all products by categoryId */
  getAllProductsByCategoryId(id: number): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(
      `${this.baseUrl}/${this.productRoute}/GetAllProductByCategoryId/${id}`
    );
  }
  //#endregion

  //#region Product Category methods

  /** Get: all product categories */
  getAllProductCategories(): Observable<ICategory[]> {
    return this.http.get<ICategory[]>(
      `${this.baseUrl}/${this.productCategoryRoute}`
    );
  }
  /** Get: 1 product category by categoryId */
  getProductCategoryById(id: number): Observable<ICategory> {
    return this.http.get<ICategory>(
      `${this.baseUrl}/${this.productCategoryRoute}/${id}`
    );
  }

  //#endregion
}
