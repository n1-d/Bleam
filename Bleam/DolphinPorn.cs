using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Bleam;

namespace Bleam
{
    public class DolphinPorn : hForm
    {
        //bool fov_auto = System.Convert.ToBoolean(Auto_FOV_CheckedChanged());
        //public FancyShmancy FancyShmancy; 
        Memory oMemory = new Memory();
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

        public DolphinPorn()
        {
         
        }


        //public static bool Auto_FOV_CheckedChanged()
        //{
        //Commented out because I triggered someone.
        //new Form();
        //bool fov_auto = System.Convert.ToBoolean(Form.Auto_FOV.Checked);
        //return fov_auto;
        //}


        public void Max_FPS_Click(object sender, EventArgs e)
        {
            //THIS IS MAX FPS SHIT 1000000/120=8333
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                long FPS_Address_1 = oMemory.BaseAddressD() + Addr.ToDec("349E970");
                long FPS_Address_2 = oMemory.BaseAddressD() + Addr.ToDec("349E980");
                long FPS_Address_3 = oMemory.BaseAddressD() + Addr.ToDec("34B8C90");

                string maxfpsmaybe = Convert.ToString(1000000 / MaxFPSValue.Value);

                decimal maxfpsvaluekek = Math.Round(decimal.Parse(maxfpsmaybe));

                int thisisit = (int)maxfpsvaluekek;

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(thisisit);


                oMemory.Write((IntPtr)FPS_Address_1, bValue_To_Write, out bytesWritten);
                oMemory.Write((IntPtr)FPS_Address_2, bValue_To_Write, out bytesWritten);
                oMemory.Write((IntPtr)FPS_Address_3, bValue_To_Write, out bytesWritten);

                oMemory.CloseHandle();
            }
        }


