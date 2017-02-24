using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;


namespace Bleam
{
	public partial class hForm : Form
	{
        //bool fov_auto = System.Convert.ToBoolean(Auto_FOV_CheckedChanged());
        Memory oMemory = new Memory();
        //static hForm Form;
        //Process[] aProcesses = Process.GetProcessesByName("halo5forge");
        //WorkingClassCuck WorkingCuck = new WorkingClassCuck(this);

 //       static void HaloIsRunning()
 //       {
 //           for (int i = 0; i < 0; i++)
 //           {
 //               Process[] pname = Process.GetProcessesByName("Halo5Forge");
 //               if (pname.Length == 0)
 //               {
 //
 //               }else if(Auto_FOV_CheckedChanged())
 //               {
 //                   var timer = new System.Threading.Timer(e => Form.FOV_Set(), null, TimeSpan.Zero, TimeSpan.FromMinutes(2));
 //               }
 //           }
 //       }
        
        public hForm()
		{
			InitializeComponent();
		}

        private void hForm_Load(object sender, EventArgs e)
        {

        }


    }
}
