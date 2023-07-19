using PersonaForm.ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaForm
{
    public partial class PersonForm : Form
    {
     
        List<Persona> listaPersona;
        private int cont = 0;
        public PersonForm()
        {
            InitializeComponent();
           
            listaPersona = new List<Persona>();
        }

        private void Guardarbutton2_Click(object sender, EventArgs e)
        {

            if (!Validar()) //verifico que todo los campos esten llenos
                return;
           
            MyerrorProvider1.Clear(); //Limpio el errorProvider para que no se vean errores en pantalla
            
            //Pasamos a cargar la clase 
            Persona person = new Persona();
            person = LlenaClase();

            try
            {
                listaPersona.Add(person);
                cont++;
                MessageBox.Show("Guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpios los campos en pantalla
                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
               
            }

        }

        private Persona LlenaClase()
        {
            Persona p = new Persona();

            p.Id = cont;
            p.Nombre = NombretextBox1.Text;
            p.Direccion = DirecciontextBox2.Text;
            p.Telefono = telefonomaskedTextBox1.Text;
            p.Sueldo = SueldotextBox1.Text;
            p.Fecha = dateTimePicker1.Value;

            return p;
        }

        private void LlenaCampos (Persona p)
        {
            IDnumericUpDown1.Value = Convert.ToInt32(p.Id);
            NombretextBox1.Text = p.Nombre;
            DirecciontextBox2.Text = p.Direccion;
            telefonomaskedTextBox1.Text = p.Telefono;
            SueldotextBox1.Text = p.Sueldo.ToString();
            dateTimePicker1.Value = p.Fecha;
        }

        private void LimpiarCampos()
        {
            MyerrorProvider1.Clear();
            IDnumericUpDown1.Value = 0;
            NombretextBox1.Text = String.Empty;
            DirecciontextBox2.Text = String.Empty;
            telefonomaskedTextBox1.Text = String.Empty;
            SueldotextBox1.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider1.Clear();

            if (Convert.ToInt32(IDnumericUpDown1.Value) > 0)
            {
                MyerrorProvider1.SetError(IDnumericUpDown1, "Este campo debe ser 0 para poder guardar el registro.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombretextBox1.Text))
            {
                MyerrorProvider1.SetError(NombretextBox1, "Este campo no puede estar vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox2.Text))
            {
                MyerrorProvider1.SetError(DirecciontextBox2, "Este campo no puede estar vacio");
                paso = false;
            }

            if (telefonomaskedTextBox1.Text.Count() < 10)
            {
                MyerrorProvider1.SetError(telefonomaskedTextBox1, "Este campo debe ser llenado con 10 digitos.");
                paso = false;
            }

            return paso; 
        }

        private void Cancelarbutton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Buscarbutton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown1.Value);
           
            try
            {

                var list = listaPersona.Where(p => p.Id == id).ToList();

                foreach (var item in list)
                {
                    if(item.Id == id)
                    {
                        LlenaCampos(item);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error.Message);
                
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularAFP();
        }

        private void NombretextBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularVocal();
        }

        private void DirecciontextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularVocal()
        {
            int vocal = 0;
            string nombre = NombretextBox1.Text;

            foreach (char c in nombre.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vocal++;
                }
            }

            VocaltextBox1.Text = vocal.ToString();
        }

        private void telefonomaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void DigitosTelefono()
        {
            int digito = 0;
            string numero = telefonomaskedTextBox1.Text;

            foreach (char c in numero)
            {
                if (char.IsDigit(c))
                {
                    digito++;
                }
            }

            DigitextBox1.Text = digito.ToString();
        }

        private void VocaltextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DigitextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonomaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            DigitosTelefono();
        }

        private void AFPtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularAFP()
        {
            if (double.TryParse(SueldotextBox1.Text, out double salary))
            {                
                double afpRate = 0.10;

                double afpDeduction = salary * afpRate;

                AFPtextBox1.Text = afpDeduction.ToString("C2");
            }
            else
            {
                // Handle invalid salary input
                AFPtextBox1.Text = "Invalid salary";
            }

        }
    }
    }

