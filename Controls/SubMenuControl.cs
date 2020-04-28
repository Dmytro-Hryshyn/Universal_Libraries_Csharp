using System.Windows.Forms;

namespace ModernUiDesign.Controls
{
  public  class SubMenuContol   
    {
        public SubMenuContol(Button perentButton, Panel subMenuPanel)
        {
            LoadSudeMenu(subMenuPanel);
            perentButton.Click+=(sender,e)=> ShowSubMenu(subMenuPanel);
            HideSubMenu(subMenuPanel);
            HideSubMenuOnButtonClick(subMenuPanel);

        }
        /// <summary>
        /// Loads SubMenu panels to default condition [Name of SubMenu Panel].Visible=false.
        /// New SubMenu Panels needs to be adeed here.
        /// </summary>
      private  void LoadSudeMenu(Panel subMenuPanel)
        {
            subMenuPanel.Visible = false;
        }

        /// <summary>
        /// Hiding sub menu Panel if sub menu Panel is visible.
        /// </summary>
        /// <param name="panel"></param>
     private   void HideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
        }

        /// <summary>
        /// Set foreach button click event and asign to it Hidesubmenu method
        /// </summary>
        /// <param name="panel"></param>
      private  void  HideSubMenuOnButtonClick(Panel panel)
        {
            foreach (Button button in panel.Controls)
            {
                button.Click += (sender, EventArgs) => HideSubMenu(panel);
            }
        }


        private    void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else
            {
                HideSubMenu(panel);
            }
        }

        private Form activeForm = null;
        /// <summary>
        /// Open Child Form on ChildForm panel
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="ChildForm_Panel"></param>
        public  void OpenChildForm(Form childForm, Panel ChildForm_Panel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildForm_Panel.Controls.Add(childForm);
            ChildForm_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
