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
        <button onClick={callComp}>Add items</button>
        <a href="#">Remove items</a>
        <a href="#">Update items</a>
      </div>

    </div>
    </div>
    );

    }
    

    class EmployeeComponent extends React.Component {
      constructor(props) {
          super(props);
          this.state = {
            message: ""
          };
        }

        render(){
          return(
            <div classname = "addForm">
            <h2>Please Enter Product Details...</h2>
            <p>
              <label>Product Name : <input type="text" ref="ProductName"></input></label>
            </p>
            <p>
              <label>Product Actual Number : <input type="number" ref="ActualNumber"></input></label>
            </p>
            <p>
              <label>Product Required Number : <input type="number" ref="RequiredNumber"></input></label>
            </p>
            <p>
              <label>Product Unit : <input type="text" ref="Unit"></input></label>
            </p>
              <button onClick={this.onCreateEmployee}>Create</button>
              </div>
          )
        }

        onCreateEmployee=()=>{
          let empInfo={
            ProductName:this.refs.ProductName.value,
            ActualNumber:this.refs.ActualNumber.value,
            RequiredNumber:this.refs.RequiredNumber.value,
            Unit:this.refs.Unit.value
          
              };
              fetch('https://localhost:7117/ProductList',{
      method: 'POST',
      headers:{'Content-type':'application/json'},
        body: empInfo
    }).then(r=>r.json()).then(res=>{
      if(res){
        this.setState({message:'New Employee is Created Successfully'});
      }
    });
          }



      }

      function callComp(){
        const element = <EmployeeComponent></EmployeeComponent>
        return element;
      }
      
    
  //   class EmployeeComponent extends React.Component {
  //     constructor(props) {
  //         super(props);
  //         this.state = {
  //           message: ""
  //         };
  //       }
      

  // render(){
  //       return(
          // <div classname = "addForm">
          //   <h2>Please Enter Product Details...</h2>
          //   <p>
          //     <label>Product Name : <input type="text" ref="ProductName"></input></label>
          //   </p>
          //   <p>
          //     <label>Product Actual Number : <input type="number" ref="ActualNumber"></input></label>
          //   </p>
          //   <p>
          //     <label>Product Required Number : <input type="number" ref="RequiredNumber"></input></label>
          //   </p>
          //   <p>
          //     <label>Product Unit : <input type="text" ref="Unit"></input></label>
          //   </p>
  //           {<button onClick={onCreateEmployee(ref)}>Create</button> }
  //         </div>
  //       )
  //   }
    
  // function onCreateEmployee(ref){
  //   let product={
          // ProductName:ref.ProductName.value,
          // ActualNumber:ref.ActualNumber.value,
          // RequiredNumber:ref.RequiredNumber.value,
          // Unit:ref.Unit.value
  //       };
  //     fetch('https://localhost:7117/ProductList',{
  //     method: 'POST',
  //     headers:{'Content-type':'application/json'},
  //     body: product
  //   });
  // }
  //   }