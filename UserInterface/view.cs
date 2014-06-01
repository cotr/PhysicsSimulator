using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotr.Physics.Simulator.UI
{
    public partial class view : Form
    {
        Startup SForm;
        public view()
        {
            InitializeComponent();
        }
        public view(Startup sf)
        {
            SForm = sf;
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            /*
             * To VictorZXY:
             *     Your work is to draw things in this form.
             *     You can access things by var SForm.Map, this is a map object.
             *         Coderfox
             */
        }
    }
}
