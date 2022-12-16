import { useEffect, useState } from "react";
import { myFetch } from "../neew";
import * as React from 'react';
import '../Component_CSS/Product.css';
import Modal from './modal'


export default class ListProduct extends React.Component  {
  state = {
    show: false
  };

  showModal = e => {
    this.setState({
      show: !this.state.show
    });
  };

  // setProducts() {
  //   async function fetchProductList(){
  //     const data = await myFetch("https://localhost:7117/ProductList");
  //     console.log(data);
  //     this.products = data;
  //   }
  //   fetchProductList();
  // }



  constructor(props) {
    super(props);
    this.products = [
      {
        "id": 2,
        "productName": "maliny",
        "actualNumber": 1,
        "requiredNumber": 0,
        "unit": "kg"
      },
      {
        "id": 3,
        "productName": "jajka",
        "actualNumber": 5,
        "requiredNumber": 30,
        "unit": "szt"
      },
      {
        "id": 4,
        "productName": "cukier",
        "actualNumber": 0,
        "requiredNumber": 10,
        "unit": "kg"
      },
      {
        "id": 5,
        "productName": "string",
        "actualNumber": 0,
        "requiredNumber": 0,
        "unit": "string"
      }
    ];
  }

  render() {
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
        
        this.products.map((product) => {
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
        <button onClick={e => {this.showModal(e);}}>Add items</button>
        <a href="#">Remove items</a>
        <a href="#">Update items</a>
      </div>

    </div>
      <Modal onClose={this.showModal} show={this.state.show}>
      <EmployeeComponent></EmployeeComponent>
      </Modal>
    </div>
    );
  }
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