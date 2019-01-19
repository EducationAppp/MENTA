﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class Form1 : Form
    {
        public static SalesControl sale;
        public static MasterControl mente;

        public Form1()
        {
            InitializeComponent();
            //static変数に格納
            sale = new SalesControl();
            mente = new MasterControl();

            //パネルにSalesControl.cs,MasterControl.csを追加
            panel.Controls.Add(sale);
            panel.Controls.Add(mente);

            //メンテナンス画面のみ表示
            mente.Visible = true;
            sale.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
