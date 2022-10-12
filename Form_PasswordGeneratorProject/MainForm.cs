using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Form_PasswordGeneratorProject {
    public partial class MainForm : Form {
        private PasswordGenerator _generator = new PasswordGenerator();
        public MainForm() {
            InitializeComponent();
            Start();
            Clock.Instance.Tick += Update;

        }
        
        private void Start() {
            
        }
        
        private void Update(object sender, EventArgs e) {
            passwordLength_textBox.Text = passwordLength_trackBar.Value.ToString();
        }

        private void copyPassword_button_Click(object sender, EventArgs e) {
            
            Clipboard.SetText(generatedPassword_textBox.Text);
        }

        private void generatePassword_button_Click(object sender, EventArgs e) {
            if (includeSymbols_checkBox.Checked == false && includeNumbers_checkBox.Checked == false && includeUppercase_checkBox.Checked == false && includeLowercase_checkBox.Checked == false) {
                MessageBox.Show(@"You need to select at least one of the include options.", @"ERROR!",
                    MessageBoxButtons.OKCancel);
            }
            else {
                PasswordContext passwordContext = new PasswordContext(passwordLength_trackBar.Value,
                                includeSymbols_checkBox.Checked, includeNumbers_checkBox.Checked, includeLowercase_checkBox.Checked,
                                includeUppercase_checkBox.Checked, excludeSimilar_checkBox.Checked, excludeAmbiguous_checkBox.Checked);
                var password = _generator.GeneratePassword(passwordContext);
                generatedPassword_textBox.Text = password;
            }
            

        }
    }
}