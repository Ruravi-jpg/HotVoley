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
    public partial class Form1 : Form
    {
		private string part_fecha_actual, part_id_actual;
		private ConexionPgsql conexion = new ConexionPgsql();

        public Form1()
        {
            InitializeComponent();

			pictureBoxBackground.Image = Image.FromFile("../images/beachGame.jpg");//Los 2 puntos consecutivos indican la carpeta actual, la cual es la carpeta bin dentro de nuestro proyecto.
			pictureBoxVs.Image = Image.FromFile("../images/vs.png");
			pictureBoxLogo1.Image = Image.FromFile("../images/escudos/Blanco.png");
			pictureBoxLogo2.Image = Image.FromFile("../images/escudos/Negro.png");

			pictureBoxVs.Parent = pictureBoxBackground;//No basta con poner el color de fondo transparente, si quiero que se vea el pictureBoxBackground debo hacerlo su padre.
			pictureBoxVs.BackColor = Color.Transparent;
			pictureBoxLogo1.Parent = pictureBoxBackground;
			pictureBoxLogo1.BackColor = Color.Transparent;
			pictureBoxLogo2.Parent = pictureBoxBackground;
			pictureBoxLogo2.BackColor = Color.Transparent;

			labelTrainer1.Parent = pictureBoxBackground;
			labelTrainer1.BackColor = Color.Transparent;
			labelTrainer2.Parent = pictureBoxBackground;
			labelTrainer2.BackColor = Color.Transparent;
			labelPlayers1.Parent = pictureBoxBackground;
			labelPlayers1.BackColor = Color.Transparent;
			labelPlayers2.Parent = pictureBoxBackground;
			labelPlayers2.BackColor = Color.Transparent;

			labelInfo.BackColor = Color.White;
			labelScoreboard.BackColor = Color.White;

			part_id_actual = conexion.Consultar("Partido", "part_id", "part_id != 0 ORDER BY part_fecha, part_hinicio");
			if (part_id_actual != "null")
            {				
				part_fecha_actual = conexion.Consultar("Partido", "part_fecha", "part_id = " + part_id_actual);
				UpdateData(part_id_actual);
			}
            else
            {
				MessageBox.Show("No hay partidos disponibles.", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				buttonReturn.Enabled = false;
				buttonGoForward.Enabled = false;
			}
		}

		void UpdateData(string part_id)
        {
			string eq1_nombre, eq2_nombre, result, jug_id_aux, hora_aux = "00:00:00";
			int cont1 = 0, cont2 = 0;

			labelInfo.Text  = "Fecha: " + conexion.Consultar("Partido", "part_fecha", "part_id = " + part_id);
			labelInfo.Text += System.Environment.NewLine;
			labelInfo.Text += "Playa: " + conexion.Consultar("Partido", "part_playa", "part_id = " + part_id);

			eq1_nombre = conexion.Consultar("Partido", "part_eq1_nombre", "part_id = " + part_id);
			labelTrainer1.Text  = "DT: " + conexion.Consultar("Entrenador", "entr_nombre", "entr_eq_nombre = '" + eq1_nombre + "'");
			labelPlayers1.Text  = "Izq: " + conexion.Consultar("Jugador", "jug_nombre", "jug_eq_nombre = '" + eq1_nombre + "' AND jug_posicion = 'I'");
			labelPlayers1.Text += System.Environment.NewLine;
			labelPlayers1.Text += "Der: " + conexion.Consultar("Jugador", "jug_nombre", "jug_eq_nombre = '" + eq1_nombre + "' AND jug_posicion = 'D'");

			eq2_nombre = conexion.Consultar("Partido", "part_eq2_nombre", "part_id = " + part_id);
			labelTrainer2.Text = "DT: " + conexion.Consultar("Entrenador", "entr_nombre", "entr_eq_nombre = '" + eq2_nombre + "'");
			labelPlayers2.Text = "Izq: " + conexion.Consultar("Jugador", "jug_nombre", "jug_eq_nombre = '" + eq2_nombre + "' AND jug_posicion = 'I'");
			labelPlayers2.Text += System.Environment.NewLine;
			labelPlayers2.Text += "Der: " + conexion.Consultar("Jugador", "jug_nombre", "jug_eq_nombre = '" + eq2_nombre + "' AND jug_posicion = 'D'");

			result = "Anotaciones: " + System.Environment.NewLine;
			while (true)
			{
				jug_id_aux = conexion.Consultar("Anotacion", "an_jug_id", "an_part_id = " + part_id + " AND an_hora > '" + hora_aux + "' ORDER BY an_hora");
                if (jug_id_aux == "null")//Si ya no hay más anotaciones...
                {
					break;//salimos del while.
                }

				hora_aux = conexion.Consultar("Anotacion", "an_hora", "an_part_id = " + part_id + " AND an_hora > '" + hora_aux + "' ORDER BY an_hora");

				if (eq1_nombre == conexion.Consultar("Jugador", "jug_eq_nombre", "jug_id = " + jug_id_aux))
				{
					++cont1;
				}
				else
				{
					++cont2;
				}

				result += hora_aux + " - " + conexion.Consultar("Jugador", "jug_nombre", "jug_id = " + jug_id_aux);
				result += System.Environment.NewLine;
			}

			if(cont1 > cont2)
            {
				labelScoreboard.Text = "Ganador: " + eq1_nombre + System.Environment.NewLine
					+ "Marcador: " + cont1.ToString() + "-" + cont2.ToString();
			}
            else if(cont1 < cont2)
            {
				labelScoreboard.Text = "Ganador: " + eq2_nombre + System.Environment.NewLine
					+ "Marcador: " + cont2.ToString() + "-" + cont1.ToString();
			}
			else//(cont1 == cont2)
			{
				labelScoreboard.Text = "Ganador: EMPATE" + System.Environment.NewLine
					+ "Marcador: " + cont2.ToString() + "-" + cont1.ToString();
			}
			labelScoreboard.Text += System.Environment.NewLine + System.Environment.NewLine + result;//Ahora si agregamos la lista de anotaciones alojada en result.
		}

        private void buttonReturn_Click(object sender, EventArgs e)
        {
			string part_id_aux = conexion.Consultar("Partido", "part_id", "part_fecha <= '" + part_fecha_actual + "' AND part_id != " + part_id_actual + " ORDER BY part_fecha DESC, part_hinicio DESC");

			if (part_id_aux == "null")
            {
				MessageBox.Show("Llegaste al principio de la lista.");
				return;
            }

			UpdateData(part_id_aux);
			part_id_actual = part_id_aux;
			part_fecha_actual = conexion.Consultar("Partido", "part_fecha", "part_id = " + part_id_aux);
		}

        private void buttonGoForward_Click(object sender, EventArgs e)
        {
			string part_id_aux = conexion.Consultar("Partido", "part_id", "part_fecha >= '" + part_fecha_actual + "' AND part_id != " + part_id_actual + " ORDER BY part_fecha, part_hinicio");

			if (part_id_aux == "null")
			{
				MessageBox.Show("Llegaste al final de la lista.");
				return;
			}

			UpdateData(part_id_aux);
			part_id_actual = part_id_aux;
			part_fecha_actual = conexion.Consultar("Partido", "part_fecha", "part_id = " + part_id_aux);
		}

		private void buttonIndex_Click(object sender, EventArgs e)
		{
			FormIndex myIndex = new FormIndex(conexion);//Creo una nueva ventana de tipo FormIndex.

			if (myIndex.ShowDialog() == DialogResult.OK)//Hacemos que la ventana myIndex entre en un estado orientado a eventos, y en el momento en el que marque el estatus OK...
			{
				part_id_actual = myIndex.part_id;//guardamos su variable pública part_id
			}
			UpdateData(part_id_actual);
			part_fecha_actual = conexion.Consultar("Partido", "part_fecha", "part_id = " + part_id_actual);
		}
	}
}