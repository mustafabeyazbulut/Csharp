using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using EasyModbus;

namespace TCP_Haberlerşme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Client tanımlama
                ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
                //                
                //Bağlan
                tcpclient.Connect();
                //
                //okuma
                //
                
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
                int d = Convert.ToInt32(textBox5.Text);
               
                //
                //okuma
                //
                bool[] mb = tcpclient.ReadCoils(a-1, 1);                      
                int [] mw = tcpclient.ReadHoldingRegisters((b-1), 1);
                int[] mi = tcpclient.ReadHoldingRegisters((c-1), 2);
                int[] mf = tcpclient.ReadHoldingRegisters((d-1), 2);
                //
                double mii = ModbusClient.ConvertRegistersToDouble(mi);
                //
                float mff = ModbusClient.ConvertRegistersToFloat(mf);





                //   
                //labela yazma
                //
                label7.Text = Convert.ToString(mb[0]);
                label8.Text = Convert.ToString(mw[0]);
                label12.Text = Convert.ToString(mii);
                label13.Text = Convert.ToString(mff);
               
                
            }
            //
            //hata yakalama
            catch (Exception)
            { timer1.Stop(); MessageBox.Show("Hata"); }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //okuma offset girdileri lock
           // textBox2.Enabled = false;
           // textBox3.Enabled = false;
            //textBox4.Enabled = false;
            //textBox5.Enabled = false;
            //textBox6.Enabled = false;
            //textBox14.Enabled = false;

            //yazma değerleri unlock
            comboBox1.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;

            //yazma butonları unlock
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

            //yazma offsetleri unlock
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;            
            
            //timer on
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //okuma offset girdileri unlock
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            //textBox6.Enabled = true;
            //textBox14.Enabled = true;

            //yazma değerleri lock
            comboBox1.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            //yazma butonları lock
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            //yazma offsetleri lock
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            
            //timer off
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mb yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            bool bitvalue = false;
            //
            if (comboBox1.Text == "True") bitvalue = true;
            if (comboBox1.Text == "False") bitvalue = false;
            //
            int aa = Convert.ToInt32(textBox10.Text);

            tcpclient.WriteSingleCoil((aa-1), bitvalue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mw yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int bb = Convert.ToInt32(textBox11.Text);

            tcpclient.WriteSingleRegister(bb-1, Convert.ToInt32(textBox7.Text));

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mi yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int cc = Convert.ToInt32(textBox12.Text);
           
            int[] mideger = ModbusClient.ConvertDoubleToTwoRegisters(Convert.ToInt32(textBox8.Text));

            tcpclient.WriteMultipleRegisters(cc - 1, mideger);

            //tcpclient.WriteSingleRegister(cc-1, mideger[0]);
            //tcpclient.WriteSingleRegister(cc-1, mideger[1]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //mf yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int dd = Convert.ToInt32(textBox13.Text);

            float mff = float.Parse(textBox9.Text);

            int[] mfdeger = ModbusClient.ConvertFloatToTwoRegisters(mff);

            tcpclient.WriteMultipleRegisters(dd - 1, mfdeger);
            //tcpclient.WriteSingleRegister(dd, mfdeger[0]);
            //tcpclient.WriteSingleRegister(dd, mfdeger[1]);
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            
        }
    }     
       
       
}

