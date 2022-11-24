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
    return (<>
      {
        products.map((product) => {
         return (<div key={product.id}>{product.productName}</div>)
        })

      }
    </>);
}





  
