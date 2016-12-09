using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Bleam
{
	public partial class hForm : Form
	{
		Memory oMemory = new Memory();
        //Process[] aProcesses = Process.GetProcessesByName("halo5forge");
        //WorkingClassCuck WorkingCuck = new WorkingClassCuck(this);

        
        
        public hForm()
		{
			InitializeComponent();
		}

		private void Max_FPS_Click(object sender, EventArgs e)
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

                long Widescreen_Addi1 = oMemory.BaseAddressD() + Addr.ToDec("6188AC");
                long Widescreen_Addi2 = oMemory.BaseAddressD() + Addr.ToDec("7DEDF4");
                long Widescreen_Addi3 = oMemory.BaseAddressD() + Addr.ToDec("82A5B8");
                long Widescreen_Addi4 = oMemory.BaseAddressD() + Addr.ToDec("82B964");
                long Widescreen_Addi5 = oMemory.BaseAddressD() + Addr.ToDec("8F0890");
                long Widescreen_Addi6 = oMemory.BaseAddressD() + Addr.ToDec("8F09C4");
                long Widescreen_Addi7 = oMemory.BaseAddressD() + Addr.ToDec("A389F8");
                long Widescreen_Addi8 = oMemory.BaseAddressD() + Addr.ToDec("A38BF8");
                long Widescreen_Addi9 = oMemory.BaseAddressD() + Addr.ToDec("A38DF8");
                long Widescreen_Addi10 = oMemory.BaseAddressD() + Addr.ToDec("A38FF8");
                long Widescreen_Addi11 = oMemory.BaseAddressD() + Addr.ToDec("AC80A4");
                long Widescreen_Addi12 = oMemory.BaseAddressD() + Addr.ToDec("AC80B0");
                long Widescreen_Addi13 = oMemory.BaseAddressD() + Addr.ToDec("B5AEFC");
                long Widescreen_Addi14 = oMemory.BaseAddressD() + Addr.ToDec("111FEE0");
                long Widescreen_Addi15 = oMemory.BaseAddressD() + Addr.ToDec("1453318");
                long Widescreen_Addi16 = oMemory.BaseAddressD() + Addr.ToDec("1481128");
                long Widescreen_Addi17 = oMemory.BaseAddressD() + Addr.ToDec("15C1898");
                long Widescreen_Addi18 = oMemory.BaseAddressD() + Addr.ToDec("15C7330");
                long Widescreen_Addi19 = oMemory.BaseAddressD() + Addr.ToDec("15DDAFC");
                long Widescreen_Addi20 = oMemory.BaseAddressD() + Addr.ToDec("15F2E0C");
                long Widescreen_Addi21 = oMemory.BaseAddressD() + Addr.ToDec("170348C");
                long Widescreen_Addi22 = oMemory.BaseAddressD() + Addr.ToDec("1B6673C");
                long Widescreen_Addi23 = oMemory.BaseAddressD() + Addr.ToDec("1DA5EB8");
                long Widescreen_Addi24 = oMemory.BaseAddressD() + Addr.ToDec("1E2D7B4");
                long Widescreen_Addi25 = oMemory.BaseAddressD() + Addr.ToDec("1E4303C");
                long Widescreen_Addi26 = oMemory.BaseAddressD() + Addr.ToDec("1E4FA7C");
                long Widescreen_Addi27 = oMemory.BaseAddressD() + Addr.ToDec("1E79DBC");
                long Widescreen_Addi28 = oMemory.BaseAddressD() + Addr.ToDec("1E82CCC");
                long Widescreen_Addi29 = oMemory.BaseAddressD() + Addr.ToDec("1E92FB8");
                long Widescreen_Addi30 = oMemory.BaseAddressD() + Addr.ToDec("1F2BD68");
                long Widescreen_Addi31 = oMemory.BaseAddressD() + Addr.ToDec("21B2228");
                long Widescreen_Addi32 = oMemory.BaseAddressD() + Addr.ToDec("21C9754");
                long Widescreen_Addi33 = oMemory.BaseAddressD() + Addr.ToDec("22093AC");
                long Widescreen_Addi34 = oMemory.BaseAddressD() + Addr.ToDec("2226FA0");
                long Widescreen_Addi35 = oMemory.BaseAddressD() + Addr.ToDec("2227110");
                long Widescreen_Addi36 = oMemory.BaseAddressD() + Addr.ToDec("2227268");
                long Widescreen_Addi37 = oMemory.BaseAddressD() + Addr.ToDec("222754C");
                long Widescreen_Addi38 = oMemory.BaseAddressD() + Addr.ToDec("23BF720");
                long Widescreen_Addi39 = oMemory.BaseAddressD() + Addr.ToDec("23BF72C");
                long Widescreen_Addi40 = oMemory.BaseAddressD() + Addr.ToDec("261B730");
                long Widescreen_Addi41 = oMemory.BaseAddressD() + Addr.ToDec("26AB830");
                long Widescreen_Addi42 = oMemory.BaseAddressD() + Addr.ToDec("2795F90");
                long Widescreen_Addi43 = oMemory.BaseAddressD() + Addr.ToDec("2796E5C");
                long Widescreen_Addi44 = oMemory.BaseAddressD() + Addr.ToDec("279CF30");
                long Widescreen_Addi45 = oMemory.BaseAddressD() + Addr.ToDec("2A24A60");
                long Widescreen_Addi46 = oMemory.BaseAddressD() + Addr.ToDec("2C59974");
                long Widescreen_Addi47 = oMemory.BaseAddressD() + Addr.ToDec("2CEE5F8");
                long Widescreen_Addi48 = oMemory.BaseAddressD() + Addr.ToDec("2DCC734");
                long Widescreen_Addi49 = oMemory.BaseAddressD() + Addr.ToDec("2DCC7F8");
                long Widescreen_Addi50 = oMemory.BaseAddressD() + Addr.ToDec("2E80A34");
                long Widescreen_Addi51 = oMemory.BaseAddressD() + Addr.ToDec("2EBA988");
                long Widescreen_Addi52 = oMemory.BaseAddressD() + Addr.ToDec("3002B44");
                long Widescreen_Addi53 = oMemory.BaseAddressD() + Addr.ToDec("307A4D4");
                long Widescreen_Addi54 = oMemory.BaseAddressD() + Addr.ToDec("391D070");
                long Widescreen_Addi55 = oMemory.BaseAddressD() + Addr.ToDec("399725C");
                long Widescreen_Addi56 = oMemory.BaseAddressD() + Addr.ToDec("3999AA4");
                long Widescreen_Addi57 = oMemory.BaseAddressD() + Addr.ToDec("3999AAC");
                long Widescreen_Addi58 = oMemory.BaseAddressD() + Addr.ToDec("3DC779C");
                long Widescreen_Addi59 = oMemory.BaseAddressD() + Addr.ToDec("3DC7804");
                long Widescreen_Addi60 = oMemory.BaseAddressD() + Addr.ToDec("3DC78A4");
                long Widescreen_Addi61 = oMemory.BaseAddressD() + Addr.ToDec("3DC790C");
                long Widescreen_Addi62 = oMemory.BaseAddressD() + Addr.ToDec("464D050");
                long Widescreen_Addi63 = oMemory.BaseAddressD() + Addr.ToDec("464D06C");
                long Widescreen_Addi64 = oMemory.BaseAddressD() + Addr.ToDec("4E6A884");
                long Widescreen_Addi65 = oMemory.BaseAddressD() + Addr.ToDec("4E96E80");
                long Widescreen_Addi66 = oMemory.BaseAddressD() + Addr.ToDec("4E97F60");
                long Widescreen_Addi67 = oMemory.BaseAddressD() + Addr.ToDec("4E97F6C");
                long Widescreen_Addi68 = oMemory.BaseAddressD() + Addr.ToDec("4E97F84");
                long Widescreen_Addi69 = oMemory.BaseAddressD() + Addr.ToDec("4E97F98");
                long Widescreen_Addi70 = oMemory.BaseAddressD() + Addr.ToDec("4E98144");
                long Widescreen_Addi71 = oMemory.BaseAddressD() + Addr.ToDec("4ECCCB0");
                long Widescreen_Addi72 = oMemory.BaseAddressD() + Addr.ToDec("4EF50E0");
                long Widescreen_Addi73 = oMemory.BaseAddressD() + Addr.ToDec("58DCFA8");
                long Widescreen_Addi74 = oMemory.BaseAddressD() + Addr.ToDec("5AB2798");
                long Widescreen_Addi75 = oMemory.BaseAddressD() + Addr.ToDec("63A1F00");
                long Widescreen_Addi76 = oMemory.BaseAddressD() + Addr.ToDec("643C684");
                long Widescreen_Addi77 = oMemory.BaseAddressD() + Addr.ToDec("643C744");
                long Widescreen_Addi78 = oMemory.BaseAddressD() + Addr.ToDec("64B2C08");
                long Widescreen_Addi79 = oMemory.BaseAddressD() + Addr.ToDec("64D38A8");
                long Widescreen_Addi80 = oMemory.BaseAddressD() + Addr.ToDec("6509D9C");


                decimal WS_Height = Math.Round(decimal.Parse(Convert.ToString(Widescreen_Height.Value)));
                int int_ws = (int)WS_Height;
                int shit = 0;
                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(int_ws);
                oMemory.Write((IntPtr)Widescreen_Addi1, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi2, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi3, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi4, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi5, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi6, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi7, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi8, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi9, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi10, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi11, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi12, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi13, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi14, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi15, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi16, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi17, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi18, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi19, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi20, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi21, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi22, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi23, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi24, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi25, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi26, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi27, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi28, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi29, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi30, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi31, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi32, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi33, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi34, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi35, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi36, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi37, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi38, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi39, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi40, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi41, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi42, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi43, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi44, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi45, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi46, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi47, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi48, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi49, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi50, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi51, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi52, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi53, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi54, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi55, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi56, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi57, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi58, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi59, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi60, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi61, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi62, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi63, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi64, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi65, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi66, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi67, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi68, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi69, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi70, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi71, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi72, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi73, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi74, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi75, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi76, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi77, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi78, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi79, bValue_To_Write, out shit); 
                oMemory.Write((IntPtr)Widescreen_Addi80, bValue_To_Write, out shit);
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
        private void FOV_CHANGER_Click(object sender, EventArgs e)
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

        private void Effects_Distortion_CheckedChanged(object sender, EventArgs e)
        {
            bool effedtoggle = System.Convert.ToBoolean(this.Effects_Distortion.Checked);
            //46EC553
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");

            if (effedtoggle == false)
            {
                //this.Effects_Distortion.BackColor = Color.Red; 
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float effetoggle = 0;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("46EC553");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(effetoggle);

                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                    oMemory.CloseHandle();
                }
            }
            else if (effedtoggle == true)
            {
                //this.Effects_Distortion.ForeColor = Color.Green;
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float effetoggle = 1;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("46EC553");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(effetoggle);
                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);
                    oMemory.CloseHandle();
                }
            }
        }



        private void Debug_Controller_Latency_CheckedChanged(object sender, EventArgs e)
        {
            bool DebugControlLag = System.Convert.ToBoolean(this.Debug_Controller_Latency.Checked);
            //46EC553
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");

            if (DebugControlLag == false)
            {
                //this.Effects_Distortion.BackColor = Color.Red; 
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float DebugControlLagv = 0;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("59FB940");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(DebugControlLagv);

                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                    oMemory.CloseHandle();
                }
            }

      

            else if (DebugControlLag == true)
            {
                //this.Effects_Distortion.ForeColor = Color.Green;
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float DebugControlLagv = 1;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("59FB940");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(DebugControlLagv);
                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);
                    oMemory.CloseHandle();
                }
            }
        }

        private void killvolcheck(object sender, EventArgs e)
        {
            bool KillBoxDisable = System.Convert.ToBoolean(this.killvoldisable.Checked);
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");

            if (KillBoxDisable == false)
            {
                //this.Effects_Distortion.BackColor = Color.Red; 
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float togglebyte = 0;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("5B1CB90");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(togglebyte);

                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                    oMemory.CloseHandle();
                }
            }



            else if (KillBoxDisable == true)
            {
                //this.Effects_Distortion.ForeColor = Color.Green;
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    float togglebyte = 1;
                    long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("5B1CB90");

                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(togglebyte);
                    oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);
                    oMemory.CloseHandle();
                }
            }
        }


        private void Set_Forge_Map_Click(object sender, EventArgs e)
        {
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();
                int bytesWritten;

                string forgemap = System.Convert.ToString(this.forge_map_box_value.Text);
                long forge_address = oMemory.BaseAddressD() + Addr.ToDec("3A01840");
                byte[] forgemapname = Encoding.ASCII.GetBytes(forgemap);
                byte[] bValue_To_Write = forgemapname;
                
                oMemory.Write((IntPtr)forge_address, bValue_To_Write, out bytesWritten);


                oMemory.CloseHandle();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }




        //Fuck off Functions
        /* private void ChexMexRecipe(Object but, String offset)
         {

             Process[] aProcesses = Process.GetProcessesByName("halo5forge");
             bool toggle = System.Convert.ToBoolean(this.but.Checked);



             if (toggle == false)
             {
                 if (aProcesses.Length != 0)
                 {
                     oMemory.ReadProcess = aProcesses[0]; oMemory.Open();
                     float boolv = 0;
                     long Check_Address = oMemory.BaseAddressD() + Addr.ToDec(offset);
                     int bytesWritten;
                     byte[] bValue_To_Write = BitConverter.GetBytes(boolv);
                     oMemory.Write((IntPtr)Check_Address, bValue_To_Write, out bytesWritten);
                     oMemory.CloseHandle();
                 }
             }
             else if (toggle == true)
             {
                 if (aProcesses.Length != 0)
                 {
                     oMemory.ReadProcess = aProcesses[0];
                     oMemory.Open();
                     float boolv = 1;
                     long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec(offset);
                     int bytesWritten;
                     byte[] bValue_To_Write = BitConverter.GetBytes(boolv);
                     oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);
                     oMemory.CloseHandle();
                 }
             }
         }*/



    }

    class MemoryAPI
	{
		[Flags]
		public enum ProcessAccessType
		{
			PROCESS_TERMINATE = (0x0001),
			PROCESS_CREATE_THREAD = (0x0002),
			PROCESS_SET_SESSIONID = (0x0004),
			PROCESS_VM_OPERATION = (0x0008),
			PROCESS_VM_READ = (0x0010),
			PROCESS_VM_WRITE = (0x0020),
			PROCESS_DUP_HANDLE = (0x0040),
			PROCESS_CREATE_PROCESS = (0x0080),
			PROCESS_SET_QUOTA = (0x0100),
			PROCESS_SET_INFORMATION = (0x0200),
			PROCESS_QUERY_INFORMATION = (0x0400)
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

		[DllImport("kernel32.dll")]
		public static extern Int32 CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll")]
		public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

		[DllImport("kernel32.dll")]
		public static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
	}

	public class Memory
	{
		public Memory()
		{
		}

		public Process ReadProcess
		{
			get
			{
				return m_ReadProcess;
			}
			set
			{
				m_ReadProcess = value;
			}
		}
		private Process m_ReadProcess = null;
		private IntPtr m_hProcess = IntPtr.Zero;

		public void Open()
		{
			MemoryAPI.ProcessAccessType access = MemoryAPI.ProcessAccessType.PROCESS_VM_READ
			| MemoryAPI.ProcessAccessType.PROCESS_VM_WRITE
			| MemoryAPI.ProcessAccessType.PROCESS_VM_OPERATION;
			m_hProcess = MemoryAPI.OpenProcess((uint)access, 1, (uint)m_ReadProcess.Id);
		}

		public void CloseHandle()
		{
			int iRetValue;
			iRetValue = MemoryAPI.CloseHandle(m_hProcess);
			if (iRetValue == 0)
				throw new Exception("CloseHandle Failed");
		}

		public byte[] Read(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
		{
			byte[] buffer = new byte[bytesToRead];
			IntPtr ptrBytesRead;
			MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, bytesToRead, out ptrBytesRead);
			bytesRead = ptrBytesRead.ToInt32();
			return buffer;
		}

		public byte[] PointerRead(IntPtr MemoryAddress, uint bytesToRead, int[] Offset, out int bytesRead)
		{
			int iPointerCount = Offset.Length - 1;
			IntPtr ptrBytesRead;
			bytesRead = 0;
			byte[] buffer = new byte[4]; //DWORD to hold an Address
			int tempAddress = 0;

			if (iPointerCount == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
				tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address

				buffer = new byte[bytesToRead];
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

				bytesRead = ptrBytesRead.ToInt32();
				return buffer;
			}

			for (int i = 0; i <= iPointerCount; i++)
			{
				if (i == iPointerCount)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address

					buffer = new byte[bytesToRead];
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

					bytesRead = ptrBytesRead.ToInt32();
					return buffer;
				}
				else if (i == 0)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[1];
				}
				else
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
			}

			return buffer;
		}

		public void Write(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
		{
			IntPtr ptrBytesWritten;
			MemoryAPI.WriteProcessMemory(m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);
			bytesWritten = ptrBytesWritten.ToInt32();
		}

		public string PointerWrite(IntPtr MemoryAddress, byte[] bytesToWrite, int[] Offset, out int bytesWritten)
		{
			int iPointerCount = Offset.Length - 1;
			IntPtr ptrBytesWritten;
			bytesWritten = 0;
			byte[] buffer = new byte[4]; //DWORD to hold an Address
			int tempAddress = 0;

			if (iPointerCount == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
				tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address
				MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

				bytesWritten = ptrBytesWritten.ToInt32();
				return Addr.ToHex(tempAddress);
			}

			for (int i = 0; i <= iPointerCount; i++)
			{
				if (i == iPointerCount)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address
					MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

					bytesWritten = ptrBytesWritten.ToInt32();
					return Addr.ToHex(tempAddress);
				}
				else if (i == 0)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
				else
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
			}

			return Addr.ToHex(tempAddress);
		}

		public int PID()
		{
			return m_ReadProcess.Id;
		}

		public string BaseAddressH()
		{
			return Addr.ToHex(m_ReadProcess.MainModule.BaseAddress.ToInt32());
		}

		public long BaseAddressD()
		{
			return m_ReadProcess.MainModule.BaseAddress.ToInt64();
		}
	}

	public class Addr
	{
		public static string Make(byte[] buffer)
		{
			string sTemp = "";

			for (int i = 0; i < buffer.Length; i++)
			{
				if (Convert.ToInt16(buffer[i]) < 10)
					sTemp = "0" + ToHex(buffer[i]) + sTemp;
				else
					sTemp = ToHex(buffer[i]) + sTemp;
			}

			return sTemp;
		}

		public static string ToHex(int Decimal)
		{
			return Decimal.ToString("X"); //Convert Decimal to Hexadecimal
		}

		public static int ToDec(string Hex)
		{
			return int.Parse(Hex, NumberStyles.HexNumber); //Convert Hexadecimal to Decimal
		}
	}
}
