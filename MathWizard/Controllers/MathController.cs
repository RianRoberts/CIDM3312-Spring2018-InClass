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
            MathOperation operation = new MathOperation();
            return View(operation);
        }

        [HttpPost]
        public IActionResult DoCalculation(MathOperation operation)
        {

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
                    operation = new MathOperation();
                    operation.LeftOperand = 999;
                    operation.LeftOperand = 999;
                    operation.Operator = "Add";
                    operation.Result = 0;
                    break;
                
            }

            return View(operation);
        }
    }
}