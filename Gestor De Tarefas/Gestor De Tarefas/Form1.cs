namespace Gestor_De_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string tarefa = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(tarefa))
            {
                Tarefa.Items.Add(tarefa);
                textBox1.Clear();
            }
        }
        private void ButtonCompletar_Click(object sender, EventArgs e)
        {
            if (Tarefa.SelectedItem != null)
            {
                int indice= Tarefa.SelectedIndex;   
                string tarefaCompleta = Tarefa.SelectedItem.ToString() + " ✅";
                Tarefa.Items[indice] = tarefaCompleta;
            }
        }
        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            Tarefa.Items.Remove(Tarefa.SelectedItem);
        }
    }
}
