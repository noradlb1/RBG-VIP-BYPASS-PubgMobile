using System;
using System.Windows.Forms;
using BYPASS;

// Token: 0x0200003E RID: 62
internal static class Class3
{
	// Token: 0x0600012F RID: 303 RVA: 0x0000290B File Offset: 0x00000B0B
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Login());
	}
}
