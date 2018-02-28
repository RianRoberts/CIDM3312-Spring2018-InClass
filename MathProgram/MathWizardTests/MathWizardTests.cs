using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MathWizard.Controllers;
using MathWizard.Models;

namespace MathWizardTests
{
    public class MathWizardTests
    {

        private MathController controller = new MathController();

        [Fact]
        public void TestAddition()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 30;
            op.RightOperand = 30;
            op.Operator = "Plus";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(59, model.Result);

        }

        [Fact]
        public void TestDivision()
        {
            //Arrange
            MathOp op = new MathOp();
            op.LeftOperand = 60;
            op.RightOperand = 25;
            op.Operator = "Divided By";
            op.Result = 0;
            
            //Act
            ViewResult vr = (ViewResult)controller.DoMathOp(op);
            MathOp model = (MathOp)vr.Model;

            //Assert
            Assert.Equal(2.4, Math.Round(model.Result, 1));

        }

    }
}
