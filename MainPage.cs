using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GwentTracker
{
    public sealed partial class MainPage : Form
    {
        private readonly PrivateFontCollection _pfc = new PrivateFontCollection();
        private readonly IntPtr _fontPtr = Marshal.AllocHGlobal(Properties.Resources.hinted_GWENT_ExtraBold.Length);
        //private CurrentScores _currentScores = new CurrentScores();

        public MainPage()
        {
            BackgroundImage = Properties.Resources.Background;
            InitializeComponent();
            KeyPreview = true;

            MessageBoxManager.Cancel = "Neither";
            MessageBoxManager.Yes = "Player One";
            MessageBoxManager.No = "Player Two";
            MessageBoxManager.Register();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Marshal.Copy(Properties.Resources.hinted_GWENT_ExtraBold, 0, _fontPtr,
                Properties.Resources.hinted_GWENT_ExtraBold.Length);

            _pfc.AddMemoryFont(_fontPtr, Properties.Resources.hinted_GWENT_ExtraBold.Length);

            var labels = Controls
                .OfType<Label>()
                .Where(label => label.Name.StartsWith("lbl"));

            foreach (var label in labels)
            {
                label.Font = new Font(_pfc.Families[0], label.Font.Size);
            }

            var textBoxes = Controls
                .OfType<RichTextBox>()
                .Where(textBox => textBox.Name.StartsWith("txt"));

            foreach (var textBox in textBoxes)
            {
                textBox.SelectAll();
                textBox.SelectionAlignment = HorizontalAlignment.Center;
                textBox.DeselectAll();
                textBox.Text = @"0";
            }
        }

        private void lblCalculate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lblPlayerOneMeleeTotal.Text = (Convert.ToInt32(txtPlayerOneHeroMelee.Text) +
                                               Convert.ToInt32(txtPlayerOneRegMelee.Text)).ToString();
                lblPlayerOneRangeTotal.Text = (Convert.ToInt32(txtPlayerOneHeroRange.Text) +
                                               Convert.ToInt32(txtPlayerOneRegRange.Text)).ToString();
                lblPlayerOneSiegeTotal.Text = (Convert.ToInt32(txtPlayerOneHeroSiege.Text) +
                                               Convert.ToInt32(txtPlayerOneRegSiege.Text)).ToString();
                lblPlayerOneTotal.Text = (Convert.ToInt32(txtPlayerOneHeroMelee.Text) +
                                          Convert.ToInt32(txtPlayerOneRegMelee.Text) +
                                          Convert.ToInt32(txtPlayerOneHeroRange.Text) +
                                          Convert.ToInt32(txtPlayerOneRegRange.Text) +
                                          Convert.ToInt32(txtPlayerOneHeroSiege.Text) +
                                          Convert.ToInt32(txtPlayerOneRegSiege.Text)).ToString();

                lblPlayerTwoMeleeTotal.Text = (Convert.ToInt32(txtPlayerTwoHeroMelee.Text) +
                                               Convert.ToInt32(txtPlayerTwoRegMelee.Text)).ToString();
                lblPlayerTwoRangeTotal.Text = (Convert.ToInt32(txtPlayerTwoHeroRange.Text) +
                                               Convert.ToInt32(txtPlayerTwoRegRange.Text)).ToString();
                lblPlayerTwoSiegeTotal.Text = (Convert.ToInt32(txtPlayerTwoHeroSiege.Text) +
                                               Convert.ToInt32(txtPlayerTwoRegSiege.Text)).ToString();
                lblPlayerTwoTotal.Text = (Convert.ToInt32(txtPlayerTwoHeroMelee.Text) +
                                          Convert.ToInt32(txtPlayerTwoRegMelee.Text) +
                                          Convert.ToInt32(txtPlayerTwoHeroRange.Text) +
                                          Convert.ToInt32(txtPlayerTwoRegRange.Text) +
                                          Convert.ToInt32(txtPlayerTwoHeroSiege.Text) +
                                          Convert.ToInt32(txtPlayerTwoRegSiege.Text)).ToString();
            }
            catch (Exception exception)
            {
                if (exception.Message == "Value was either too large or too small for an Int32.")
                {
                    MessageBox.Show(@"Nice score. Must be the Skellige deck.");
                }
                else
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void lblEndRound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCalculate_LinkClicked(null,null);

            if (Convert.ToInt32(lblPlayerOneTotal.Text) > Convert.ToInt32(lblPlayerTwoTotal.Text))
            {
                var newScore = Convert.ToInt32(
                    lblPlayerOne.Text.Substring(lblPlayerOne.Text.LastIndexOf(" ", StringComparison.Ordinal) + 1)) + 1;
                lblPlayerOne.Text = $@"PLAYER ONE : {newScore}";

            }
            else if (Convert.ToInt32(lblPlayerTwoTotal.Text) > Convert.ToInt32(lblPlayerOneTotal.Text))
            {
                var newScore = Convert.ToInt32(
                    lblPlayerTwo.Text.Substring(lblPlayerTwo.Text.LastIndexOf(" ", StringComparison.Ordinal) + 1)) + 1;
                lblPlayerTwo.Text = $@"PLAYER TWO : {newScore}";

            }
            else
            {
                var dialogResult = MessageBox.Show(@"Does either player win the draw?", @"DRAW!", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    var newScore = Convert.ToInt32(
                        lblPlayerOne.Text.Substring(lblPlayerOne.Text.LastIndexOf(" ", StringComparison.Ordinal) + 1)) + 1;
                    lblPlayerOne.Text = $@"PLAYER ONE : {newScore}";
                }
                else if (dialogResult == DialogResult.No)
                {
                    var newScore = Convert.ToInt32(
                        lblPlayerTwo.Text.Substring(lblPlayerTwo.Text.LastIndexOf(" ", StringComparison.Ordinal) + 1)) + 1;
                    lblPlayerTwo.Text = $@"PLAYER TWO : {newScore}";
                }
            }

            var textBoxes = Controls
                .OfType<RichTextBox>()
                .Where(textBox => textBox.Name.StartsWith("txt"));

            foreach (var textBox in textBoxes)
            {
                textBox.Text = @"0";
            }

            lblPlayerOneMeleeTotal.Text = @"0";
            lblPlayerOneRangeTotal.Text = @"0";
            lblPlayerOneSiegeTotal.Text = @"0";
            lblPlayerOneTotal.Text = @"0";

            lblPlayerTwoMeleeTotal.Text = @"0";
            lblPlayerTwoRangeTotal.Text = @"0";
            lblPlayerTwoSiegeTotal.Text = @"0";
            lblPlayerTwoTotal.Text = @"0";
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pfc.Families[0].Dispose();
            _pfc.Dispose();
            Marshal.FreeCoTaskMem(_fontPtr);
        }

        #region Handle Key Strokes

        private void HandleKeyPress(KeyPressEventArgs e, string txtName)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            var textBoxes = Controls
                .OfType<RichTextBox>()
                .Where(textBox => textBox.Name.StartsWith("txt"));

            foreach (var textBox in textBoxes)
            {
                if (textBox.Text != "") continue;
                textBox.Text = @"0";
                textBox.SelectionStart = 0;
                textBox.SelectionLength = textBox.Text.Length;

                //if (textBox.Name == txtName && char.IsDigit(e.KeyChar) && textBox.Text == "0")
                //{
                //    textBox.Text = e.KeyChar.ToString();
                //}
                //else if (textBox.Name == txtName && char.IsDigit(e.KeyChar) && textBox.Text != "0")
                //{
                //    textBox.Text += e.KeyChar.ToString();
                //}
            }

            //if (e.Handled || char.IsControl(e.KeyChar))
            //    return;

            //_currentScores = new CurrentScores
            //{
            //    PlayerOneMeleeTotal = Convert.ToInt32(txtPlayerOneHeroMelee.Text) +
            //                          Convert.ToInt32(txtPlayerOneRegMelee.Text),

            //    PlayerOneRangeTotal = Convert.ToInt32(txtPlayerOneHeroRange.Text) +
            //                          Convert.ToInt32(txtPlayerOneRegRange.Text),

            //    PlayerOneSiegeTotal = Convert.ToInt32(txtPlayerOneHeroSiege.Text) +
            //                          Convert.ToInt32(txtPlayerOneRegSiege.Text),

            //    PlayerOneTotal = Convert.ToInt32(txtPlayerOneHeroMelee.Text) +
            //                     Convert.ToInt32(txtPlayerOneRegMelee.Text) +
            //                     Convert.ToInt32(txtPlayerOneHeroRange.Text) +
            //                     Convert.ToInt32(txtPlayerOneRegRange.Text) +
            //                     Convert.ToInt32(txtPlayerOneHeroSiege.Text) +
            //                     Convert.ToInt32(txtPlayerOneRegSiege.Text),

            //    PlayerTwoMeleeTotal = Convert.ToInt32(txtPlayerTwoHeroMelee.Text) +
            //                          Convert.ToInt32(txtPlayerTwoRegMelee.Text),

            //    PlayerTwoRangeTotal = Convert.ToInt32(txtPlayerTwoHeroRange.Text) +
            //                          Convert.ToInt32(txtPlayerTwoRegRange.Text),

            //    PlayerTwoSiegeTotal = Convert.ToInt32(txtPlayerTwoHeroSiege.Text) +
            //                          Convert.ToInt32(txtPlayerTwoRegSiege.Text),

            //    PlayerTwoTotal = Convert.ToInt32(txtPlayerTwoHeroMelee.Text) +
            //                     Convert.ToInt32(txtPlayerTwoRegMelee.Text) +
            //                     Convert.ToInt32(txtPlayerTwoHeroRange.Text) +
            //                     Convert.ToInt32(txtPlayerTwoRegRange.Text) +
            //                     Convert.ToInt32(txtPlayerTwoHeroSiege.Text) +
            //                     Convert.ToInt32(txtPlayerTwoRegSiege.Text)
            //};

            ////var bwCalculateScore = new BackgroundWorker();
            ////bwCalculateScore.RunWorkerCompleted += bwCalculateScore_RunWorkerCompleted;
            ////bwCalculateScore.DoWork += bwCalculateScore_DoWork;
            ////bwCalculateScore.RunWorkerAsync();

            //lblPlayerOneMeleeTotal.Text = _currentScores.PlayerOneMeleeTotal.ToString();
            //lblPlayerOneRangeTotal.Text = _currentScores.PlayerOneRangeTotal.ToString();
            //lblPlayerOneSiegeTotal.Text = _currentScores.PlayerOneSiegeTotal.ToString();
            //lblPlayerOneTotal.Text = _currentScores.PlayerOneTotal.ToString();

            //lblPlayerTwoMeleeTotal.Text = _currentScores.PlayerTwoMeleeTotal.ToString();
            //lblPlayerTwoRangeTotal.Text = _currentScores.PlayerTwoRangeTotal.ToString();
            //lblPlayerTwoSiegeTotal.Text = _currentScores.PlayerTwoSiegeTotal.ToString();
            //lblPlayerTwoTotal.Text = _currentScores.PlayerTwoTotal.ToString();
        }

        private void bwCalculateScore_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bwCalculateScore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(sender is BackgroundWorker worker)) return;
            worker.RunWorkerCompleted -= bwCalculateScore_RunWorkerCompleted;
            worker.DoWork -= bwCalculateScore_DoWork;
            worker.Dispose();
        }

        private void txtPlayerOneHeroSiege_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerOneRegSiege_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerOneHeroRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerOneRegRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerOneHeroMelee_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerOneRegMelee_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoHeroMelee_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoRegMelee_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoHeroRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoRegRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoHeroSiege_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        private void txtPlayerTwoRegSiege_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(e,((RichTextBox)sender).Name);
        }

        #endregion
    }
}
