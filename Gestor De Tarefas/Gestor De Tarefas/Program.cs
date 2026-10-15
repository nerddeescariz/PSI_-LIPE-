namespace Gestor_De_Tarefas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

partial class Form1 : Form
{
    // ... outros membros ...

    private void ImportarTarefas()
    {
        string ficheiroTarefas = "tarefas.txt";
        if (!File.Exists(ficheiroTarefas))
        {
            File.Create(ficheiroTarefas).Close();
            return;
        }

        string[] linhas = File.ReadAllLines(ficheiroTarefas);
        foreach (string linha in linhas)
        {
            // Se 'tarefas' for um ListBox do formulário:
            tarefas.Items.Add(linha);
            // Se 'tarefas' for uma List<string> do formulário, usar:
            // tarefas.Add(linha);
        }
    }
}