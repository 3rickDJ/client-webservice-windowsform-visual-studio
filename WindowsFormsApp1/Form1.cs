﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumnos.AlumnosWebService client = new Alumnos.AlumnosWebService();

            // Declare the out variables
            bool studentFound;
            bool returnSpecified;

            // Call the encontrarAlumno method
            client.encontrarAlumno(username.Text, password.Text, out studentFound, out returnSpecified);

            if (studentFound && returnSpecified)
            {
                result.Text = "BIENVENIDO";
            } else
            {
                result.Text = "El usuario o  contraseña son incorrectos";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
