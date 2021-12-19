using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine_Cipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        List<char> encryptedAlphabet = new List<char>();
        List<char> input = new List<char>();
        int keyA;
        int keyB;


        private void EncryptInputParse(List<char> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 'Á')
                {
                    this.input.Add('A');
                }
                else if (input[i] == 'Ě')
                {
                    this.input.Add('E');
                }
                else if (input[i] == 'Š')
                {
                    this.input.Add('S');
                }
                else if (input[i] == 'Č')
                {
                    this.input.Add('C');
                }
                else if (input[i] == 'Ř')
                {
                    this.input.Add('R');
                }
                else if (input[i] == 'Ž')
                {
                    this.input.Add('Z');
                }
                else if (input[i] == 'Ý')
                {
                    this.input.Add('Y');
                }
                else if (input[i] == 'Í')
                {
                    this.input.Add('I');
                }
                else if (input[i] == 'É')
                {
                    this.input.Add('E');
                }
                else if (input[i] == 'Ú')
                {
                    this.input.Add('U');
                }
                else if (input[i] == 'Ů')
                {
                    this.input.Add('U');
                }
                else if (input[i] == 'Ó')
                {
                    this.input.Add('O');
                }
                else if (input[i] == 'Ť')
                {
                    this.input.Add('T');
                }
                else if (input[i] == 'Ň')
                {
                    this.input.Add('N');
                }
                else if (input[i] == 'Ď')
                {
                    this.input.Add('D');
                }
                else if (Char.IsLetter(input[i]) == true)
                {
                    this.input.Add(input[i]);
                }
                else if (input[i] == ' ')
                {
                    this.input.Add('X');
                    this.input.Add('Y');
                    this.input.Add('Z');
                }
                else if (input[i] == '0')
                {
                    this.input.Add('X');
                    this.input.Add('N');
                    this.input.Add('U');
                    this.input.Add('L');
                    this.input.Add('A');
                    this.input.Add('X');
                }
                else if (input[i] == '1')
                {
                    this.input.Add('X');
                    this.input.Add('J');
                    this.input.Add('E');
                    this.input.Add('D');
                    this.input.Add('N');
                    this.input.Add('A');
                    this.input.Add('X');
                }
                else if (input[i] == '2')
                {
                    this.input.Add('X');
                    this.input.Add('D');
                    this.input.Add('V');
                    this.input.Add('E');
                    this.input.Add('X');
                }
                else if (input[i] == '3')
                {
                    this.input.Add('X');
                    this.input.Add('T');
                    this.input.Add('R');
                    this.input.Add('I');
                    this.input.Add('X');
                }
                else if (input[i] == '4')
                {
                    this.input.Add('X');
                    this.input.Add('C');
                    this.input.Add('T');
                    this.input.Add('Y');
                    this.input.Add('R');
                    this.input.Add('I');
                    this.input.Add('X');
                }
                else if (input[i] == '5')
                {
                    this.input.Add('X');
                    this.input.Add('P');
                    this.input.Add('E');
                    this.input.Add('T');
                    this.input.Add('X');
                }
                else if (input[i] == '6')
                {
                    this.input.Add('X');
                    this.input.Add('S');
                    this.input.Add('E');
                    this.input.Add('S');
                    this.input.Add('T');
                    this.input.Add('X');
                }
                else if (input[i] == '7')
                {
                    this.input.Add('X');
                    this.input.Add('S');
                    this.input.Add('E');
                    this.input.Add('D');
                    this.input.Add('M');
                    this.input.Add('X');
                }
                else if (input[i] == '8')
                {
                    this.input.Add('X');
                    this.input.Add('O');
                    this.input.Add('S');
                    this.input.Add('M');
                    this.input.Add('X');
                }
                else if (input[i] == '9')
                {
                    this.input.Add('X');
                    this.input.Add('D');
                    this.input.Add('E');
                    this.input.Add('V');
                    this.input.Add('E');
                    this.input.Add('T');
                    this.input.Add('X');
                }
                else if (input[i] == '.')
                {
                    this.input.Add('X');
                    this.input.Add('T');
                    this.input.Add('E');
                    this.input.Add('C');
                    this.input.Add('K');
                    this.input.Add('A');
                    this.input.Add('X');
                }
                else if (input[i] == '!')
                {
                    this.input.Add('X');
                    this.input.Add('V');
                    this.input.Add('Y');
                    this.input.Add('K');
                    this.input.Add('R');
                    this.input.Add('I');
                    this.input.Add('C');
                    this.input.Add('N');
                    this.input.Add('I');
                    this.input.Add('K');
                    this.input.Add('X');
                }
                else if (input[i] == '?')
                {
                    this.input.Add('X');
                    this.input.Add('O');
                    this.input.Add('T');
                    this.input.Add('A');
                    this.input.Add('Z');
                    this.input.Add('N');
                    this.input.Add('I');
                    this.input.Add('K');
                    this.input.Add('X');
                }
                else if (input[i] == '\n')
                {
                    this.input.Add('X');
                    this.input.Add('L');
                    this.input.Add('I');
                    this.input.Add('N');
                    this.input.Add('E');
                    this.input.Add('X');
                }
            }
        }

        private void DecryptInputParse(List<char> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == 'Á')
                {
                    this.input.Add('A');
                }
                else if (input[i] == 'Ě')
                {
                    this.input.Add('E');
                }
                else if (input[i] == 'Š')
                {
                    this.input.Add('S');
                }
                else if (input[i] == 'Č')
                {
                    this.input.Add('C');
                }
                else if (input[i] == 'Ř')
                {
                    this.input.Add('R');
                }
                else if (input[i] == 'Ž')
                {
                    this.input.Add('Z');
                }
                else if (input[i] == 'Ý')
                {
                    this.input.Add('Y');
                }
                else if (input[i] == 'Í')
                {
                    this.input.Add('I');
                }
                else if (input[i] == 'É')
                {
                    this.input.Add('E');
                }
                else if (input[i] == 'Ú')
                {
                    this.input.Add('U');
                }
                else if (input[i] == 'Ů')
                {
                    this.input.Add('U');
                }
                else if (input[i] == 'Ó')
                {
                    this.input.Add('O');
                }
                else if (input[i] == 'Ť')
                {
                    this.input.Add('T');
                }
                else if (input[i] == 'Ň')
                {
                    this.input.Add('N');
                }
                else if (input[i] == 'Ď')
                {
                    this.input.Add('D');
                }
                else if (Char.IsLetter(input[i]) == true)
                {
                    this.input.Add(input[i]);
                }
            }
        }



        private void CipherButton_Click(object sender, EventArgs e)
        {
            keyA = Convert.ToInt32(keyAUpDown.Value);
            keyB = Convert.ToInt32(keyBUpDown.Value);
            listViewAlphabet.Items.Clear();

            if (keyA == 0 || keyB == 0)
            {
                keyAUpDown.BackColor = Color.Orange;
                keyBUpDown.BackColor = Color.Orange;
                MessageBox.Show("Musíte zadat čísla různá od 0.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (keyA < 0)
                {
                    keyA *= -1;
                }

                if (keyB < 0)
                {
                    keyB *= -1;
                }

                if (Encryption.GCD(keyA, alphabet.Count) == 1)
                {
                    keyAUpDown.BackColor = SystemColors.Window;
                    keyBUpDown.BackColor = SystemColors.Window;
                    string InputToUpper = InputTextBox.Text.ToUpper();
                    EncryptInputParse(InputToUpper.ToList());
                    parsedTextBox.Text = string.Join("", input);

                    string output = Encryption.Encrypt(keyA, keyB, input, alphabet);
                    encryptedAlphabet = Encryption.EncryptedAlphabet(keyA, keyB, alphabet);

                    for (int i = 0; i < alphabet.Count; i++)
                    {
                        listViewAlphabet.Items.Add(alphabet[i].ToString()).SubItems.Add(encryptedAlphabet[i].ToString());
                    }

                    OutputTextBox.Text = output;
                    input.Clear();
                }
                else
                {
                    keyAUpDown.BackColor = Color.Red;
                    keyBUpDown.BackColor = SystemColors.Window;
                    keyAUpDown.Focus();
                    MessageBox.Show("Čísla jsou soudělná! Zadejte jiná čísla (například 97 a 271).", "FatalError", MessageBoxButtons.OK);
                }        
            }
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            keyA = Convert.ToInt32(keyAUpDown.Value);
            keyB = Convert.ToInt32(keyBUpDown.Value);
            listViewAlphabet.Items.Clear();

            if (keyA == 0 || keyB == 0)
            {
                keyAUpDown.BackColor = Color.Orange;
                keyBUpDown.BackColor = Color.Orange;
                MessageBox.Show("Musíte zadat čísla různá od 0.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (keyA < 0)
                {
                    keyA *= -1;
                }

                if (keyB < 0)
                {
                    keyB *= -1;
                }

                if (Encryption.GCD(keyA, alphabet.Count) == 1)
                {
                    keyAUpDown.BackColor = SystemColors.Window;
                    keyBUpDown.BackColor = SystemColors.Window;
                    string InputToUpper = InputTextBox.Text.ToUpper();
                    DecryptInputParse(InputToUpper.ToList());


                    int MMI = Encryption.MMI(keyA, alphabet.Count);
                    if (MMI != 0)
                    {
                        string output = Encryption.Decrypt(keyB, MMI, input, alphabet);
                        string inBetween = Encryption.DecryptInBetween(keyB, MMI, input, alphabet);

                        encryptedAlphabet = Encryption.EncryptedAlphabet(keyA, keyB, alphabet);

                        for (int i = 0; i < alphabet.Count; i++)
                        {
                            listViewAlphabet.Items.Add(alphabet[i].ToString()).SubItems.Add(encryptedAlphabet[i].ToString());
                        }

                        OutputTextBox.Text = output;
                        parsedTextBox.Text = inBetween;
                        input.Clear();
                    }
                }
                else
                {
                    keyAUpDown.BackColor = Color.Red;
                    keyBUpDown.BackColor = SystemColors.Window;
                    keyAUpDown.Focus();
                    MessageBox.Show("Čísla jsou soudělná! Zadejte jiné čísla (například 97 a 271).", "FatalError", MessageBoxButtons.OK);
                }
            }
        }


        private void ButtonReset_Click(object sender, EventArgs e)
        {
            keyAUpDown.Value = 0;
            keyBUpDown.Value = 0;
            OutputTextBox.Clear();
            InputTextBox.Clear();
            keyA = 0;
            keyB = 0;
            List<char> input = new List<char>();
            listViewAlphabet.Items.Clear();
            parsedTextBox.Clear();
            keyAUpDown.BackColor = SystemColors.Window;
            keyBUpDown.BackColor = SystemColors.Window;
        }


        private void NumericUpDownB_Enter(object sender, EventArgs e)
        {
            keyBUpDown.Select(0, keyBUpDown.Text.Length);
        }

        private void NumericUpDownA_Enter(object sender, EventArgs e)
        {
            keyAUpDown.Select(0, keyAUpDown.Text.Length);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
