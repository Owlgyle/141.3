using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ContractImport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=Romeo;Initial Catalog=Royal;User ID=royal;password=wkjwuq");
        SqlDataReader rdr = null;

        struct company_list
        {
            public int id, listIndex;
            public string name;
        };

        struct location_list
        {
            public int id, listIndex;
            public string name;
        };

        List<company_list> companies = new List<company_list>();
        List<location_list> locations = new List<location_list>();

        bool fileSelected = false;
        int companyListIndex = -1;
        string fileName, fullPathToFile;

        public ContractImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.selectFile.IsDisposed)
                Form1.selectFile = new OpenFile();

            Form1.selectFile.ShowDialog();

            if (Form1.selectFile.returnStatus)
            {
                fullPathToFile = Form1.selectFile.selectedFile.Trim();
                if (!File.Exists(fullPathToFile))
                {
                    MessageBox.Show("File not found.");
                    return;
                }
                fileName = Path.GetFileName(fullPathToFile);

                label1.Text = "File to upload: " + fileName;
                buttonImport.Enabled = true;
                fileSelected = true;
            }
        }

        void Display_Results(string results)
        {
        }

        private void ContractImport_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            company_list company;

            Clear_File_Selection();

            companies.Clear();
            companyList.Items.Clear();

            conn.Open();
            cmd = new SqlCommand("select * from company where active <> 0 order by name asc", conn);
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
                while (rdr.Read())
                {
                    rdr.Read();
                    company.id = Convert.ToInt32(rdr["ct"].ToString());
                    company.name = rdr["name"].ToString().Trim();
                    company.listIndex = companyList.Items.Count;
                    companies.Add(company);
                    companyList.Items.Add(company.name);
                }

            rdr.Close();
            if (companyList.Items.Count > 0)
                companyList.SelectedIndex = 0;
            Company_Changed();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            int x, y = 0;
            string results;

            if (!fileSelected)
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            if (!File.Exists(fullPathToFile))
            {
                MessageBox.Show("File not found.");
                Clear_File_Selection();
                return;
            }

            while (File.Exists(Form1.contractUploadPath + fileName) && y < 20)
            {
                fileName = "a" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.DayOfYear.ToString() + fileName;
                ++y;
            }
            if (File.Exists(Form1.contractUploadPath + fileName))
            {
                MessageBox.Show("Error: File exists on the server. Please delete before proceeding.\n\n" + Form1.contractUploadPath + fileName);
                return;
            }

            File.Copy(fullPathToFile, Form1.contractUploadPath + fileName);


            string strData = "Fname=" + util_functions.urlEncoded(fileName);

            results = util_functions.Post_Web_Form("/admin/vb_Contract_Load.cfm", strData);

            x = results.IndexOf("<>");
            if (x >= 0 && results.Length > x + 2)
            {
                results = results.Substring(x + 2, results.Length - x - 2);
                if (results.Trim().Length > 0)
                    Display_Results(results);
                else
                    MessageBox.Show("No data returned\n\n" + results);
            }
            else
                MessageBox.Show("Invalid response.  Please check the import file's content and try again.\n\n" + results);

            Clear_File_Selection();
        }

        void Clear_File_Selection()
        {
            fileSelected = false;
            buttonImport.Enabled = false;
            label1.Text = "No File Selected.";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    qty.Focus();
        }

        private void cnum_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;

            locationLabel.Text = "";

            try
            {
                if (util_functions.isnumeric(cNum.Text))
                {
                    cmd = new SqlCommand("select * from location where customernum='" + cNum.Text + "' and active<>0", conn);
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows && rdr.Read())
                        locationLabel.Text = rdr["name"].ToString();
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("An error has occured while loading the customer information.\n\n" + e1.Message);
            }

            if (rdr != null)
                rdr.Close();
        }

        void Company_Changed()
        {
            int newCompany;

            newCompany = companyList.SelectedIndex;
            if (newCompany != companyListIndex)
            {
                locations.Clear();
                locationList.Items.Clear();
            }
            companyListIndex = newCompany;
        }
    }
}
