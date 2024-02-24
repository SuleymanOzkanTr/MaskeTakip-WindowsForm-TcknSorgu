using Business.Concrete;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        PersonManager business = new PersonManager();
        public Person person1 = new Person();
        public PttManager ptt = new PttManager(new PersonManager());

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pbxSonucWrong.Visible = false;
            pbxSorguQuestion.Visible = true;
            pbxSorguTrue.Visible = false;
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            try
            {
                person1.FirstName = tbxFirstName.Text.Trim();
                person1.LastName = tbxLastName.Text.Trim();
                person1.NationalIdentity = Convert.ToInt64(tbxNationalIdentity.Text.Trim());
                person1.DateOfBirthYear = Convert.ToInt32(tbxBirthOfYear.Text.Trim());
                bool isPersonValid = business.CheckPerson(person1);
                if (isPersonValid)
                {
                    pbxSonucWrong.Visible = false;
                    pbxSorguQuestion.Visible = false;
                    pbxSorguTrue.Visible = true;
                    
                }
                else
                {
                    pbxSonucWrong.Visible = true;
                    pbxSorguQuestion.Visible = false;
                    pbxSorguTrue.Visible = false;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Boş Alanaları Doldurunuz", "HATA", MessageBoxButtons.OK);
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            string text = tbxLastName.Text;
            string filteredText = string.Empty;
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    filteredText += c;
                }
            }
            tbxLastName.Text = filteredText;
            tbxLastName.SelectionStart = tbxLastName.Text.Length; // ımleci metin sonuna taşı

            /* if (!int.TryParse(tbxLastName.Text, out _))
           {
               tbxLastName.Text = ""; // Sayı dışındaki karakterleri sil
           }*/
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sayısal karakterleri engelle
            }
        }
    }
}