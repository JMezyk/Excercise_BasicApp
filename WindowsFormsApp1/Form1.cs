using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices.ComTypes;
using System.Text.Json;
using System.Collections.Specialized;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         static int Licznik;
            System.Timers.Timer tTick;
           
     
      
        
        public Form1()
        {
            InitializeComponent();
            SetTimer();
        }

        ~Form1()
        {
            
        }
       
        
        #region HelloWorld
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            tTick = new System.Timers.Timer(200);
            // Hook up the Elapsed event for the timer. 
            tTick.Elapsed += OnTimedEvent;
            tTick.AutoReset = true;
            tTick.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke(
                     new Action(() =>
                     {
                         textBox1.Text = Licznik.ToString();
                         progressBar1.Value += 1;
                         if (progressBar1.Value >= 1000)
                             progressBar1.Value = 0;
                     }));

         }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = new DialogResult();
            dlgRes = System.Windows.Forms.MessageBox.Show("AQQ!","Wiadomość",MessageBoxButtons.OKCancel);

            this.label1.Text = dlgRes.ToString();
            Licznik++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Licznik = 0;
            this.textBox1.Text = Licznik.ToString();
        }
        #endregion

        #region TrayIcon
        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Item 1";
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Item 2";
        }

        private void item3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Item 3";
        }
        #endregion
        
            

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tTick != null)
            {
                tTick.Stop();
                Thread.Sleep(1000);
                tTick.Elapsed -= OnTimedEvent;
            }
        }


       
    }
}
