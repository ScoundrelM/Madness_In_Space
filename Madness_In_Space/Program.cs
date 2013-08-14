using System;
using System.Windows.Forms;

namespace Madness_In_Space
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			Form start = new Forms.Vessel_Initial_Details_Input_Form();
			
			start.ShowDialog();
			
			Console.ReadLine();
			
		}
	}
}
