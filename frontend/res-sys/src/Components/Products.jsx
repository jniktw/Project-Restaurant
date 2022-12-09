import { useEffect, useState } from "react";
import { myFetch } from "../neew";
import * as React from 'react';
import '../Component_CSS/Product.css';

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
        <style>
          @import url('https://fonts.googleapis.com/css2?family=PT+Serif&display=swap');
        </style>

      <h1>GROCERY LIST GENERATOR</h1>
      <div className="App">
      <table>
        <tr>
          <th>Item</th>
          <th>Actual number</th>
          <th>Required number</th>
          <th>Unit</th>
        </tr>  
    <>
      {
        
        products.map((product) => {
         return (
          <tr key={product.id}>
          <td>{product.productName}</td>
          <td>{product.actualNumber}</td>
          <td>{product.requiredNumber}</td>
          <td>{product.unit}</td>
          </tr>    
        )
      })
      } 
    </>
    </table>
      <div className="Buttons">
        <a href="#">Add items</a>
        <a href="#">Remove items</a>
        <a href="#">Update items</a>
      </div>

    </div>
    </div>
    );

    }



  
