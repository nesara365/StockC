using System;

namespace Stock_Csharp
{
    public class Stock
    {
        private string stockCode;
        private string stockName;
        private int stockQuantity;
        private DateTime stockDate;

        public Stock(string code, string name, int quantity)
        {
            stockCode = code;
            stockName = name;
            stockQuantity = quantity;
            stockDate = DateTime.Now;
        }

        public string GetStockCode()
        {
            return stockCode;
        }

        public void SetStockCode(string code)
        {
            stockCode = code;
        }

        public string GetStockName()
        {
            return stockName;
        }

        public void SetStockName(string name)
        {
            stockName = name;
        }

        public int GetStockQuantity()
        {
            return stockQuantity;
        }

        public void SetStockQuantity(int quantity)
        {
            stockQuantity = quantity;
        }

        public DateTime GetStockDate()
        {
            return stockDate;
        }

        public void SetStockDate(DateTime date)
        {
            stockDate = date;
        }
    }
}
