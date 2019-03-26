using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class CheckBoxGroup : CheckedListBox
    {
        public CheckBoxGroup()
        {
            SelectedIndexChanged += CheckBoxGroup_SelectedIndexChanged;
        }

        void CheckBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelected(); // Make the higlight go away, we just want the checked state
        }
    }
}
