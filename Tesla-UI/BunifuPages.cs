using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruvous_email_parser
{
    class BunifuPages : TabControl
    {
        public BunifuPages()
        {
            if (!this.DesignMode) this.Multiline = true;
            this.Alignment = TabAlignment.Bottom;
        }

        

        public void setPage(string page,bool byName=false)
        {
            foreach (TabPage curPage in TabPages)
            {
                if (byName)
                {
                    if (curPage.Name.ToLower() == page.ToLower().Trim())
                    {
                        this.SelectedTab = curPage;
                        return;
                    }
                }
                else
                {
                    if (curPage.Text.ToLower().Trim() == page.ToLower().Trim())
                    {

                        this.SelectedTab = curPage;
                        return;
                    }
                }            
            }
        }


        public void setPageByIndex(int index)
        {
            try
            {
                this.SelectedIndex = index;
            }
            catch (Exception)
            {
                 
            }
        }



        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !this.DesignMode)
                m.Result = new IntPtr(1);
            else
                base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TabControlWithoutHeader
            // 
            this.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ResumeLayout(false);

        }
    }
}
