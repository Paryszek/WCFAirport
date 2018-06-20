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
            if (airportA.Text.Length == 0 || airportB.Text.Length == 0 || dateTimePicker.Text.Length == 0 || time.Text.Length == 0)
            {
                connections.Text = service.GetEveryConnection();
            } else if (airportA.Text.Length > 0 && airportB.Text.Length > 0 && dateTimePicker.Text.Length > 0 && time.Text.Length > 0 && time.Text.Contains(":"))
            {
                connections.Text = service.GetConnectionBetween(airportA.Text.ToLower(), airportB.Text.ToLower(), CreateDateFromStringAndTime(dateTimePicker.Value.ToShortDateString(), time.Text));
            } else {
                throw new WrongUserInput();
            }
        }

        private DateTime CreateDateFromStringAndTime(string d, string t)
        {
            var data = t.Split(':');
            DateTime dt = DateTime.Parse(d);
            TimeSpan ts = new TimeSpan(Int32.Parse(data[0]), Int32.Parse(data[1]), 0);
            dt = dt.Date + ts;
            return dt;
        }

    }

    public class WrongUserInput : Exception {
        public override string ToString() {
            return Message;
        }

        public override string Message => "The form got wrong imputs";
    }
}
