using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop-lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMaterial.SelectedIndex = 0;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            double price = 0;
            double width = Convert.ToDouble(textBoxWidth.Text);
            double height = Convert.ToDouble(textBoxHeight.Text);

            //Дерево
            if (radioButtonOneCam.Checked && comboBoxMaterial.SelectedIndex == 0)
            {
                price = width * height * 0.25;
            }

            if (radioButtonTwoCam.Checked && comboBoxMaterial.SelectedIndex == 0)
            {
                price = width * height * 0.3;
            }
            //Метал
            if (radioButtonOneCam.Checked && comboBoxMaterial.SelectedIndex == 1)
            {
                price = width * height * 0.05;

            }

            if (radioButtonTwoCam.Checked && comboBoxMaterial.SelectedIndex == 1)
            {
                price = width * height * 0.1;
            }
            //Металопластик
            if (radioButtonOneCam.Checked && comboBoxMaterial.SelectedIndex == 2)
            {
                price = width * height * 0.15;
            }

            if (radioButtonTwoCam.Checked && comboBoxMaterial.SelectedIndex == 2)
            {
                price = width * height * 0.2;
            }

            if (checkBoxWindowsill.Checked)
            {
                price += 35;
            }

            labelPrice.Text = "ВАРТІСТЬ: " + price + "грн";
        }


    }
}