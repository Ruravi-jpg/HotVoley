using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotVoley
{
    public partial class FormIndex : Form
    {
        public string part_id = "";

        public FormIndex(ConexionPgsql conexion)
        {
            InitializeComponent();

			pictureBoxBackground.Image = Image.FromFile("../images/beachCourt.jpg");
			pictureBoxTitle.Image = Image.FromFile("../images/hotVoley_logo.PNG");

			pictureBoxTitle.Parent = pictureBoxBackground;
			pictureBoxTitle.BackColor = Color.Transparent;

            string part_fecha_aux = "2000-01-01", part_id_aux = "0", mystr;
            DateTime realDate = DateTime.Parse(part_fecha_aux); //convertir la fecha al formato que postgres quiere
            part_fecha_aux = realDate.ToString("yyyy-MM-dd");
            while (true)
            {
                mystr  = conexion.Consultar("Partido", "part_id", "part_fecha >= '" + part_fecha_aux + "' AND part_id != " + part_id_aux + " ORDER BY part_fecha");
                if (mystr == "null")
                {
                    break;
                }

                part_id_aux = mystr;
                part_fecha_aux = conexion.Consultar("Partido", "part_fecha", "part_id = " + mystr);

                realDate = DateTime.Parse(part_fecha_aux); //convertir la fecha al formato que postgres quiere
                part_fecha_aux = realDate.ToString("yyyy-MM-dd");

                listBoxMatches.Items.Add(part_id_aux + ") " + part_fecha_aux);
            }
		}

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mystr = listBoxMatches.SelectedItem.ToString();

            for (int i = 0; mystr[i] != ')'; i++)
            {
                part_id += mystr[i];
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
