namespace gen_web_api_project
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            submit = new Button();
            label = new Label();
            slnName = new TextBox();
            addDependencies = new CheckBox();
            SuspendLayout();
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ControlLight;
            submit.BackgroundImageLayout = ImageLayout.Center;
            submit.Location = new Point(241, 83);
            submit.Name = "submit";
            submit.Size = new Size(84, 25);
            submit.TabIndex = 0;
            submit.Text = "Generate";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 49);
            label.Name = "label";
            label.Size = new Size(154, 15);
            label.TabIndex = 1;
            label.Text = "Digite o nome da aplicação:";
            label.Click += label_Click;
            // 
            // slnName
            // 
            slnName.Location = new Point(172, 46);
            slnName.Name = "slnName";
            slnName.PlaceholderText = "Solution Name";
            slnName.Size = new Size(153, 23);
            slnName.TabIndex = 2;
            // 
            // addDependencies
            // 
            addDependencies.AutoSize = true;
            addDependencies.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addDependencies.Location = new Point(16, 88);
            addDependencies.Name = "addDependencies";
            addDependencies.Size = new Size(195, 17);
            addDependencies.TabIndex = 3;
            addDependencies.Text = "Adicionar dependências padrões";
            addDependencies.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 139);
            Controls.Add(addDependencies);
            Controls.Add(slnName);
            Controls.Add(label);
            Controls.Add(submit);
            Name = "MainWindow";
            Text = "Auto-gen WebApi projects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private Label label;
        private TextBox slnName;
        private CheckBox addDependencies;
    }
}