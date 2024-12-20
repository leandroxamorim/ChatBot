using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cadastro
{
    public partial class FormCadastro : Form
    {
        List<Pessoa> pessoas;
        public FormCadastro()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            //adiciona indices por ordem, representados por 0 em diante
            ComboMaritalS.Items.Add("Casado");
            ComboMaritalS.Items.Add("Solteiro");
            ComboMaritalS.Items.Add("Viuvo");
            ComboMaritalS.Items.Add("Separado");

            ComboMaritalS.SelectedIndex = 0;

        }

        public void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            int index = -1;
             
            foreach (Pessoa pessoa in pessoas)
            {
                //campo nome indica de a pessoa já esta cadastrada
                if (pessoa.Name == txtName.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!");
                txtName.Focus();
                return;
            }

            if (txtTelephone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone!");
                txtTelephone.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }

            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Name = txtName.Text;
            p.BirthDay = txtDate.Text;
            p.MaritalStatus = ComboMaritalS.SelectedItem.ToString();
            p.Telephone = txtTelephone.Text;
            p.CNH = checkCNH.Checked.ToString();
            p.Car = checkCAR.Checked.ToString();
            p.Sex = sexo.ToString();

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            BtnClean_Click(BtnClean, EventArgs.Empty);

            Listar();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDate.Text = "";
            ComboMaritalS.SelectedIndex = 0;
            txtTelephone.Text = "";
            checkCNH.Checked = false;
            checkCAR.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            txtName.Focus();

        }

        private void Listar()
        {
            lista.Items.Clear(); //inicia limpando a lista

            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Name);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtName.Text = p.Name;
            txtDate.Text = p.BirthDay;
            ComboMaritalS.SelectedItem = p.MaritalStatus;
            txtTelephone.Text = p.Telephone;
            checkCNH.Checked = bool.Parse(p.CNH);
            checkCAR.Checked = bool.Parse(p.Car);

            switch (p.Sex)
            {
                case "M":
                    radioM.Checked = true;
                    break;
                case "F":
                    radioF.Checked = true;
                    break;
                default:
                    radioO.Checked = true;
                    break;
            }


        }
    }
}
