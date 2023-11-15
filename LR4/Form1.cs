﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Room new_person;
                new_person = new Room(Convert.ToDouble(LengthBox.Text));
                ResultBox.Text += new_person.GetInformation();
                ResultBox.Text += Environment.NewLine;
            } catch (Exception ex) { MessageBox.Show("Ошибка формата данных. Убедитесь, что все поля содержат числа или корректные названия!"); }
        }

    }
}
