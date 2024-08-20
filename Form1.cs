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
using Struct;

namespace CriandoHashTable
{
    public partial class Form1 : Form
    {
        Hashtable DadosAluno = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno;

            aluno.Ra = numRa.Value;
            aluno.Nome = txtNome.Text;
            aluno.Fone = mtbCelular.Text;
            aluno.DataNasc = dtpDataNasc.Value;
            aluno.Curso = txtCurso.Text;

            if (DadosAluno.ContainsKey(aluno.Ra))
            {
                MessageBox.Show("O aluno com RA: " + aluno.Ra + ", já foi cadastrado!");
                return;
            }
            else
            {
                DadosAluno.Add(numRa.Value, aluno);
                MessageBox.Show("O aluno com RA: " + aluno.Ra + ", foi cadastrado com sucesso!");
                return;
            }
        }
    }
}
