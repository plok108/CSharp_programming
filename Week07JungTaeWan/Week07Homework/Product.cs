using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07Homework
{
    class Product
    {
        public string ProductName;
        public string ProductCode;
        public int ProductPrice;
        public int ProductStock;
        public DateTime Regret;

        public override string ToString()
        {
            return $"[{ProductCode}]{ProductName}"; // $  = f포멧팅 방법임
        }

        public int SalePrice()
        {
            //현재날짜가 상품등록일보다 30일 이후라면 20 % 할인된 가격을 반환, 그렇지 않으면 등록한 가격을 반환
            
        
            TimeSpan diff = DateTime.Now - Regret;
            var totaldays = diff.TotalDays;
            if (totaldays > 30)
            {
                return (int)(ProductPrice * 0.8);
            }
            else
                return ProductPrice;
        }
        
        public int CalPrice(int count)
        {
            // 개수(count)에 상품가격(혹은 할인가격) 을 곱해서 반환한다.
            return SalePrice() * count;
        }
    }
}
