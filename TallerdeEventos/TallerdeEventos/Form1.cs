using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace TallerdeEventos
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasEnProgreso = new List<Tarea>();
        private List<Tarea> tareasTerminadas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
            comboBox.Items.AddRange(Enum.GetNames(typeof(Estado)));
            comboBox.SelectedIndex = 0;
        }
        public enum Estado
        {
            Pendiente,
            EnProgreso,
            Terminado
        }

        public class Tarea
        {

            public string Descripcion { get; set; }
            public Estado Estado { get; set; }
            public ComboBox comboBox {get ; set; }

            public Tarea(string descripcion, Estado estado)
            {
                Descripcion = descripcion;
                Estado = estado;
            }


            private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lstPendientess.SelectedItem != null)
                {
                    Tarea tarea = (Tarea)lstPendientess.SelectedItem;
                    tarea.Estado = (Estado)Enum.Parse(typeof(Estado), comboBox.SelectedItem.ToString());
                    lstPendientess.Items[lstPendientess.SelectedIndex] = tarea;
                }
                else if (lstProgreso.SelectedItem != null)
                {
                    Tarea tarea = (Tarea)lstProgreso.SelectedItem;
                    tarea.Estado = (Estado)Enum.Parse(typeof(Estado), comboBox.SelectedItem.ToString());
                    lstProgreso.Items[lstProgreso.SelectedIndex] = tarea;
                }
                else if (lstTerminadas.SelectedItem != null)
                {
                    Tarea tarea = (Tarea)lstTerminadas.SelectedItem;
                    tarea.Estado = (Estado)Enum.Parse(typeof(Estado), value: comboBox.SelectedItem.ToString());
                    lstTerminadas.Items[lstTerminadas.SelectedIndex] = tarea;
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text.Trim();
            Estado estado = (Estado)Enum.Parse(typeof(Estado), comboBox.SelectedItem.ToString());

            if (!string.IsNullOrEmpty(descripcion))
            {
                Tarea tarea = new Tarea(descripcion, estado);
                switch (estado)
                {
                    case Estado.Pendiente:
                        tareasPendientes.Add(tarea);
                        lstPendientess.Items.Add(tarea);
                        break;
                    case Estado.EnProgreso:
                        tareasEnProgreso.Add(tarea);
                        lstProgreso.Items.Add(tarea);
                        break;
                    case Estado.Terminado:
                        tareasTerminadas.Add(tarea);
                        lstTerminadas.Items.Add(tarea);
                        break;
                }
                txtDescripcion.Clear();
            }
        }

        private void lstProgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProgreso.SelectedItem != null)
            {
                Tarea tarea = (Tarea)lstProgreso.SelectedItem;
                txtDescripcion.Text = tarea.Descripcion;
                comboBox.SelectedItem = tarea.Estado.ToString();
            }
        }

        private void lstTerminadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTerminadas.SelectedItem != null)
            {
                Tarea tarea = (Tarea)lstTerminadas.SelectedItem;
                txtDescripcion.Text = tarea.Descripcion;
                comboBox.SelectedItem = tarea.Estado.ToString();
            }
        }
    }
}
    

