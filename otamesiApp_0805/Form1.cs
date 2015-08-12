using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otamesiApp_0805
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //GitHub用にコメント修正
            //0812にSourceTreeインスト設定
            if (string.IsNullOrWhiteSpace(txtBoxTest.Text))
            {
                 MessageBox.Show("文字を入力してください ^^;");
                 return;
            }
            labelTest.Text = txtBoxTest.Text;
            this.txtBoxTest.Focus();
        }
    }
}
