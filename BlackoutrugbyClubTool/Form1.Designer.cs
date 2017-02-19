namespace BlackoutrugbyClubTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.team_name_label = new System.Windows.Forms.Label();
            this.season_date_label = new System.Windows.Forms.Label();
            this.manager_name_label = new System.Windows.Forms.Label();
            this.country_iso_label = new System.Windows.Forms.Label();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stamina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kicking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.team_energy_label = new System.Windows.Forms.Label();
            this.team_form_label = new System.Windows.Forms.Label();
            this.team_fatness_label = new System.Windows.Forms.Label();
            this.dataGridView_averages = new System.Windows.Forms.DataGridView();
            this.name_agerages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatness_avearge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_averages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.average_handling_label = new System.Windows.Forms.Label();
            this.average_kicking_label = new System.Windows.Forms.Label();
            this.average_stamina_label = new System.Windows.Forms.Label();
            this.average_speed_label = new System.Windows.Forms.Label();
            this.average_attack_label = new System.Windows.Forms.Label();
            this.average_strength_label = new System.Windows.Forms.Label();
            this.average_technique_label = new System.Windows.Forms.Label();
            this.average_defense_label = new System.Windows.Forms.Label();
            this.average_jumping_label = new System.Windows.Forms.Label();
            this.average_agility_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_averages)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 673);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "access key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 671);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // team_name_label
            // 
            this.team_name_label.AutoSize = true;
            this.team_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team_name_label.Location = new System.Drawing.Point(576, 9);
            this.team_name_label.Name = "team_name_label";
            this.team_name_label.Size = new System.Drawing.Size(99, 18);
            this.team_name_label.TabIndex = 6;
            this.team_name_label.Text = "Team Name";
            // 
            // season_date_label
            // 
            this.season_date_label.AutoSize = true;
            this.season_date_label.Location = new System.Drawing.Point(1089, 9);
            this.season_date_label.Name = "season_date_label";
            this.season_date_label.Size = new System.Drawing.Size(157, 13);
            this.season_date_label.TabIndex = 7;
            this.season_date_label.Text = "Season  ...  Round  ...   Day  ....";
            // 
            // manager_name_label
            // 
            this.manager_name_label.AutoSize = true;
            this.manager_name_label.Location = new System.Drawing.Point(16, 14);
            this.manager_name_label.Name = "manager_name_label";
            this.manager_name_label.Size = new System.Drawing.Size(61, 13);
            this.manager_name_label.TabIndex = 8;
            this.manager_name_label.Text = "Manager ...";
            // 
            // country_iso_label
            // 
            this.country_iso_label.AutoSize = true;
            this.country_iso_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.country_iso_label.Location = new System.Drawing.Point(597, 27);
            this.country_iso_label.Name = "country_iso_label";
            this.country_iso_label.Size = new System.Drawing.Size(43, 13);
            this.country_iso_label.TabIndex = 9;
            this.country_iso_label.Text = "Country";
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.birthday,
            this.nationality,
            this.csr,
            this.weight,
            this.height,
            this.form,
            this.energy,
            this.stamina,
            this.attack,
            this.technique,
            this.jumping,
            this.agility,
            this.handling,
            this.defense,
            this.strength,
            this.speed,
            this.kicking});
            this.dataGridView_main.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.Size = new System.Drawing.Size(1200, 575);
            this.dataGridView_main.TabIndex = 10;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 51;
            // 
            // birthday
            // 
            this.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 70;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.nationality.DefaultCellStyle = dataGridViewCellStyle1;
            this.nationality.HeaderText = "NAT";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            this.nationality.Width = 54;
            // 
            // csr
            // 
            this.csr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.csr.HeaderText = "CSR";
            this.csr.Name = "csr";
            this.csr.ReadOnly = true;
            this.csr.Width = 54;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 66;
            // 
            // height
            // 
            this.height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.height.HeaderText = "Height";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 63;
            // 
            // form
            // 
            this.form.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.form.HeaderText = "Form";
            this.form.Name = "form";
            this.form.ReadOnly = true;
            this.form.Width = 55;
            // 
            // energy
            // 
            this.energy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.energy.HeaderText = "Energy";
            this.energy.Name = "energy";
            this.energy.ReadOnly = true;
            this.energy.Width = 65;
            // 
            // stamina
            // 
            this.stamina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stamina.HeaderText = "STA";
            this.stamina.Name = "stamina";
            this.stamina.ReadOnly = true;
            this.stamina.Width = 53;
            // 
            // attack
            // 
            this.attack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attack.HeaderText = "ATT";
            this.attack.Name = "attack";
            this.attack.ReadOnly = true;
            this.attack.Width = 53;
            // 
            // technique
            // 
            this.technique.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.technique.HeaderText = "TEC";
            this.technique.Name = "technique";
            this.technique.ReadOnly = true;
            this.technique.Width = 53;
            // 
            // jumping
            // 
            this.jumping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jumping.HeaderText = "JUM";
            this.jumping.Name = "jumping";
            this.jumping.ReadOnly = true;
            this.jumping.Width = 54;
            // 
            // agility
            // 
            this.agility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agility.HeaderText = "AGI";
            this.agility.Name = "agility";
            this.agility.ReadOnly = true;
            this.agility.Width = 50;
            // 
            // handling
            // 
            this.handling.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.handling.HeaderText = "HAN";
            this.handling.Name = "handling";
            this.handling.ReadOnly = true;
            this.handling.Width = 55;
            // 
            // defense
            // 
            this.defense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.defense.HeaderText = "DEF";
            this.defense.Name = "defense";
            this.defense.ReadOnly = true;
            this.defense.Width = 53;
            // 
            // strength
            // 
            this.strength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.strength.HeaderText = "STR";
            this.strength.Name = "strength";
            this.strength.ReadOnly = true;
            this.strength.Width = 54;
            // 
            // speed
            // 
            this.speed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.speed.HeaderText = "SPE";
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Width = 53;
            // 
            // kicking
            // 
            this.kicking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kicking.HeaderText = "KIC";
            this.kicking.Name = "kicking";
            this.kicking.ReadOnly = true;
            this.kicking.Width = 49;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 613);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1212, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView_averages);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.team_energy_label);
            this.groupBox2.Controls.Add(this.team_form_label);
            this.groupBox2.Controls.Add(this.team_fatness_label);
            this.groupBox2.Location = new System.Drawing.Point(310, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 168);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Info:";
            // 
            // team_energy_label
            // 
            this.team_energy_label.AutoSize = true;
            this.team_energy_label.Location = new System.Drawing.Point(17, 32);
            this.team_energy_label.Name = "team_energy_label";
            this.team_energy_label.Size = new System.Drawing.Size(91, 13);
            this.team_energy_label.TabIndex = 16;
            this.team_energy_label.Text = "Team Energy :  ...";
            // 
            // team_form_label
            // 
            this.team_form_label.AutoSize = true;
            this.team_form_label.Location = new System.Drawing.Point(136, 32);
            this.team_form_label.Name = "team_form_label";
            this.team_form_label.Size = new System.Drawing.Size(81, 13);
            this.team_form_label.TabIndex = 14;
            this.team_form_label.Text = "Team Form :  ...";
            // 
            // team_fatness_label
            // 
            this.team_fatness_label.AutoSize = true;
            this.team_fatness_label.Location = new System.Drawing.Point(13, 58);
            this.team_fatness_label.Name = "team_fatness_label";
            this.team_fatness_label.Size = new System.Drawing.Size(95, 13);
            this.team_fatness_label.TabIndex = 13;
            this.team_fatness_label.Text = "Team Fatness :  ...";
            // 
            // dataGridView_averages
            // 
            this.dataGridView_averages.AllowUserToAddRows = false;
            this.dataGridView_averages.AllowUserToDeleteRows = false;
            this.dataGridView_averages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_averages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_agerages,
            this.fatness_avearge,
            this.group_averages});
            this.dataGridView_averages.Location = new System.Drawing.Point(747, 6);
            this.dataGridView_averages.Name = "dataGridView_averages";
            this.dataGridView_averages.ReadOnly = true;
            this.dataGridView_averages.Size = new System.Drawing.Size(459, 575);
            this.dataGridView_averages.TabIndex = 14;
            // 
            // name_agerages
            // 
            this.name_agerages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_agerages.HeaderText = "Name";
            this.name_agerages.Name = "name_agerages";
            this.name_agerages.ReadOnly = true;
            this.name_agerages.Width = 60;
            // 
            // fatness_avearge
            // 
            this.fatness_avearge.HeaderText = "Fatness";
            this.fatness_avearge.Name = "fatness_avearge";
            this.fatness_avearge.ReadOnly = true;
            // 
            // group_averages
            // 
            this.group_averages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.group_averages.HeaderText = "Forward or Back";
            this.group_averages.Name = "group_averages";
            this.group_averages.ReadOnly = true;
            this.group_averages.Width = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.average_handling_label);
            this.groupBox1.Controls.Add(this.average_kicking_label);
            this.groupBox1.Controls.Add(this.average_stamina_label);
            this.groupBox1.Controls.Add(this.average_speed_label);
            this.groupBox1.Controls.Add(this.average_attack_label);
            this.groupBox1.Controls.Add(this.average_strength_label);
            this.groupBox1.Controls.Add(this.average_technique_label);
            this.groupBox1.Controls.Add(this.average_defense_label);
            this.groupBox1.Controls.Add(this.average_jumping_label);
            this.groupBox1.Controls.Add(this.average_agility_label);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 168);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Stat Averages : ";
            // 
            // average_handling_label
            // 
            this.average_handling_label.AutoSize = true;
            this.average_handling_label.Location = new System.Drawing.Point(131, 32);
            this.average_handling_label.Name = "average_handling_label";
            this.average_handling_label.Size = new System.Drawing.Size(70, 13);
            this.average_handling_label.TabIndex = 8;
            this.average_handling_label.Text = "Handling :  ...";
            // 
            // average_kicking_label
            // 
            this.average_kicking_label.AutoSize = true;
            this.average_kicking_label.Location = new System.Drawing.Point(138, 131);
            this.average_kicking_label.Name = "average_kicking_label";
            this.average_kicking_label.Size = new System.Drawing.Size(63, 13);
            this.average_kicking_label.TabIndex = 12;
            this.average_kicking_label.Text = "Kicking :  ...";
            // 
            // average_stamina_label
            // 
            this.average_stamina_label.AutoSize = true;
            this.average_stamina_label.Location = new System.Drawing.Point(24, 32);
            this.average_stamina_label.Name = "average_stamina_label";
            this.average_stamina_label.Size = new System.Drawing.Size(66, 13);
            this.average_stamina_label.TabIndex = 3;
            this.average_stamina_label.Text = "Stamina :  ...";
            // 
            // average_speed_label
            // 
            this.average_speed_label.AutoSize = true;
            this.average_speed_label.Location = new System.Drawing.Point(142, 105);
            this.average_speed_label.Name = "average_speed_label";
            this.average_speed_label.Size = new System.Drawing.Size(59, 13);
            this.average_speed_label.TabIndex = 11;
            this.average_speed_label.Text = "Speed :  ...";
            // 
            // average_attack_label
            // 
            this.average_attack_label.AutoSize = true;
            this.average_attack_label.Location = new System.Drawing.Point(31, 58);
            this.average_attack_label.Name = "average_attack_label";
            this.average_attack_label.Size = new System.Drawing.Size(59, 13);
            this.average_attack_label.TabIndex = 4;
            this.average_attack_label.Text = "Attack :  ...";
            // 
            // average_strength_label
            // 
            this.average_strength_label.AutoSize = true;
            this.average_strength_label.Location = new System.Drawing.Point(133, 80);
            this.average_strength_label.Name = "average_strength_label";
            this.average_strength_label.Size = new System.Drawing.Size(68, 13);
            this.average_strength_label.TabIndex = 10;
            this.average_strength_label.Text = "Sterngth :  ...";
            // 
            // average_technique_label
            // 
            this.average_technique_label.AutoSize = true;
            this.average_technique_label.Location = new System.Drawing.Point(11, 80);
            this.average_technique_label.Name = "average_technique_label";
            this.average_technique_label.Size = new System.Drawing.Size(79, 13);
            this.average_technique_label.TabIndex = 5;
            this.average_technique_label.Text = "Technique :  ...";
            // 
            // average_defense_label
            // 
            this.average_defense_label.AutoSize = true;
            this.average_defense_label.Location = new System.Drawing.Point(133, 58);
            this.average_defense_label.Name = "average_defense_label";
            this.average_defense_label.Size = new System.Drawing.Size(68, 13);
            this.average_defense_label.TabIndex = 9;
            this.average_defense_label.Text = "Defense :  ...";
            // 
            // average_jumping_label
            // 
            this.average_jumping_label.AutoSize = true;
            this.average_jumping_label.Location = new System.Drawing.Point(23, 105);
            this.average_jumping_label.Name = "average_jumping_label";
            this.average_jumping_label.Size = new System.Drawing.Size(67, 13);
            this.average_jumping_label.TabIndex = 6;
            this.average_jumping_label.Text = "Jumping :  ...";
            // 
            // average_agility_label
            // 
            this.average_agility_label.AutoSize = true;
            this.average_agility_label.Location = new System.Drawing.Point(35, 131);
            this.average_agility_label.Name = "average_agility_label";
            this.average_agility_label.Size = new System.Drawing.Size(55, 13);
            this.average_agility_label.TabIndex = 7;
            this.average_agility_label.Text = "Agility :  ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Position Algorythm";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(81, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 221);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 705);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.country_iso_label);
            this.Controls.Add(this.manager_name_label);
            this.Controls.Add(this.season_date_label);
            this.Controls.Add(this.team_name_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_averages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label team_name_label;
        private System.Windows.Forms.Label season_date_label;
        private System.Windows.Forms.Label manager_name_label;
        private System.Windows.Forms.Label country_iso_label;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label average_attack_label;
        private System.Windows.Forms.Label average_stamina_label;
        private System.Windows.Forms.Label average_kicking_label;
        private System.Windows.Forms.Label average_speed_label;
        private System.Windows.Forms.Label average_strength_label;
        private System.Windows.Forms.Label average_defense_label;
        private System.Windows.Forms.Label average_handling_label;
        private System.Windows.Forms.Label average_agility_label;
        private System.Windows.Forms.Label average_jumping_label;
        private System.Windows.Forms.Label average_technique_label;
        private System.Windows.Forms.DataGridView dataGridView_averages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_agerages;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatness_avearge;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_averages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label team_energy_label;
        private System.Windows.Forms.Label team_form_label;
        private System.Windows.Forms.Label team_fatness_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn csr;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn form;
        private System.Windows.Forms.DataGridViewTextBoxColumn energy;
        private System.Windows.Forms.DataGridViewTextBoxColumn stamina;
        private System.Windows.Forms.DataGridViewTextBoxColumn attack;
        private System.Windows.Forms.DataGridViewTextBoxColumn technique;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumping;
        private System.Windows.Forms.DataGridViewTextBoxColumn agility;
        private System.Windows.Forms.DataGridViewTextBoxColumn handling;
        private System.Windows.Forms.DataGridViewTextBoxColumn defense;
        private System.Windows.Forms.DataGridViewTextBoxColumn strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn kicking;
    }
}

