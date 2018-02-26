using System;
using Microsoft.AspNetCore.Mvc;

using MathWizard.Models;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Wizard(){
            //MathOperation operation = new MathOperation();
            return View();
        }

        [HttpPost]
        public IActionResult DoCalculation(MathOperation operation)
        {

            if(operation == null)
            {
                return View("Error");
            }else{
                switch(operation.Operator){
                    case "Add":
                        operation.Result = 
                        operation.LeftOperand + operation.RightOperand;
                        break;
                    
                    case "Subtract":
                        operation.Result = 
                        operation.LeftOperand - operation.RightOperand;                
                        break;

                    case "Multiply":
                        operation.Result = 
                        operation.LeftOperand * operation.RightOperand;                
                        break;
                    
                    case "Divide":
                        operation.Result = 
                        operation.LeftOperand / operation.RightOperand;                
                        break;

                    case "Modulus":
                        operation.Result = 
                        operation.LeftOperand % operation.RightOperand;                
                        break;

                    default:
                        MathOperation op = new MathOperation();
                        op.LeftOperand = operation.LeftOperand;
                        op.LeftOperand = operation.RightOperand;
                        op.Operator = operation.Operator;
                        op.Result = 0;
                        return View(op);
                        //break;
                        
                    
                }
            }
            return View(operation);
        }
    }
}