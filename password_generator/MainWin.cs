using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public class MainWin : Form
    {

        private static void GenerateButton(Form form)
        {
            Button GeneratePasswordBtn = new Button();
            GeneratePasswordBtn.Anchor = AnchorStyles.None;
            GeneratePasswordBtn.AutoSize = false;
            GeneratePasswordBtn.Size = new Size(200, 75); // Pevná velikost
            GeneratePasswordBtn.BackColor = Color.Pink;
            GeneratePasswordBtn.Cursor = Cursors.Hand;
            GeneratePasswordBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GeneratePasswordBtn.Location = new Point((form.Width - GeneratePasswordBtn.Width) / 2, (form.Height / 6)+50);
            GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            GeneratePasswordBtn.Text = "Generate Password";
            GeneratePasswordBtn.UseVisualStyleBackColor = false;
            GeneratePasswordBtn.RightToLeft = RightToLeft.No;
            form.Controls.Add(GeneratePasswordBtn);

        }

        private static void MyPasswords(Form form)
        {
            Button MyPasswordsBtn = new Button();
            MyPasswordsBtn.Anchor = AnchorStyles.None;
            MyPasswordsBtn.Size = new Size(200, 75); // Pevná velikost
            MyPasswordsBtn.BackColor = Color.Pink;
            MyPasswordsBtn.Cursor = Cursors.Hand;
            MyPasswordsBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            MyPasswordsBtn.Location = new Point((form.Width - MyPasswordsBtn.Width) / 2, (form.Height / 6)+150 );
            MyPasswordsBtn.Name = "MyPasswordsBtn";
            MyPasswordsBtn.Text = "My Passwords";
            MyPasswordsBtn.UseVisualStyleBackColor = false;
            MyPasswordsBtn.AutoSize = false;
            MyPasswordsBtn.RightToLeft = RightToLeft.No;
            form.Controls.Add(MyPasswordsBtn);

        }

        private static void ExitBtn(Form form)
        {
            Button ExitBtn = new Button();
            ExitBtn.Anchor = AnchorStyles.None;
            ExitBtn.Size = new Size(200, 75); // Pevná velikost
            ExitBtn.BackColor = Color.Pink;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            ExitBtn.Location = new Point((form.Width - ExitBtn.Width) / 2, (form.Height / 6) +250); ;
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Text = "Exit";
            ExitBtn.AutoSize = false;
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.RightToLeft = RightToLeft.No;
            ExitBtn.Click += (sender, e) => ExitApp.ExitAppForm(form);
            form.Controls.Add(ExitBtn);

        }
        private static void PasswordGeneratorLabel(Form form)
        {
            
            Label PasswordGeneratorLabel = new Label();
            PasswordGeneratorLabel.AutoSize = true;
            PasswordGeneratorLabel.Anchor = AnchorStyles.None;
            PasswordGeneratorLabel.Font = new Font("Arial Rounded MT Bold", 28.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordGeneratorLabel.Name = "PasswordGeneratorLabel";
            PasswordGeneratorLabel.Size = new Size(458, 40);
            PasswordGeneratorLabel.Location = new Point((form.Width - PasswordGeneratorLabel.Width) / 2, (form.Height / 10));

            PasswordGeneratorLabel.Text = "PASSWORD GENERATOR";
            form.Controls.Add(PasswordGeneratorLabel);
        }

        public static void MainWinForm(Form form)
        {
            AppControls.HideAllBtns(form);

            PasswordGeneratorLabel(form);

            GenerateButton(form);

            MyPasswords(form);

            ExitBtn(form);
        }


    }
}
