using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTextBox {
    class MyTextBox : TextBox {
        private string lastValidText = null;

        public string LastValidText { get => lastValidText; set => lastValidText = value; }
        public string LastValidText1 { get => lastValidText; set => lastValidText = value; }
    }
}
