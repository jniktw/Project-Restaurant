import { useEffect, useState } from "react";
import { myFetch } from "../neew";
import * as React from 'react';
import '../Component_CSS/Product.css';
// export default function ListProduct({}) {
//   const [products,setProducts] = useState([]);
//   useEffect(()=>{
//     async function fetchProductList(){
//       const data = await myFetch("https://localhost:7117/ProductList");
//       console.log(data);
//       setProducts(data);
//     }
//     fetchProductList();
//   },[])
//     return (
//       <div>
//       <h1>GROCERY LIST GENERATOR</h1>
//     <>
//       {

        
//         products.map((product) => {
//          return (
//           <div> 
//             <li key={product.id}>{product.productName} --- {product.actualNumber}[{product.unit}]</li>
//           </div>
//         )
//         })


//       } 


//     </>
//       </div>);
// }


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
      <h1>GROCERY LIST GENERATOR</h1>
    <>
      {
        
        products.map((product) => {
         return (

    <div className="App">
      <table>
        <tr>
          <th>Id</th>
          <th>Nazwa</th>
          <th>Aktualna ilość</th>
        </tr>
        <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.productName}</td>
              <td>{product.actualNumber}</td>
        </tr>       
      </table>
    </div>
        )
        
      })
      } 


    </>
      </div>);
}





  
