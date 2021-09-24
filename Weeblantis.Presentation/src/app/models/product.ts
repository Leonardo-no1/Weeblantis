export interface IProduct {
  id: number;
  name: string;
  description: string;
  sku: string;
  price: number;
  productInventory: number;
  productCategoryId: number;
  discountId: null;
  imageBase64: string;
}
