﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.IO;
using System.Data.OleDb;

namespace Excel연동
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"PROVIDER=MICROSOFT.ACE.OLEDB.12.0;Data Source='C:\Users\shims\Documents\강의실 통합.xlsx'; Extended Properties = 'Excel 12.0; HDR=yes';");
            OleDbDataAdapter cmd = new OleDbDataAdapter("Select * from [Sheet1$]", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            con.Close();

        }
    }
}
