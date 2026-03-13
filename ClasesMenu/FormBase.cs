using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesMenu
{
    public class FormBase : Form
    {
        public FormBase()
        {
            this.Load += (s, e) =>
            {
                HacerResponsivo(this.Controls);
            };

            this.Resize += (s, e) =>
            {
                this.Refresh();
            };
        }

        private void HacerResponsivo(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                              AnchorStyles.Left | AnchorStyles.Right;

                if (ctrl.HasChildren)
                    HacerResponsivo(ctrl.Controls);
            }
        }
    }
}
