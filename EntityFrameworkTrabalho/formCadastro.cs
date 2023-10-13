namespace EntityFrameworkTrabalho
{
    public partial class formCadastro : Form
    {
        public formCadastro(int id, string operaçao = "a")
        {
            InitializeComponent();

            if (id != 0)
            {
                GetPessoa(id);
            }

            if (operaçao == "v")
            {
                Text = "Visuzaliar";
                toolStripButton1.Visible = false;
                TravaFormulario();
            }
            else if (operaçao == "e")
            {
                Text = "Excluir";
                toolStripButton1.Visible = false;
                toolStripButton2.Visible = true;
                TravaFormulario();
            }
        }
        private void TravaFormulario()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

        }
        private void GetPessoa(int id)
        {
            textBox1.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    var pessoa = context.pessoas.Find(id);
                    if (pessoa != null)
                    {

                        textBox2.Text = pessoa.nome;
                        textBox3.Text = pessoa.dataNasc.ToString();
                        textBox4.Text = pessoa.estadoCivil;
                        textBox5.Text = pessoa.email;
                        textBox6.Text = pessoa.telefone;
                        textBox7.Text = pessoa.cidade;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool Salvar()
        {
            var pessoa = new Pessoa();

            pessoa.Id = Convert.ToInt32("0"+textBox1.Text);
            pessoa.nome = textBox2.Text;
            pessoa.dataNasc = Convert.ToDateTime(textBox3.Text);
            pessoa.estadoCivil = textBox4.Text;
            pessoa.email = textBox5.Text;
            pessoa.telefone = textBox6.Text;
            pessoa.cidade = textBox7.Text;

            try
            {
                using (var context = new DataContext())
                {
                    if (pessoa.Id == 0)
                        context.pessoas.Add(pessoa);
                    else
                        context.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar\n" + ex.Message);
                return false;
            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Excluir())
                Close();
        }

        private bool Excluir()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var pessoa = new Pessoa();

                    pessoa.Id = Convert.ToInt32(textBox1.Text);
                    var entry = context.Entry(pessoa);

                    if (entry.State == System.Data.Entity.EntityState.Detached)

                        context.pessoas.Attach(pessoa);
                    context.pessoas.Remove(pessoa);

                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir");
                return false;
            }
        }
    }
}
