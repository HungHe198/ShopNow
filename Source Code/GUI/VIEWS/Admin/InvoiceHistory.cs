﻿using ShopNow.Source_Code.BUS.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    public partial class InvoiceHistory : Form
    {
        public InvoiceHistory()
        {
            InitializeComponent();
        }

        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);

        }


    }
}
