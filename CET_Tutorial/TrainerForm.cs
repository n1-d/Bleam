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

namespace CET_Tutorial
{
	public partial class hForm : Form
	{
		Memory oMemory = new Memory();
        //Process[] aProcesses = Process.GetProcessesByName("halo5forge");

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

                long FPS_Address_1 = oMemory.BaseAddressD() + Addr.ToDec("34B8C50");
                long FPS_Address_2 = oMemory.BaseAddressD() + Addr.ToDec("34B8C60");
                long FPS_Address_3 = oMemory.BaseAddressD() + Addr.ToDec("34B8C70");

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

        private void Wide_Screen_Enabler(object sender, EventArgs e)
        {
           
        }
		private void FOV_CHANGER_Click(object sender, EventArgs e)
		{
            //FOV SHIT
            Process[] aProcesses = Process.GetProcessesByName("halo5forge");
            if (aProcesses.Length != 0)
            {
                oMemory.ReadProcess = aProcesses[0];
                oMemory.Open();

                float suckondeezfov = System.Convert.ToInt32(this.FoVNumber.Value);
                long FOV_Address = oMemory.BaseAddressD() + Addr.ToDec("58ECF90");

                int bytesWritten;
                byte[] bValue_To_Write = BitConverter.GetBytes(suckondeezfov);

                oMemory.Write((IntPtr)FOV_Address, bValue_To_Write, out bytesWritten);


                oMemory.CloseHandle();
            }   
        }
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
