import { useEffect, useState } from "react";
import { myFetch } from "../neew";

export default function ListProduct({}) {
  const [products,setProducts] = useState([]);
  useEffect(()=>{
    async function fetchProductList(){
      const data = await myFetch("https://localhost:7117/ProductList");
      console.log(data);
      setProducts(data);
    }
    fetchProductList();
  },[])
    return (
      <div>
      <p>Nazwa produktu --- Aktualna ilość[jednostka]</p>
    <>
      {
        
        products.map((product) => {
         return (
          <div> 
            <li key={product.id}>{product.productName} --- {product.actualNumber}[{product.unit}]</li>
          </div>
        )
        })
      }
    </>
      </div>);
}





  
