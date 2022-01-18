using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // allows for socket programming 


namespace IP_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            try // try and cath methods 
            {
                
                string name = textBox1.Text; // sets a variable to the value the user types in 
                IPHostEntry address = Dns.GetHostEntry(name); // takes the name of the domain and finds the address 
                IPAddress[] ip = address.AddressList; // turns the IP address into byte data 
                string addrss = ip[0].ToString(); // turns the byte into a string (readable text)
                Console.WriteLine("the IP address for the website you entered is\t " + addrss); // displays the IP address 
                Console.ReadLine(); // allows your to read the result before closing 
                richTextBox1.Text = ("The IP address of the site you entered is\t " + name + "\t" + addrss);
            }
            catch (Exception ex) // method to capture the exception and write it to the console if any thing was to go wrong 
            {
                Console.WriteLine(ex); //writes the error
              
            }
        }
    }
}
