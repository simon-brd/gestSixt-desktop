namespace gestSixt
{
    partial class frm_gestSixt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbs_tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbc_tabsControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tbp_tableauDeBord = new System.Windows.Forms.TabPage();
            this.lbl_nbVehiculesTotalValue = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nbVehiculesTotalText = new MaterialSkin.Controls.MaterialLabel();
            this.tbp_vehicles = new System.Windows.Forms.TabPage();
            this.dgv_vehicules = new MaterialSkin.Controls.MaterialListView();
            this.dgc_immatriculation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgc_modele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgc_marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgc_nbKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgc_etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbc_tabsControl.SuspendLayout();
            this.tbp_tableauDeBord.SuspendLayout();
            this.tbp_vehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbs_tabSelector
            // 
            this.tbs_tabSelector.BaseTabControl = this.tbc_tabsControl;
            this.tbs_tabSelector.Depth = 0;
            this.tbs_tabSelector.Location = new System.Drawing.Point(-1, 64);
            this.tbs_tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbs_tabSelector.Name = "tbs_tabSelector";
            this.tbs_tabSelector.Size = new System.Drawing.Size(1244, 46);
            this.tbs_tabSelector.TabIndex = 0;
            this.tbs_tabSelector.Text = "materialTabSelector1";
            // 
            // tbc_tabsControl
            // 
            this.tbc_tabsControl.Controls.Add(this.tbp_tableauDeBord);
            this.tbc_tabsControl.Controls.Add(this.tbp_vehicles);
            this.tbc_tabsControl.Depth = 0;
            this.tbc_tabsControl.Location = new System.Drawing.Point(28, 116);
            this.tbc_tabsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_tabsControl.Name = "tbc_tabsControl";
            this.tbc_tabsControl.SelectedIndex = 0;
            this.tbc_tabsControl.Size = new System.Drawing.Size(1182, 561);
            this.tbc_tabsControl.TabIndex = 1;
            // 
            // tbp_tableauDeBord
            // 
            this.tbp_tableauDeBord.Controls.Add(this.lbl_nbVehiculesTotalValue);
            this.tbp_tableauDeBord.Controls.Add(this.lbl_nbVehiculesTotalText);
            this.tbp_tableauDeBord.Location = new System.Drawing.Point(4, 22);
            this.tbp_tableauDeBord.Name = "tbp_tableauDeBord";
            this.tbp_tableauDeBord.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tableauDeBord.Size = new System.Drawing.Size(1174, 535);
            this.tbp_tableauDeBord.TabIndex = 0;
            this.tbp_tableauDeBord.Text = "Tableau de Bord";
            this.tbp_tableauDeBord.UseVisualStyleBackColor = true;
            // 
            // lbl_nbVehiculesTotalValue
            // 
            this.lbl_nbVehiculesTotalValue.Depth = 0;
            this.lbl_nbVehiculesTotalValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbVehiculesTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbVehiculesTotalValue.Location = new System.Drawing.Point(469, 34);
            this.lbl_nbVehiculesTotalValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbVehiculesTotalValue.Name = "lbl_nbVehiculesTotalValue";
            this.lbl_nbVehiculesTotalValue.Size = new System.Drawing.Size(100, 19);
            this.lbl_nbVehiculesTotalValue.TabIndex = 1;
            // 
            // lbl_nbVehiculesTotalText
            // 
            this.lbl_nbVehiculesTotalText.AutoSize = true;
            this.lbl_nbVehiculesTotalText.Depth = 0;
            this.lbl_nbVehiculesTotalText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbVehiculesTotalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbVehiculesTotalText.Location = new System.Drawing.Point(248, 34);
            this.lbl_nbVehiculesTotalText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbVehiculesTotalText.Name = "lbl_nbVehiculesTotalText";
            this.lbl_nbVehiculesTotalText.Size = new System.Drawing.Size(193, 19);
            this.lbl_nbVehiculesTotalText.TabIndex = 0;
            this.lbl_nbVehiculesTotalText.Text = "Nombre total de véhicules :";
            // 
            // tbp_vehicles
            // 
            this.tbp_vehicles.Controls.Add(this.dgv_vehicules);
            this.tbp_vehicles.Location = new System.Drawing.Point(4, 22);
            this.tbp_vehicles.Name = "tbp_vehicles";
            this.tbp_vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_vehicles.Size = new System.Drawing.Size(1174, 535);
            this.tbp_vehicles.TabIndex = 1;
            this.tbp_vehicles.Text = "Véhicules";
            this.tbp_vehicles.UseVisualStyleBackColor = true;
            // 
            // dgv_vehicules
            // 
            this.dgv_vehicules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vehicules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dgc_immatriculation,
            this.dgc_modele,
            this.dgc_marque,
            this.dgc_nbKm,
            this.dgc_etat});
            this.dgv_vehicules.Depth = 0;
            this.dgv_vehicules.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.dgv_vehicules.FullRowSelect = true;
            this.dgv_vehicules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dgv_vehicules.HideSelection = false;
            this.dgv_vehicules.Location = new System.Drawing.Point(3, 15);
            this.dgv_vehicules.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dgv_vehicules.MouseState = MaterialSkin.MouseState.OUT;
            this.dgv_vehicules.Name = "dgv_vehicules";
            this.dgv_vehicules.OwnerDraw = true;
            this.dgv_vehicules.Size = new System.Drawing.Size(591, 277);
            this.dgv_vehicules.TabIndex = 0;
            this.dgv_vehicules.UseCompatibleStateImageBehavior = false;
            this.dgv_vehicules.View = System.Windows.Forms.View.Details;
            // 
            // dgc_immatriculation
            // 
            this.dgc_immatriculation.Text = "Immatriculation";
            this.dgc_immatriculation.Width = 140;
            // 
            // dgc_modele
            // 
            this.dgc_modele.Text = "Modèle";
            this.dgc_modele.Width = 120;
            // 
            // dgc_marque
            // 
            this.dgc_marque.Text = "Marque";
            this.dgc_marque.Width = 120;
            // 
            // dgc_nbKm
            // 
            this.dgc_nbKm.Text = "Kilométrage";
            this.dgc_nbKm.Width = 110;
            // 
            // dgc_etat
            // 
            this.dgc_etat.Text = "Etat";
            this.dgc_etat.Width = 101;
            // 
            // frm_gestSixt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 689);
            this.Controls.Add(this.tbc_tabsControl);
            this.Controls.Add(this.tbs_tabSelector);
            this.Name = "frm_gestSixt";
            this.Text = "GestSixt";
            this.Load += new System.EventHandler(this.frm_gestSixt_Load);
            this.tbc_tabsControl.ResumeLayout(false);
            this.tbp_tableauDeBord.ResumeLayout(false);
            this.tbp_tableauDeBord.PerformLayout();
            this.tbp_vehicles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbs_tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tbc_tabsControl;
        private System.Windows.Forms.TabPage tbp_tableauDeBord;
        private System.Windows.Forms.TabPage tbp_vehicles;
        private MaterialSkin.Controls.MaterialLabel lbl_nbVehiculesTotalValue;
        private MaterialSkin.Controls.MaterialLabel lbl_nbVehiculesTotalText;
        private MaterialSkin.Controls.MaterialListView dgv_vehicules;
        private System.Windows.Forms.ColumnHeader dgc_immatriculation;
        private System.Windows.Forms.ColumnHeader dgc_modele;
        private System.Windows.Forms.ColumnHeader dgc_marque;
        private System.Windows.Forms.ColumnHeader dgc_nbKm;
        private System.Windows.Forms.ColumnHeader dgc_etat;
    }
}