        public void Set_Widescreen_Fix_Click(object sender, EventArgs e)
        {
            //HACKS
            // ThisWillError:^) SEARCH FOR THE FUCKING SHITTY RESOLUTION READ IT THO SO YA DON"T NEED TOO."
            //THIS IS MAX FPS SHIT 1000000/120=8333
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                long Widescreen_Addi1 = oMemory.BaseAddressD() + Addr.ToDec("4EE0AC8");
                long Widescreen_Addi2 = oMemory.BaseAddressD() + Addr.ToDec("4EE0A90");


                decimal WS_Height = Math.Round(decimal.Parse(Convert.ToString(Widescreen_Height.Value)));
                int int_ws = (int)WS_Height;
                int shit = 0;
                //int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(int_ws);
                oMemory.Write((IntPtr)Widescreen_Addi1, bValue_To_Write, out shit);
                oMemory.Write((IntPtr)Widescreen_Addi2, bValue_To_Write, out shit);
                oMemory.CloseHandle();



            }
        }

        /*
        private void Set_Widescreen_Fix_Click(object sender, EventArgs e)
        {
            //HACKS
            // ThisWillError:^) SEARCH FOR THE FUCKING SHITTY RESOLUTION READ IT THO SO YA DON"T NEED TOO."
            //THIS IS MAX FPS SHIT 1000000/120=8333
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                string[] Widescreen_Addresses = new string[] { "6188AC", "7DEDF4", "82A5B8", "82B964", "8F0890", "8F09C4", "A389F8", "A38BF8", "A38DF8", "A38FF8",
                    "AC80A4", "AC80B0", "B5AEFC", "111FEE0", "1453318", "1481128", "15C1898", "15C7330", "15DDAFC", "15F2E0C",
                    "170348C", "1B6673C", "1DA5EB8", "1E2D7B4", "1E4303C", "1E4FA7C", "1E79DBC", "1E82CCC", "1E92FB8", "1F2BD68",
                    "21B2228", "21C9754", "22093AC", "2226FA0", "2227110", "2227268", "222754C", "23BF720", "23BF72C", "261B730",
                    "26AB830", "2795F90", "2796E5C", "279CF30", "2A24A60", "2C59974", "2CEE5F8", "2DCC734", "2DCC7F8", "2E80A34",
                    "2EBA988", "3002B44", "307A4D4", "391D070", "399725C", "3999AA4", "3999AAC", "3DC779C", "3DC7804", "3DC78A4",
                    "3DC790C", "464D050", "464D06C", "4E6A884", "4E96E80", "4E97F60", "4E97F6C", "4E97F84", "4E97F98", "4E98144",
                    "4ECCCB0", "4EF50E0", "58DCFA8", "5AB2798", "63A1F00", "643C684", "643C744", "64B2C08", "64D38A8", "6509D9C" };


                List<long> WS_Long_Addies = new List<long>();

                foreach (string dong in Widescreen_Addresses)
                {
                    long convert;
                    if (long.TryParse(dong, out convert))
                    {
                        Console.WriteLine(convert);
                        WS_Long_Addies.Add(oMemory.BaseAddressD() + Addr.ToDec(System.Convert.ToString(convert)));
                    }
                }

                long[] Widescreen_Addies = WS_Long_Addies.ToArray();

                //Console.WriteLine(Widescreen_Addies);

                //   long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("58ECF90");



                decimal WS_Height = Math.Round(decimal.Parse(Convert.ToString(Widescreen_Height.Value)));
                int int_ws = (int)WS_Height;

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(int_ws);
                for (int i = 0; i < 82; i++)
                {
                    oMemory.Write((IntPtr)Widescreen_Addies[i], bValue_To_Write, out bytesWritten);


                }
                oMemory.CloseHandle();
            }
        }
        */
        /*
        private void Set_Widescreen_Fix_Click(object sender, EventArgs e)
        {
            //HACKS
            // ThisWillError:^) SEARCH FOR THE FUCKING SHITTY RESOLUTION READ IT THO SO YA DON"T NEED TOO."
            //THIS IS MAX FPS SHIT 1000000/120=8333
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                string[] Widescreen_Addresses = new string[] { "6188AC", "7DEDF4", "82A5B8", "82B964", "8F0890", "8F09C4", "A389F8", "A38BF8", "A38DF8", "A38FF8",
                    "AC80A4", "AC80B0", "B5AEFC", "111FEE0", "1453318", "1481128", "15C1898", "15C7330", "15DDAFC", "15F2E0C",
                    "170348C", "1B6673C", "1DA5EB8", "1E2D7B4", "1E4303C", "1E4FA7C", "1E79DBC", "1E82CCC", "1E92FB8", "1F2BD68",
                    "21B2228", "21C9754", "22093AC", "2226FA0", "2227110", "2227268", "222754C", "23BF720", "23BF72C", "261B730",
                    "26AB830", "2795F90", "2796E5C", "279CF30", "2A24A60", "2C59974", "2CEE5F8", "2DCC734", "2DCC7F8", "2E80A34",
                    "2EBA988", "3002B44", "307A4D4", "391D070", "399725C", "3999AA4", "3999AAC", "3DC779C", "3DC7804", "3DC78A4",
                    "3DC790C", "464D050", "464D06C", "4E6A884", "4E96E80", "4E97F60", "4E97F6C", "4E97F84", "4E97F98", "4E98144",
                    "4ECCCB0", "4EF50E0", "58DCFA8", "5AB2798", "63A1F00", "643C684", "643C744", "64B2C08", "64D38A8", "6509D9C" };


                List<long> WS_Long_Addies = new List<long>();

                foreach (string dong in Widescreen_Addresses)
                {
                    long convert;
                    if (long.TryParse(dong, out convert))
                    {
                        Console.WriteLine(convert);
                        WS_Long_Addies.Add(oMemory.BaseAddressD() + Addr.ToDec(System.Convert.ToString(convert)));
                    }
                }

                long[] Widescreen_Addies = WS_Long_Addies.ToArray();

                //Console.WriteLine(Widescreen_Addies);

             //   long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("58ECF90");



                decimal WS_Height = Math.Round(decimal.Parse(Convert.ToString(Widescreen_Height.Value)));
                int int_ws = (int)WS_Height;

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(int_ws);
                //oMemory.Write((IntPtr)Widescreen_Addies, bValue_To_Write, out bytesWritten);

                oMemory.CloseHandle();
            }
        }
        */
        public void FOV_CHANGER_Click(object sender, EventArgs e)
        {
            //FOV SHIT 
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                float suckondeezfov = System.Convert.ToInt32(this.FoVNumber.Value);
                long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("5934A90");

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(suckondeezfov);

                oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                oMemory.CloseHandle();
            }
        }

        public void FOV_Set()
        {
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                float suckondeezfov = System.Convert.ToInt32(this.FoVNumber.Value);
                long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("5934A90");

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(suckondeezfov);

                oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                oMemory.CloseHandle();
            }
        }


        public void Set_Forge_Map_Click(object sender, EventArgs e)
        {
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();
                int bytesWritten;

                string forgemap = System.Convert.ToString(forge_map_box_value.Text);
                long forge_address = oMemory.BaseAddressD() + Addr.ToDec("3A01840");
                byte[] forgemapname = Encoding.ASCII.GetBytes(forgemap);
                byte[] bValue_To_Write = forgemapname;

                oMemory.Write((IntPtr)forge_address, bValue_To_Write, out bytesWritten);


                oMemory.CloseHandle();
            }
        }
    }
}
