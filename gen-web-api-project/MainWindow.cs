using System.Diagnostics;

namespace gen_web_api_project
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //if (slnName.Text.Length < 5)
            //    return TaskStatus.WaitingToRun;

            
            Process proc = new Process();

            string dir = string.Format(@"C:\Users\User\Desktop\projects");

            proc.StartInfo.WorkingDirectory = dir;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
         
            proc.StandardInput.WriteLine($"mkdir {this.slnName.Text}");
            proc.StandardInput.WriteLine($"cd {this.slnName.Text}");
            proc.StandardInput.WriteLine($"dotnet new sln -n {this.slnName.Text}");
            proc.StandardInput.WriteLine($"mkdir src");
            proc.StandardInput.WriteLine($"cd src");

            proc.StandardInput.WriteLine($"dotnet new classlib -o {this.slnName.Text}.Application");
            proc.StandardInput.WriteLine($"dotnet new classlib -o {this.slnName.Text}.Infraestructure");
            proc.StandardInput.WriteLine($"dotnet new classlib -o {this.slnName.Text}.Domain");
            proc.StandardInput.WriteLine($"dotnet new classlib -o {this.slnName.Text}.Core");
            proc.StandardInput.WriteLine($"dotnet new webapi -o {this.slnName.Text}.WebApi");
                        proc.StandardInput.WriteLine($"cd ..");
            
            proc.StandardInput.WriteLine(@$"dotnet sln {this.slnName.Text}.sln add src\{this.slnName.Text}.Application\{this.slnName.Text}.Application.csproj --solution-folder Application");
            proc.StandardInput.WriteLine(@$"dotnet sln {this.slnName.Text}.sln add src\{this.slnName.Text}.Infraestructure\{this.slnName.Text}.Infraestructure.csproj --solution-folder Infraestructure");
            proc.StandardInput.WriteLine(@$"dotnet sln {this.slnName.Text}.sln add src\{this.slnName.Text}.Core\{this.slnName.Text}.Core.csproj --solution-folder Core");
            proc.StandardInput.WriteLine(@$"dotnet sln {this.slnName.Text}.sln add src\{this.slnName.Text}.Domain\{this.slnName.Text}.Domain.csproj --solution-folder Domain");
            proc.StandardInput.WriteLine(@$"dotnet sln {this.slnName.Text}.sln add src\{this.slnName.Text}.WebApi\{this.slnName.Text}.WebApi.csproj --solution-folder WebApi");
            
            proc.StandardInput.WriteLine(@$"dotnet add src\{this.slnName.Text}.WebApi\{this.slnName.Text}.WebApi.csproj package Microsoft.EntityFrameworkCore");
            //proc.StandardInput.Close();

            //string output = proc.StandardOutput.ReadToEnd();
            proc.Close();

            DialogResult result = MessageBox.Show("Aqui acabou!");
            if ( result == DialogResult.OK )
                Application.Exit();



        }

        private void slnName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}