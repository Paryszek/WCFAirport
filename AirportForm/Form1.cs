using Airport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportForm
{
    public partial class Form1 : Form
    {
        AirportService service;
        public Form1()
        {
            InitializeComponent();
            service = new AirportService();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (airportA.Text.Equals("") || airportB.Text.Equals(""))
            {
                connections.Text = service.GetEveryConnection();
            } else if (airportA.Text.Length > 0 && airportB.Text.Length > 0)
            {
                connections.Text = service.GetConnectionBetween(airportA.Text, airportB.Text);
            } 
        }
    }
}
