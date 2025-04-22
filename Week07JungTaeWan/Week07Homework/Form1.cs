using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Week07Homework
{
    public partial class Form1: Form
    {
        List<Product> product;

        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(tbxInputProductName.Text))
            {
                MessageBox.Show("상품 이름을 입력하세요");
                tbxInputProductName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxInputProductPrice.Text))
            {
                MessageBox.Show("상품 가격을 입력하세요");
                tbxInputProductPrice.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxInputProcuctStock.Text))
            {
                MessageBox.Show("상품 재고를 입력하세요");
                tbxInputProcuctStock.Focus();
                return;
            }

            var random = new Random();
            string sum;
            bool TOF;
            do
            {

                // 오늘 날짜 및 + 랜덤 숫자 추가
                string datePart = DateTime.Now.ToString("yyyyMMdd");
                string randomPart = random.Next(1000).ToString("D3");
                sum = datePart + randomPart;
                //yyyy, MM, dd, HH, mm, ss, fff
                TOF = false;

                foreach (Product p in product)
                {
                    if (p.ProductCode == sum)
                    {
                        TOF = true;
                        break;
                    }
                }
            } while (TOF);


            DateTime Regret = DateTime.Now.AddDays(-(new Random()).Next(20, 100));

            // 새 상품 객체 생성

            Product prod = new Product
            {
                ProductName = tbxInputProductName.Text.Trim(),
                ProductCode = sum,
                ProductPrice = int.Parse(tbxInputProductPrice.Text.Trim()),
                ProductStock = int.Parse(tbxInputProcuctStock.Text.Trim()),
                Regret = Regret
            };

            product.Add(prod);
            MessageBox.Show("등록완료");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearchNameCode.Text == null)
            {
                MessageBox.Show("이름을 입력하세요");
            }
            productSearchClear();
            lbxSearchProduct.Items.Clear();
            for (int i = 0; i< product.Count; i++)
            {
                
                if (product[i].ProductName.Contains(tbxSearchNameCode.Text))
                {
                    lbxSearchProduct.Items.Add(product[i].ToString());
                }
            }
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSearchProduct.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                lblSearchProductName.Text = product[lbxSearchProduct.SelectedIndex].ProductName;
                lblSearchProductCode.Text = product[lbxSearchProduct.SelectedIndex].ProductCode;
                lblSearchProductPrice.Text = product[lbxSearchProduct.SelectedIndex].ProductPrice.ToString();
                lblSearchProductSalePrice.Text = product[lbxSearchProduct.SelectedIndex].SalePrice().ToString();
                lblSearchProductStock.Text = product[lbxSearchProduct.SelectedIndex].ProductStock.ToString();
                lblSearchProductRegDate.Text = product[lbxSearchProduct.SelectedIndex].Regret.ToString("yyyy-MM-dd");
            }
        }

        private void productSearchClear()
        {
            lblSearchProductName.Text = null;
            lblSearchProductCode.Text = null;
            lblSearchProductPrice.Text = null;
            lblSearchProductSalePrice.Text = null;
            lblSearchProductStock.Text = null;
            lblSearchProductRegDate.Text = null;
            lblSearchProductTotalPrice.Text = null;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblSearchProductTotalPrice.Text = product[lbxSearchProduct.SelectedIndex].CalPrice(int.Parse(tbxSearchProcuctCount.Text)).ToString();
        }
    }
}
