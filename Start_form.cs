﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Start_form: System.Windows.Forms.Form
    {
        public Start_form()
        {
            BackColor = Color.FromArgb(255, 169, 169, 169);
            this.ClientSize = new System.Drawing.Size(1360, 800);
            Button Start_btn = new Button
            {
                BackColor = Color.FromArgb(225,33,33,33),
                Text = "Minu oma aken",
                Location = new System.Drawing.Point(10, 10),
                ForeColor = Color.FromArgb(255, 255, 255, 255),
                Size = new Size(100, 50)
                
            };
            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);
            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(10, 60),
                Size = new Size(100, 50)
            };
            this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;
        }

        private void Start_btn_2_Click(object sender, EventArgs e)
        {
           
            MyForm uus_aken = new MyForm(8,5);
            
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Mina olen ilus aken","Vali midagi","Üks","Kaks","Kolm","Neli");
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
