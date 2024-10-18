namespace PizzaShopManagement
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet41 = new PizzaShopManagement.DataSet4();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Order_Details.*\r\nFROM     Order_Details";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Order_id", System.Data.SqlDbType.Char, 0, "Order_id"),
            new System.Data.SqlClient.SqlParameter("@Cust_id", System.Data.SqlDbType.Char, 0, "Cust_id"),
            new System.Data.SqlClient.SqlParameter("@Pizza_id", System.Data.SqlDbType.Char, 0, "Pizza_id"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.Int, 0, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Method", System.Data.SqlDbType.VarChar, 0, "Method"),
            new System.Data.SqlClient.SqlParameter("@Total_price", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Total_price", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Order_id", System.Data.SqlDbType.Char, 0, "Order_id"),
            new System.Data.SqlClient.SqlParameter("@Cust_id", System.Data.SqlDbType.Char, 0, "Cust_id"),
            new System.Data.SqlClient.SqlParameter("@Pizza_id", System.Data.SqlDbType.Char, 0, "Pizza_id"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.Int, 0, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Method", System.Data.SqlDbType.VarChar, 0, "Method"),
            new System.Data.SqlClient.SqlParameter("@Total_price", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Total_price", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_Order_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Order_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cust_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cust_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Pizza_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pizza_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Method", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Method", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Method", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Method", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Total_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Total_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Total_price", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Total_price", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Order_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Order_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cust_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cust_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Pizza_id", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pizza_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Method", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Method", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Method", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Method", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Total_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Total_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Total_price", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Total_price", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Order_Details", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Order_id", "Order_id"),
                        new System.Data.Common.DataColumnMapping("Cust_id", "Cust_id"),
                        new System.Data.Common.DataColumnMapping("Pizza_id", "Pizza_id"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Method", "Method"),
                        new System.Data.Common.DataColumnMapping("Total_price", "Total_price")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=HIRUSHANI\\MSSQLSERVER01;Initial Catalog=Exam2024_PS2020001;Integrated" +
    " Security=True;Pooling=False;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet41
            // 
            this.dataSet41.DataSetName = "DataSet4";
            this.dataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.custidDataGridViewTextBoxColumn,
            this.pizzaidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.methodDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Order_Details";
            this.dataGridView1.DataSource = this.dataSet41;
            this.dataGridView1.Location = new System.Drawing.Point(187, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(12, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 39);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(12, 137);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrderNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderNow.Location = new System.Drawing.Point(12, 245);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(137, 39);
            this.btnOrderNow.TabIndex = 3;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(12, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "Order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Width = 88;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "Cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "Cust_id";
            this.custidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.Width = 80;
            // 
            // pizzaidDataGridViewTextBoxColumn
            // 
            this.pizzaidDataGridViewTextBoxColumn.DataPropertyName = "Pizza_id";
            this.pizzaidDataGridViewTextBoxColumn.HeaderText = "Pizza_id";
            this.pizzaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pizzaidDataGridViewTextBoxColumn.Name = "pizzaidDataGridViewTextBoxColumn";
            this.pizzaidDataGridViewTextBoxColumn.Width = 86;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 84;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            this.methodDataGridViewTextBoxColumn.Width = 81;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "Total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "Total_price";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 104;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderDetails";
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSet4 dataSet41;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
    }
}