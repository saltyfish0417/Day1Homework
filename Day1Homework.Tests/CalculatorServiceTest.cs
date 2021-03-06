using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class CalculatorTest
{
    [TestMethod()]
    public void SumTest_column_price_grout_3_()
    {
        //arrange
        var target = new Calculator();
        List<Products> Prod = GetProductList();
        string Calculator_Col = "Price";  //欲加總欄位
        int Calculator_Group = 3; ;       //欲加總之分組個數
        var expected = new ArrayList() {6000, 15000, 24000, 21000};

        //act
        var actual = target.GetSumByGroup(Prod, Calculator_Col, Calculator_Group);

        //assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void SumTets_column_cost_grout_4_()   
    {
        //arrange
        var target = new Calculator();
        List<Products> Prod = GetProductList();
        string Calculator_Col = "Cost";  //欲加總欄位
        int Calculator_Group = 4; ;      //欲加總之分組個數
        var expected = new ArrayList() {8000, 24000, 28500};

        //act
        var actual = target.GetSumByGroup(Prod, Calculator_Col, Calculator_Group);

        //assert
        CollectionAssert.AreEqual(expected, actual);
    }

    internal struct Products
    {
        public string GoodID { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public int DiscountAmount { get; set; }
    }

    internal List<Products> GetProductList()
    {
        return new List<Products>()
        {
            new Products {GoodID = "A0001",Price = 1000,Cost = 500,DiscountAmount = 700},
            new Products {GoodID = "A0002",Price = 2000,Cost = 1500,DiscountAmount = 1700},
            new Products {GoodID = "A0003",Price = 3000,Cost = 2500,DiscountAmount = 2700},
            new Products {GoodID = "A0004",Price = 4000,Cost = 3500,DiscountAmount = 3700},
            new Products {GoodID = "A0005",Price = 5000,Cost = 4500,DiscountAmount = 4700},
            new Products {GoodID = "A0006",Price = 6000,Cost = 5500,DiscountAmount = 5700},
            new Products {GoodID = "A0007",Price = 7000,Cost = 6500,DiscountAmount = 6700},
            new Products {GoodID = "A0008",Price = 8000,Cost = 7500,DiscountAmount = 7700},
            new Products {GoodID = "A0009",Price = 9000,Cost = 8500,DiscountAmount = 8700},
            new Products {GoodID = "A0010",Price = 10000,Cost = 9500,DiscountAmount = 9700},
            new Products {GoodID = "A0011",Price = 11000,Cost = 10500,DiscountAmount = 10700}
        };
    }
}
