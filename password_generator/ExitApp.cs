using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public sealed class ExitApp : Form
    {

        private static void CheckLabel(Form form)
        {
            Label checkLabel = new Label();
            checkLabel.Text = "Are you sure you want to exit?";
            checkLabel.Anchor = AnchorStyles.None;
            checkLabel.AutoSize = true;
            checkLabel.Font = new Font("Arial Rounded MT Bold", 22.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkLabel.RightToLeft = RightToLeft.No;
            checkLabel.Size = new Size(450, 40);
            checkLabel.Location = new Point((form.Width - checkLabel.Width) / 2, (form.Height /6) );
            form.Controls.Add(checkLabel);
        }

        private static void YesBtn(Form form)
        {
            Button yesBtn = new Button();
            yesBtn.Text = "YES";
            yesBtn.Anchor = AnchorStyles.None;
            yesBtn.BackColor = Color.Pink;
            yesBtn.AutoSize = false;
            yesBtn.Cursor = Cursors.Hand;
            yesBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            yesBtn.Size = new Size(200, 75);
            yesBtn.Location = new Point(((form.Width - yesBtn.Width) / 2) - 150, (form.Height / 3));
            yesBtn.TabIndex = 1;
            yesBtn.Click += (sender, e) => AppControls.Exit();
            form.Controls.Add(yesBtn); ;
        }

        private static void NoBtn(Form form)
        {
            Button noBtn = new Button();
            noBtn.Text = "NO";
            noBtn.Anchor = AnchorStyles.None;
            noBtn.BackColor = Color.Pink;
            noBtn.AutoSize = false;
            noBtn.Cursor = Cursors.Hand;
            noBtn.Font = new Font("Arial Nova Cond", 14.25F, FontStyle.Bold);
            noBtn.Size = new Size(200, 75);
            noBtn.Location = new Point(((form.Width - noBtn.Width) / 2) + 150 , (form.Height / 3)); 
            noBtn.TabIndex = 2;
            noBtn.Click += (sender, e) => MainWin.MainWinForm(form);
            form.Controls.Add(noBtn);

        }

        public static void ExitAppForm(Form form)
            {
            AppControls.HideAllBtns(form);
                CheckLabel(form);
                YesBtn(form);
                NoBtn(form);

        }
    }
}
