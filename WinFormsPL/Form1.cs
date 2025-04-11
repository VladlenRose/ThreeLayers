using BL;
using DL.Repository;
using DL.Softwares;

namespace WinFormsPL
{
    public partial class Form1 : Form
    {
        private ISoftwareManager softwareManager;
        public Form1()
        {
            softwareManager = new SoftwareManager(new SoftwareRepository());
            InitializeComponent();
            InitializeComboBoxes();
            LoadSoftwares();
        }

        private void InitializeComboBoxes()
        {
            addTypeComboBox.Items.Add("���������� ��");
            addTypeComboBox.Items.Add("�������-���������� ��");
            addTypeComboBox.Items.Add("������������ ��");
            addTypeComboBox.SelectedIndex = 0;

            searchTypeComboBox.Items.Add("���");
            searchTypeComboBox.Items.Add("���������� ��");
            searchTypeComboBox.Items.Add("�������-���������� ��");
            searchTypeComboBox.Items.Add("������������ ��");
            searchTypeComboBox.SelectedIndex = 0;
        }

        private void LoadSoftwares()
        {
            var softwares = softwareManager.GetAllSoftwares();
            softwaresDataGrid.DataSource = softwares;

            foreach (DataGridViewColumn column in softwaresDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void UpdateSoftwareInfo(SoftwareBase software)
        {
            typeTextBox.Text = software.GetType().Name;
            nameTextBox.Text = software.Name;
            developerTextBox.Text = software.Developer;

            if (software is FreeSoftware)
            {
                statusTextBox.Text = "�������� ������";
                priceLabel.Visible = false;
                priceTextBox.Visible = false;
            }
            else if (software is PartlyFreeSoftware partlyFree)
            {
                statusTextBox.Text = (partlyFree.IsAvailable() ? "�������� �� " : "���������� c ") + partlyFree.ExpirationDate.ToShortDateString();
                priceLabel.Visible = false;
                priceTextBox.Visible = false;
            }
            else if (software is CommercialSoftware commercial)
            {
                statusTextBox.Text = (commercial.IsAvailable() ? "�������� �� " : "���������� � ") + commercial.ExpirationDate.ToShortDateString();
                priceTextBox.Text = commercial.Price.ToString("C");
                priceLabel.Visible = true;
                priceTextBox.Visible = true;
            }
        }

        private void softwaresDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (softwaresDataGrid.CurrentRow != null)
            {
                int ind = softwaresDataGrid.CurrentRow.Index;
                DataGridViewRow row = softwaresDataGrid.Rows[ind];
                int id = (int)row.Cells["Id"].Value;
                SoftwareBase software = softwareManager.GetSoftware(id);
                UpdateSoftwareInfo(software);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (softwaresDataGrid.CurrentRow != null)
            {
                int ind = softwaresDataGrid.CurrentRow.Index;
                DataGridViewRow row = softwaresDataGrid.Rows[ind];
                int id = (int)row.Cells["Id"].Value;

                softwareManager.RemoveSoftware(id);
                LoadSoftwares();
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "��������� ����";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    softwareManager.Save(saveFileDialog.FileName);
                    MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.Title = "��������� ����";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    softwareManager.Load(openFileDialog.FileName);
                    LoadSoftwares();
                    MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearAddFields()
        {
            addNameTextBox.Clear();
            addDeveloperTextBox.Clear();
            addDateTimePicker.Value = DateTime.Now;
            addPriceTextBox.Clear();
            addTypeComboBox.SelectedIndex = 0;
            addExpiredDateLabel.Visible = false;
            addDateTimePicker.Visible = false;
            addPriceLabel.Visible = false;
            addPriceTextBox.Visible = false;
        }

        private void addTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (addTypeComboBox.SelectedIndex)
            {
                case 0: // ���������� ��
                    addExpiredDateLabel.Visible = false;
                    addDateTimePicker.Visible = false;
                    addPriceLabel.Visible = false;
                    addPriceTextBox.Visible = false;
                    break;
                case 1: // �������-���������� ��
                    addExpiredDateLabel.Visible = true;
                    addDateTimePicker.Visible = true;
                    addPriceLabel.Visible = false;
                    addPriceTextBox.Visible = false;
                    break;
                case 2: // ������������ ��
                    addExpiredDateLabel.Visible = true;
                    addDateTimePicker.Visible = true;
                    addPriceLabel.Visible = true;
                    addPriceTextBox.Visible = true;
                    break;
            }
        }

        private void addSoftwareButton_Click(object sender, EventArgs e)
        {
            string name = addNameTextBox.Text;
            string developer = addDeveloperTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(developer))
            {
                MessageBox.Show("����������, ��������� ��� ������������ ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SoftwareBase newSoftware = null;
            try
            {
                switch (addTypeComboBox.SelectedIndex)
                {
                    case 0: // ���������� ��
                        newSoftware = new FreeSoftware(name, developer);
                        break;
                    case 1: // �������-���������� ��
                        DateTime expirationDate = addDateTimePicker.Value;
                        newSoftware = new PartlyFreeSoftware(name, developer, expirationDate);
                        break;
                    case 2: // ������������ ��
                        DateTime commercialExpirationDate = addDateTimePicker.Value;
                        double price = double.Parse(addPriceTextBox.Text);

                        if (price < 0)
                            throw new FormatException("���� �� ����� ���� �������������");

                        newSoftware = new CommercialSoftware(name, developer, commercialExpirationDate, price);
                        break;
                }

                softwareManager.AddSoftware(newSoftware);
                ClearAddFields();
                MessageBox.Show("����� �� ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSoftwares();
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ���������� �������� ��� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == mainPage)
            {
                LoadSoftwares();
            }
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            string searchName = searchNameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var foundSoftwares = softwareManager.FindSoftwaresByName(searchName);
                softwaresDataGrid.DataSource = foundSoftwares;
            }
            else
            {
                MessageBox.Show("����������, ������� �������� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void typeSearchButton_Click(object sender, EventArgs e)
        {
            Type selectedType = null;
            List<SoftwareBase> filteredSoftwares;

            switch (searchTypeComboBox.SelectedIndex)
            {
                case 1: // ���������� ��
                    selectedType = typeof(FreeSoftware);
                    break;
                case 2: // �������-���������� ��
                    selectedType = typeof(PartlyFreeSoftware);
                    break;
                case 3: // ������������ ��
                    selectedType = typeof(CommercialSoftware);
                    break;
            }

            if (selectedType != null)
            {
                if (availableCheckBox.Checked)
                {
                    filteredSoftwares = softwareManager.GetAvailableSoftwaresByType(selectedType);
                }
                else
                {
                    filteredSoftwares = softwareManager.GetSoftwaresByType(selectedType);
                }
            }
            else
            {
                if (availableCheckBox.Checked)
                {
                    filteredSoftwares = softwareManager.GetAvailableSoftwares();
                }
                else
                {
                    filteredSoftwares = softwareManager.GetAllSoftwares();
                }
            }

            softwaresDataGrid.DataSource = filteredSoftwares;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            LoadSoftwares();
        }
    }
}
