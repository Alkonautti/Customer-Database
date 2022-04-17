
namespace CustomerDatabase
{
    partial class AppMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_refreshcustomerlist = new System.Windows.Forms.Button();
            this.btn_exittologin = new System.Windows.Forms.Button();
            this.btn_deletecustomer = new System.Windows.Forms.Button();
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.txtbox_findcustomer = new System.Windows.Forms.TextBox();
            this.lbl_findcustomer = new System.Windows.Forms.Label();
            this.lbl_customerheader = new System.Windows.Forms.Label();
            this.lstbox_customerlist = new System.Windows.Forms.ListBox();
            this.lbl_infocustomeractionsheader = new System.Windows.Forms.Label();
            this.rtbox_actions = new System.Windows.Forms.RichTextBox();
            this.lbl_infoopencomments = new System.Windows.Forms.Label();
            this.rtbox_opencoms = new System.Windows.Forms.RichTextBox();
            this.lbl_infocountry = new System.Windows.Forms.Label();
            this.txtbox_infocountry = new System.Windows.Forms.TextBox();
            this.btn_infosave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_infocity = new System.Windows.Forms.TextBox();
            this.lbl_infopostal = new System.Windows.Forms.Label();
            this.txtbox_infopostal = new System.Windows.Forms.TextBox();
            this.lbl_infostreet = new System.Windows.Forms.Label();
            this.txtbox_infostreet = new System.Windows.Forms.TextBox();
            this.lbl_infoemail = new System.Windows.Forms.Label();
            this.txtbox_infoemail = new System.Windows.Forms.TextBox();
            this.lbl_infophone = new System.Windows.Forms.Label();
            this.txtbox_infophone = new System.Windows.Forms.TextBox();
            this.lbl_infoname = new System.Windows.Forms.Label();
            this.txtbox_infoname = new System.Windows.Forms.TextBox();
            this.lbl_contactinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_refreshcustomerlist);
            this.splitContainer1.Panel1.Controls.Add(this.btn_exittologin);
            this.splitContainer1.Panel1.Controls.Add(this.btn_deletecustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addcustomer);
            this.splitContainer1.Panel1.Controls.Add(this.txtbox_findcustomer);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_findcustomer);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_customerheader);
            this.splitContainer1.Panel1.Controls.Add(this.lstbox_customerlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infocustomeractionsheader);
            this.splitContainer1.Panel2.Controls.Add(this.rtbox_actions);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infoopencomments);
            this.splitContainer1.Panel2.Controls.Add(this.rtbox_opencoms);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infocountry);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infocountry);
            this.splitContainer1.Panel2.Controls.Add(this.btn_infosave);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infocity);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infopostal);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infopostal);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infostreet);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infostreet);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infoemail);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infoemail);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infophone);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infophone);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_infoname);
            this.splitContainer1.Panel2.Controls.Add(this.txtbox_infoname);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_contactinfo);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 767);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_refreshcustomerlist
            // 
            this.btn_refreshcustomerlist.Location = new System.Drawing.Point(12, 674);
            this.btn_refreshcustomerlist.Name = "btn_refreshcustomerlist";
            this.btn_refreshcustomerlist.Size = new System.Drawing.Size(195, 23);
            this.btn_refreshcustomerlist.TabIndex = 7;
            this.btn_refreshcustomerlist.Text = "Refresh List";
            this.btn_refreshcustomerlist.UseVisualStyleBackColor = true;
            this.btn_refreshcustomerlist.Click += new System.EventHandler(this.btn_refreshcustomerlist_Click);
            // 
            // btn_exittologin
            // 
            this.btn_exittologin.Location = new System.Drawing.Point(12, 732);
            this.btn_exittologin.Name = "btn_exittologin";
            this.btn_exittologin.Size = new System.Drawing.Size(195, 23);
            this.btn_exittologin.TabIndex = 6;
            this.btn_exittologin.Text = "Log Out";
            this.btn_exittologin.UseVisualStyleBackColor = true;
            this.btn_exittologin.Click += new System.EventHandler(this.btn_exittologin_Click);
            // 
            // btn_deletecustomer
            // 
            this.btn_deletecustomer.Location = new System.Drawing.Point(12, 703);
            this.btn_deletecustomer.Name = "btn_deletecustomer";
            this.btn_deletecustomer.Size = new System.Drawing.Size(195, 23);
            this.btn_deletecustomer.TabIndex = 5;
            this.btn_deletecustomer.Text = "Delete Customer";
            this.btn_deletecustomer.UseVisualStyleBackColor = true;
            this.btn_deletecustomer.Click += new System.EventHandler(this.btn_deletecustomer_Click);
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Location = new System.Drawing.Point(12, 645);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(195, 23);
            this.btn_addcustomer.TabIndex = 4;
            this.btn_addcustomer.Text = "Add New Customer";
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // txtbox_findcustomer
            // 
            this.txtbox_findcustomer.Location = new System.Drawing.Point(56, 49);
            this.txtbox_findcustomer.Name = "txtbox_findcustomer";
            this.txtbox_findcustomer.Size = new System.Drawing.Size(151, 20);
            this.txtbox_findcustomer.TabIndex = 3;
            this.txtbox_findcustomer.TextChanged += new System.EventHandler(this.txtbox_findcustomer_TextChanged);
            // 
            // lbl_findcustomer
            // 
            this.lbl_findcustomer.AutoSize = true;
            this.lbl_findcustomer.Location = new System.Drawing.Point(9, 52);
            this.lbl_findcustomer.Name = "lbl_findcustomer";
            this.lbl_findcustomer.Size = new System.Drawing.Size(41, 13);
            this.lbl_findcustomer.TabIndex = 2;
            this.lbl_findcustomer.Text = "Search";
            // 
            // lbl_customerheader
            // 
            this.lbl_customerheader.AutoSize = true;
            this.lbl_customerheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerheader.Location = new System.Drawing.Point(7, 9);
            this.lbl_customerheader.Name = "lbl_customerheader";
            this.lbl_customerheader.Size = new System.Drawing.Size(115, 25);
            this.lbl_customerheader.TabIndex = 1;
            this.lbl_customerheader.Text = "Customers";
            // 
            // lstbox_customerlist
            // 
            this.lstbox_customerlist.FormattingEnabled = true;
            this.lstbox_customerlist.Location = new System.Drawing.Point(12, 75);
            this.lstbox_customerlist.Name = "lstbox_customerlist";
            this.lstbox_customerlist.Size = new System.Drawing.Size(195, 563);
            this.lstbox_customerlist.TabIndex = 0;
            this.lstbox_customerlist.DoubleClick += new System.EventHandler(this.lstbox_customerlist_DoubleClick);
            // 
            // lbl_infocustomeractionsheader
            // 
            this.lbl_infocustomeractionsheader.AutoSize = true;
            this.lbl_infocustomeractionsheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infocustomeractionsheader.Location = new System.Drawing.Point(247, 9);
            this.lbl_infocustomeractionsheader.Name = "lbl_infocustomeractionsheader";
            this.lbl_infocustomeractionsheader.Size = new System.Drawing.Size(211, 24);
            this.lbl_infocustomeractionsheader.TabIndex = 19;
            this.lbl_infocustomeractionsheader.Text = "Latest Customer Actions";
            // 
            // rtbox_actions
            // 
            this.rtbox_actions.Location = new System.Drawing.Point(251, 49);
            this.rtbox_actions.Name = "rtbox_actions";
            this.rtbox_actions.Size = new System.Drawing.Size(763, 661);
            this.rtbox_actions.TabIndex = 18;
            this.rtbox_actions.Text = "";
            // 
            // lbl_infoopencomments
            // 
            this.lbl_infoopencomments.AutoSize = true;
            this.lbl_infoopencomments.Location = new System.Drawing.Point(5, 259);
            this.lbl_infoopencomments.Name = "lbl_infoopencomments";
            this.lbl_infoopencomments.Size = new System.Drawing.Size(85, 13);
            this.lbl_infoopencomments.TabIndex = 17;
            this.lbl_infoopencomments.Text = "Open Comments";
            // 
            // rtbox_opencoms
            // 
            this.rtbox_opencoms.Location = new System.Drawing.Point(8, 275);
            this.rtbox_opencoms.Name = "rtbox_opencoms";
            this.rtbox_opencoms.Size = new System.Drawing.Size(223, 435);
            this.rtbox_opencoms.TabIndex = 16;
            this.rtbox_opencoms.Text = "";
            // 
            // lbl_infocountry
            // 
            this.lbl_infocountry.AutoSize = true;
            this.lbl_infocountry.Location = new System.Drawing.Point(5, 208);
            this.lbl_infocountry.Name = "lbl_infocountry";
            this.lbl_infocountry.Size = new System.Drawing.Size(43, 13);
            this.lbl_infocountry.TabIndex = 15;
            this.lbl_infocountry.Text = "Country";
            // 
            // txtbox_infocountry
            // 
            this.txtbox_infocountry.Location = new System.Drawing.Point(49, 205);
            this.txtbox_infocountry.Name = "txtbox_infocountry";
            this.txtbox_infocountry.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infocountry.TabIndex = 14;
            // 
            // btn_infosave
            // 
            this.btn_infosave.Location = new System.Drawing.Point(251, 716);
            this.btn_infosave.Name = "btn_infosave";
            this.btn_infosave.Size = new System.Drawing.Size(120, 23);
            this.btn_infosave.TabIndex = 13;
            this.btn_infosave.Text = "Save User Info";
            this.btn_infosave.UseVisualStyleBackColor = true;
            this.btn_infosave.Click += new System.EventHandler(this.btn_infosave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "City";
            // 
            // txtbox_infocity
            // 
            this.txtbox_infocity.Location = new System.Drawing.Point(49, 179);
            this.txtbox_infocity.Name = "txtbox_infocity";
            this.txtbox_infocity.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infocity.TabIndex = 11;
            // 
            // lbl_infopostal
            // 
            this.lbl_infopostal.AutoSize = true;
            this.lbl_infopostal.Location = new System.Drawing.Point(5, 156);
            this.lbl_infopostal.Name = "lbl_infopostal";
            this.lbl_infopostal.Size = new System.Drawing.Size(36, 13);
            this.lbl_infopostal.TabIndex = 10;
            this.lbl_infopostal.Text = "Postal";
            // 
            // txtbox_infopostal
            // 
            this.txtbox_infopostal.Location = new System.Drawing.Point(49, 153);
            this.txtbox_infopostal.Name = "txtbox_infopostal";
            this.txtbox_infopostal.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infopostal.TabIndex = 9;
            // 
            // lbl_infostreet
            // 
            this.lbl_infostreet.AutoSize = true;
            this.lbl_infostreet.Location = new System.Drawing.Point(5, 130);
            this.lbl_infostreet.Name = "lbl_infostreet";
            this.lbl_infostreet.Size = new System.Drawing.Size(35, 13);
            this.lbl_infostreet.TabIndex = 8;
            this.lbl_infostreet.Text = "Street";
            // 
            // txtbox_infostreet
            // 
            this.txtbox_infostreet.Location = new System.Drawing.Point(49, 127);
            this.txtbox_infostreet.Name = "txtbox_infostreet";
            this.txtbox_infostreet.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infostreet.TabIndex = 7;
            // 
            // lbl_infoemail
            // 
            this.lbl_infoemail.AutoSize = true;
            this.lbl_infoemail.Location = new System.Drawing.Point(5, 104);
            this.lbl_infoemail.Name = "lbl_infoemail";
            this.lbl_infoemail.Size = new System.Drawing.Size(32, 13);
            this.lbl_infoemail.TabIndex = 6;
            this.lbl_infoemail.Text = "Email";
            // 
            // txtbox_infoemail
            // 
            this.txtbox_infoemail.Location = new System.Drawing.Point(49, 101);
            this.txtbox_infoemail.Name = "txtbox_infoemail";
            this.txtbox_infoemail.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infoemail.TabIndex = 5;
            // 
            // lbl_infophone
            // 
            this.lbl_infophone.AutoSize = true;
            this.lbl_infophone.Location = new System.Drawing.Point(5, 78);
            this.lbl_infophone.Name = "lbl_infophone";
            this.lbl_infophone.Size = new System.Drawing.Size(38, 13);
            this.lbl_infophone.TabIndex = 4;
            this.lbl_infophone.Text = "Phone";
            // 
            // txtbox_infophone
            // 
            this.txtbox_infophone.Location = new System.Drawing.Point(49, 75);
            this.txtbox_infophone.Name = "txtbox_infophone";
            this.txtbox_infophone.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infophone.TabIndex = 3;
            // 
            // lbl_infoname
            // 
            this.lbl_infoname.AutoSize = true;
            this.lbl_infoname.Location = new System.Drawing.Point(5, 52);
            this.lbl_infoname.Name = "lbl_infoname";
            this.lbl_infoname.Size = new System.Drawing.Size(35, 13);
            this.lbl_infoname.TabIndex = 2;
            this.lbl_infoname.Text = "Name";
            // 
            // txtbox_infoname
            // 
            this.txtbox_infoname.Location = new System.Drawing.Point(49, 49);
            this.txtbox_infoname.Name = "txtbox_infoname";
            this.txtbox_infoname.Size = new System.Drawing.Size(182, 20);
            this.txtbox_infoname.TabIndex = 1;
            // 
            // lbl_contactinfo
            // 
            this.lbl_contactinfo.AutoSize = true;
            this.lbl_contactinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactinfo.Location = new System.Drawing.Point(3, 9);
            this.lbl_contactinfo.Name = "lbl_contactinfo";
            this.lbl_contactinfo.Size = new System.Drawing.Size(194, 24);
            this.lbl_contactinfo.TabIndex = 0;
            this.lbl_contactinfo.Text = "Customer Contact Info";
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 767);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1264, 806);
            this.Name = "AppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Database";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtbox_findcustomer;
        private System.Windows.Forms.Label lbl_findcustomer;
        private System.Windows.Forms.Label lbl_customerheader;
        private System.Windows.Forms.ListBox lstbox_customerlist;
        private System.Windows.Forms.Button btn_deletecustomer;
        private System.Windows.Forms.Button btn_addcustomer;
        private System.Windows.Forms.Button btn_exittologin;
        private System.Windows.Forms.Label lbl_infoname;
        private System.Windows.Forms.TextBox txtbox_infoname;
        private System.Windows.Forms.Label lbl_contactinfo;
        private System.Windows.Forms.Label lbl_infophone;
        private System.Windows.Forms.TextBox txtbox_infophone;
        private System.Windows.Forms.Label lbl_infocountry;
        private System.Windows.Forms.TextBox txtbox_infocountry;
        private System.Windows.Forms.Button btn_infosave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_infocity;
        private System.Windows.Forms.Label lbl_infopostal;
        private System.Windows.Forms.TextBox txtbox_infopostal;
        private System.Windows.Forms.Label lbl_infostreet;
        private System.Windows.Forms.TextBox txtbox_infostreet;
        private System.Windows.Forms.Label lbl_infoemail;
        private System.Windows.Forms.TextBox txtbox_infoemail;
        private System.Windows.Forms.RichTextBox rtbox_opencoms;
        private System.Windows.Forms.Label lbl_infocustomeractionsheader;
        private System.Windows.Forms.RichTextBox rtbox_actions;
        private System.Windows.Forms.Label lbl_infoopencomments;
        private System.Windows.Forms.Button btn_refreshcustomerlist;
    }
}