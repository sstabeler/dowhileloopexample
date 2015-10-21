using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhileloopexample
{
    public partial class FrmNewton : Form
    {
        public FrmNewton()
        {
            InitializeComponent();
        }

        private void btnCalculate_MouseClick(object sender, MouseEventArgs e)
        {
            const double dblAccuracy = 1.0e-3;
            double dblRoot, dblOld, dblNew;

            dblNew = 1.0;

            dblRoot = Convert.ToDouble(txtInput.Text);

            do
            {
                dblOld = dblNew;

                dblNew = ((dblRoot/dblOld) +dblOld)/2.0;
            } while(Math.Abs(dblOld-dblNew) > dblAccuracy);
            txtActual.Text = dblNew.ToString();
            txtBuiltIn.Text = (Math.Sqrt(dblRoot)).ToString();
        }
    }
}
