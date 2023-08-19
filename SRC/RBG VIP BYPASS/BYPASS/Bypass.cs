using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BYPASS.Properties;
using DiscordRPC;
using Memory;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace BYPASS
{
	// Token: 0x02000002 RID: 2
	public partial class Bypass : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000223A File Offset: 0x0000043A
		public Bypass()
		{
			this.method_13();
		}

		// Token: 0x06000003 RID: 3
		[DllImport("KERNEL32.DLL")]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x06000004 RID: 4
		[DllImport("KERNEL32.DLL")]
		public static extern int Process32First(IntPtr handle, ref Bypass.ProcessEntry32 pe);

		// Token: 0x06000005 RID: 5
		[DllImport("KERNEL32.DLL")]
		public static extern int Process32Next(IntPtr handle, ref Bypass.ProcessEntry32 pe);

		// Token: 0x06000006 RID: 6
		[DllImport("User32.dll")]
		public static extern bool GetAsyncKeyState(Keys vkey);

		// Token: 0x06000007 RID: 7
		[DllImport("User32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		// Token: 0x06000008 RID: 8 RVA: 0x00002E70 File Offset: 0x00001070
		private IntPtr aobogkbcG()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0U;
			IntPtr intPtr2 = Bypass.CreateToolhelp32Snapshot(2U, 0U);
			if ((int)intPtr2 > 0)
			{
				Bypass.ProcessEntry32 processEntry = default(Bypass.ProcessEntry32);
				processEntry.dwSize = (uint)Marshal.SizeOf<Bypass.ProcessEntry32>(processEntry);
				for (int num2 = Bypass.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Bypass.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
					Marshal.StructureToPtr<Bypass.ProcessEntry32>(processEntry, intPtr3, true);
					Bypass.ProcessEntry32 processEntry2 = (Bypass.ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(Bypass.ProcessEntry32));
					Marshal.FreeHGlobal(intPtr3);
					if (processEntry2.szExeFile.Contains("aow_exe") && processEntry2.cntThreads > num)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
				string value = Convert.ToString(intPtr);
				this.MemLib.OpenProcess(Convert.ToInt32(value));
			}
			return intPtr;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002F54 File Offset: 0x00001154
		private void method_0()
		{
			Bypass.<DrvSTART>d__9 <DrvSTART>d__;
			<DrvSTART>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DrvSTART>d__.<>1__state = -1;
			<DrvSTART>d__.<>t__builder.Start<Bypass.<DrvSTART>d__9>(ref <DrvSTART>d__);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002F84 File Offset: 0x00001184
		private void method_1(int int_0)
		{
			Bypass.<ReadlibF>d__10 <ReadlibF>d__;
			<ReadlibF>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ReadlibF>d__.<>4__this = this;
			<ReadlibF>d__.offset = int_0;
			<ReadlibF>d__.<>1__state = -1;
			<ReadlibF>d__.<>t__builder.Start<Bypass.<ReadlibF>d__10>(ref <ReadlibF>d__);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002FC4 File Offset: 0x000011C4
		private void method_2(int int_0, string string_0)
		{
			Bypass.<WritelibF>d__11 <WritelibF>d__;
			<WritelibF>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<WritelibF>d__.<>4__this = this;
			<WritelibF>d__.offset = int_0;
			<WritelibF>d__.write = string_0;
			<WritelibF>d__.<>1__state = -1;
			<WritelibF>d__.<>t__builder.Start<Bypass.<WritelibF>d__11>(ref <WritelibF>d__);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000300C File Offset: 0x0000120C
		private void method_3(int int_0, string string_0)
		{
			Bypass.<WritelibB>d__12 <WritelibB>d__;
			<WritelibB>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<WritelibB>d__.<>4__this = this;
			<WritelibB>d__.offset = int_0;
			<WritelibB>d__.write = string_0;
			<WritelibB>d__.<>1__state = -1;
			<WritelibB>d__.<>t__builder.Start<Bypass.<WritelibB>d__12>(ref <WritelibB>d__);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003054 File Offset: 0x00001254
		private void method_4(int int_0, string string_0)
		{
			Bypass.<WriteTersafe>d__13 <WriteTersafe>d__;
			<WriteTersafe>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<WriteTersafe>d__.<>4__this = this;
			<WriteTersafe>d__.offset = int_0;
			<WriteTersafe>d__.write = string_0;
			<WriteTersafe>d__.<>1__state = -1;
			<WriteTersafe>d__.<>t__builder.Start<Bypass.<WriteTersafe>d__13>(ref <WriteTersafe>d__);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000309C File Offset: 0x0000129C
		private void method_5(int int_0, string string_0)
		{
			Bypass.<Writelibgsrt>d__14 <Writelibgsrt>d__;
			<Writelibgsrt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Writelibgsrt>d__.<>4__this = this;
			<Writelibgsrt>d__.offset = int_0;
			<Writelibgsrt>d__.write = string_0;
			<Writelibgsrt>d__.<>1__state = -1;
			<Writelibgsrt>d__.<>t__builder.Start<Bypass.<Writelibgsrt>d__14>(ref <Writelibgsrt>d__);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000030E4 File Offset: 0x000012E4
		private void timer_2_Tick(object sender, EventArgs e)
		{
			Bypass.<libanogs_Tick>d__15 <libanogs_Tick>d__;
			<libanogs_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<libanogs_Tick>d__.<>4__this = this;
			<libanogs_Tick>d__.<>1__state = -1;
			<libanogs_Tick>d__.<>t__builder.Start<Bypass.<libanogs_Tick>d__15>(ref <libanogs_Tick>d__);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000311C File Offset: 0x0000131C
		private void method_6()
		{
			Bypass.<bypass>d__16 <bypass>d__;
			<bypass>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bypass>d__.<>4__this = this;
			<bypass>d__.<>1__state = -1;
			<bypass>d__.<>t__builder.Start<Bypass.<bypass>d__16>(ref <bypass>d__);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003154 File Offset: 0x00001354
		private void method_7()
		{
			Bypass.<Writevalue>d__17 <Writevalue>d__;
			<Writevalue>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Writevalue>d__.<>4__this = this;
			<Writevalue>d__.<>1__state = -1;
			<Writevalue>d__.<>t__builder.Start<Bypass.<Writevalue>d__17>(ref <Writevalue>d__);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000225E File Offset: 0x0000045E
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002266 File Offset: 0x00000466
		public Point CursorPosition { get; protected set; }

		// Token: 0x06000014 RID: 20 RVA: 0x0000318C File Offset: 0x0000138C
		private void method_8()
		{
			Bypass.<Initialize>d__25 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<Bypass.<Initialize>d__25>(ref <Initialize>d__);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000226F File Offset: 0x0000046F
		private FileAttributes method_9(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
		{
			return fileAttributes_0 & ~fileAttributes_1;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031C4 File Offset: 0x000013C4
		private void method_10()
		{
			Bypass.<killgameloop>d__27 <killgameloop>d__;
			<killgameloop>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<killgameloop>d__.<>4__this = this;
			<killgameloop>d__.<>1__state = -1;
			<killgameloop>d__.<>t__builder.Start<Bypass.<killgameloop>d__27>(ref <killgameloop>d__);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000031FC File Offset: 0x000013FC
		private void KqAucWlbf(object sender, FormClosedEventArgs e)
		{
			Bypass.<Form1_FormClosed>d__28 <Form1_FormClosed>d__;
			<Form1_FormClosed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Form1_FormClosed>d__.<>4__this = this;
			<Form1_FormClosed>d__.<>1__state = -1;
			<Form1_FormClosed>d__.<>t__builder.Start<Bypass.<Form1_FormClosed>d__28>(ref <Form1_FormClosed>d__);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003234 File Offset: 0x00001434
		private void Bypass_FormClosing(object sender, FormClosingEventArgs e)
		{
			Bypass.<Form1_FormClosing>d__29 <Form1_FormClosing>d__;
			<Form1_FormClosing>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Form1_FormClosing>d__.<>4__this = this;
			<Form1_FormClosing>d__.<>1__state = -1;
			<Form1_FormClosing>d__.<>t__builder.Start<Bypass.<Form1_FormClosing>d__29>(ref <Form1_FormClosing>d__);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000326C File Offset: 0x0000146C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000032A0 File Offset: 0x000014A0
		private void webClient_0_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			Bypass.<FileDownloadComplete>d__31 <FileDownloadComplete>d__;
			<FileDownloadComplete>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FileDownloadComplete>d__.<>4__this = this;
			<FileDownloadComplete>d__.<>1__state = -1;
			<FileDownloadComplete>d__.<>t__builder.Start<Bypass.<FileDownloadComplete>d__31>(ref <FileDownloadComplete>d__);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000032D8 File Offset: 0x000014D8
		private void webClient_0_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			Bypass.<FileProgressChanges>d__32 <FileProgressChanges>d__;
			<FileProgressChanges>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FileProgressChanges>d__.<>4__this = this;
			<FileProgressChanges>d__.e = e;
			<FileProgressChanges>d__.<>1__state = -1;
			<FileProgressChanges>d__.<>t__builder.Start<Bypass.<FileProgressChanges>d__32>(ref <FileProgressChanges>d__);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003318 File Offset: 0x00001518
		private void method_11()
		{
			Bypass.<updatecheck>d__36 <updatecheck>d__;
			<updatecheck>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<updatecheck>d__.<>4__this = this;
			<updatecheck>d__.<>1__state = -1;
			<updatecheck>d__.<>t__builder.Start<Bypass.<updatecheck>d__36>(ref <updatecheck>d__);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003350 File Offset: 0x00001550
		public static void DeleteFilesAndFoldersRecursively(string target_dir)
		{
			string[] array = Directory.GetFiles(target_dir);
			for (int i = 0; i < array.Length; i++)
			{
				File.Delete(array[i]);
			}
			array = Directory.GetDirectories(target_dir);
			for (int i = 0; i < array.Length; i++)
			{
				Bypass.DeleteFilesAndFoldersRecursively(array[i]);
			}
			Thread.Sleep(1);
			Directory.Delete(target_dir);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000033A4 File Offset: 0x000015A4
		private void Bypass_Load(object sender, EventArgs e)
		{
			Bypass.<Bypass_Load>d__38 <Bypass_Load>d__;
			<Bypass_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Bypass_Load>d__.<>4__this = this;
			<Bypass_Load>d__.<>1__state = -1;
			<Bypass_Load>d__.<>t__builder.Start<Bypass.<Bypass_Load>d__38>(ref <Bypass_Load>d__);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033DC File Offset: 0x000015DC
		private void DtyxLffet()
		{
			Bypass.<click>d__39 <click>d__;
			<click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<click>d__.<>1__state = -1;
			<click>d__.<>t__builder.Start<Bypass.<click>d__39>(ref <click>d__);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000340C File Offset: 0x0000160C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			Bypass.<ninetyfps_Tick>d__40 <ninetyfps_Tick>d__;
			<ninetyfps_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ninetyfps_Tick>d__.<>1__state = -1;
			<ninetyfps_Tick>d__.<>t__builder.Start<Bypass.<ninetyfps_Tick>d__40>(ref <ninetyfps_Tick>d__);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000343C File Offset: 0x0000163C
		private void timer_1_Tick(object sender, EventArgs e)
		{
			Bypass.<Flash_Tick>d__41 <Flash_Tick>d__;
			<Flash_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Flash_Tick>d__.<>1__state = -1;
			<Flash_Tick>d__.<>t__builder.Start<Bypass.<Flash_Tick>d__41>(ref <Flash_Tick>d__);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000346C File Offset: 0x0000166C
		private void siticoneControlBox_0_Click(object sender, EventArgs e)
		{
			Bypass.<siticoneControlBox1_Click_1>d__42 <siticoneControlBox1_Click_1>d__;
			<siticoneControlBox1_Click_1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneControlBox1_Click_1>d__.<>4__this = this;
			<siticoneControlBox1_Click_1>d__.<>1__state = -1;
			<siticoneControlBox1_Click_1>d__.<>t__builder.Start<Bypass.<siticoneControlBox1_Click_1>d__42>(ref <siticoneControlBox1_Click_1>d__);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000034A4 File Offset: 0x000016A4
		private void mAkRwNbwIm_Click(object sender, EventArgs e)
		{
			Bypass.<siticoneControlBox2_Click>d__43 <siticoneControlBox2_Click>d__;
			<siticoneControlBox2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneControlBox2_Click>d__.<>4__this = this;
			<siticoneControlBox2_Click>d__.<>1__state = -1;
			<siticoneControlBox2_Click>d__.<>t__builder.Start<Bypass.<siticoneControlBox2_Click>d__43>(ref <siticoneControlBox2_Click>d__);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000034DC File Offset: 0x000016DC
		private void method_12(object sender, EventArgs e)
		{
			Bypass.<siticonePictureBox1_Click>d__44 <siticonePictureBox1_Click>d__;
			<siticonePictureBox1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticonePictureBox1_Click>d__.<>4__this = this;
			<siticonePictureBox1_Click>d__.<>1__state = -1;
			<siticonePictureBox1_Click>d__.<>t__builder.Start<Bypass.<siticonePictureBox1_Click>d__44>(ref <siticonePictureBox1_Click>d__);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003514 File Offset: 0x00001714
		private void siticoneTrackBar_0_Scroll(object sender, ScrollEventArgs e)
		{
			Bypass.<ipadTrackBar1_Scroll_1>d__45 <ipadTrackBar1_Scroll_1>d__;
			<ipadTrackBar1_Scroll_1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ipadTrackBar1_Scroll_1>d__.<>4__this = this;
			<ipadTrackBar1_Scroll_1>d__.<>1__state = -1;
			<ipadTrackBar1_Scroll_1>d__.<>t__builder.Start<Bypass.<ipadTrackBar1_Scroll_1>d__45>(ref <ipadTrackBar1_Scroll_1>d__);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000354C File Offset: 0x0000174C
		private void siticoneImageButton_0_Click(object sender, EventArgs e)
		{
			Bypass.<EmulatorStartButton1_Click>d__46 <EmulatorStartButton1_Click>d__;
			<EmulatorStartButton1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<EmulatorStartButton1_Click>d__.<>4__this = this;
			<EmulatorStartButton1_Click>d__.<>1__state = -1;
			<EmulatorStartButton1_Click>d__.<>t__builder.Start<Bypass.<EmulatorStartButton1_Click>d__46>(ref <EmulatorStartButton1_Click>d__);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003584 File Offset: 0x00001784
		private void siticoneImageButton_2_Click(object sender, EventArgs e)
		{
			Bypass.<GameStartButton2_Click>d__47 <GameStartButton2_Click>d__;
			<GameStartButton2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GameStartButton2_Click>d__.<>4__this = this;
			<GameStartButton2_Click>d__.<>1__state = -1;
			<GameStartButton2_Click>d__.<>t__builder.Start<Bypass.<GameStartButton2_Click>d__47>(ref <GameStartButton2_Click>d__);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000035BC File Offset: 0x000017BC
		private void siticoneImageButton_1_Click(object sender, EventArgs e)
		{
			Bypass.<SafeExitButton3_Click>d__48 <SafeExitButton3_Click>d__;
			<SafeExitButton3_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SafeExitButton3_Click>d__.<>4__this = this;
			<SafeExitButton3_Click>d__.<>1__state = -1;
			<SafeExitButton3_Click>d__.<>t__builder.Start<Bypass.<SafeExitButton3_Click>d__48>(ref <SafeExitButton3_Click>d__);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002238 File Offset: 0x00000438
		private void siticonePanel_0_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000035F4 File Offset: 0x000017F4
		private void timer_3_Tick(object sender, EventArgs e)
		{
			Bypass.<PIDD_Tick>d__50 <PIDD_Tick>d__;
			<PIDD_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PIDD_Tick>d__.<>4__this = this;
			<PIDD_Tick>d__.<>1__state = -1;
			<PIDD_Tick>d__.<>t__builder.Start<Bypass.<PIDD_Tick>d__50>(ref <PIDD_Tick>d__);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000362C File Offset: 0x0000182C
		private void method_13()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bypass));
			this.siticoneDragControl_0 = new SiticoneDragControl(this.icontainer_0);
			this.siticoneDragControl_1 = new SiticoneDragControl(this.icontainer_0);
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.siticonePanel_0 = new SiticonePanel();
			this.siticoneTrackBar_0 = new SiticoneTrackBar();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.mAkRwNbwIm = new SiticoneControlBox();
			this.siticoneControlBox_0 = new SiticoneControlBox();
			this.siticoneCirclePictureBox_0 = new SiticoneCirclePictureBox();
			this.siticoneBorderlessForm_0 = new SiticoneBorderlessForm(this.icontainer_0);
			this.timer_2 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.siticonePanel_1 = new SiticonePanel();
			this.label_4 = new Label();
			this.siticoneProgressBar_0 = new SiticoneProgressBar();
			this.siticoneImageButton_0 = new SiticoneImageButton();
			this.siticoneComboBox_0 = new SiticoneComboBox();
			this.siticoneImageButton_2 = new SiticoneImageButton();
			this.siticoneImageButton_1 = new SiticoneImageButton();
			this.label_5 = new Label();
			this.timer_3 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.siticonePanel_0.SuspendLayout();
			((ISupportInitialize)this.siticoneCirclePictureBox_0).BeginInit();
			this.siticonePanel_1.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_1.Interval = 10;
			this.timer_1.Tick += this.timer_1_Tick;
			this.siticonePanel_0.BackColor = Color.Transparent;
			this.siticonePanel_0.BorderColor = Color.FromArgb(220, 1, 3);
			this.siticonePanel_0.BorderRadius = 3;
			this.siticonePanel_0.BorderThickness = 2;
			this.siticonePanel_0.Controls.Add(this.siticoneTrackBar_0);
			this.siticonePanel_0.Controls.Add(this.label_0);
			this.siticonePanel_0.Location = new Point(15, 387);
			this.siticonePanel_0.Name = "siticonePanel1";
			this.siticonePanel_0.ShadowDecoration.Parent = this.siticonePanel_0;
			this.siticonePanel_0.Size = new Size(291, 36);
			this.siticonePanel_0.TabIndex = 61;
			this.siticonePanel_0.Paint += this.siticonePanel_0_Paint;
			this.siticoneTrackBar_0.BackColor = Color.Transparent;
			this.siticoneTrackBar_0.FillColor = Color.Yellow;
			this.siticoneTrackBar_0.HoverState.Parent = this.siticoneTrackBar_0;
			this.siticoneTrackBar_0.Location = new Point(48, 8);
			this.siticoneTrackBar_0.Maximum = 360;
			this.siticoneTrackBar_0.Minimum = 220;
			this.siticoneTrackBar_0.Name = "ipadTrackBar1";
			this.siticoneTrackBar_0.Size = new Size(230, 20);
			this.siticoneTrackBar_0.Style = TrackBarStyle.Metro;
			this.siticoneTrackBar_0.TabIndex = 106;
			this.siticoneTrackBar_0.ThumbColor = Color.Red;
			this.siticoneTrackBar_0.Value = 360;
			this.siticoneTrackBar_0.Scroll += this.siticoneTrackBar_0_Scroll;
			this.label_0.AutoSize = true;
			this.label_0.BackColor = Color.Transparent;
			this.label_0.Font = new Font("Ebrima", 9f, FontStyle.Bold);
			this.label_0.ForeColor = Color.Yellow;
			this.label_0.Location = new Point(5, 10);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(38, 15);
			this.label_0.TabIndex = 105;
			this.label_0.Text = "IPAD:";
			this.label_1.AutoSize = true;
			this.label_1.BackColor = Color.Transparent;
			this.label_1.Font = new Font("Ebrima", 9f, FontStyle.Bold);
			this.label_1.ForeColor = Color.FromArgb(4, 108, 54);
			this.label_1.Location = new Point(612, 429);
			this.label_1.Name = "Expiring";
			this.label_1.Size = new Size(37, 15);
			this.label_1.TabIndex = 60;
			this.label_1.Text = "DATE";
			this.label_2.AutoSize = true;
			this.label_2.BackColor = Color.Transparent;
			this.label_2.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label_2.ForeColor = Color.FromArgb(220, 1, 3);
			this.label_2.Location = new Point(72, 429);
			this.label_2.Name = "status";
			this.label_2.Size = new Size(133, 15);
			this.label_2.TabIndex = 59;
			this.label_2.Text = "WELCOME TO RBG VIP";
			this.label_3.AutoSize = true;
			this.label_3.BackColor = Color.Transparent;
			this.label_3.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label_3.ForeColor = Color.Yellow;
			this.label_3.Location = new Point(18, 429);
			this.label_3.Name = "label10";
			this.label_3.Size = new Size(61, 15);
			this.label_3.TabIndex = 58;
			this.label_3.Text = "STATUS : ";
			this.mAkRwNbwIm.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.mAkRwNbwIm.BackColor = Color.Transparent;
			this.mAkRwNbwIm.ControlBoxType = ControlBoxType.MinimizeBox;
			this.mAkRwNbwIm.FillColor = Color.Transparent;
			this.mAkRwNbwIm.ForeColor = Color.Transparent;
			this.mAkRwNbwIm.HoverState.Parent = this.mAkRwNbwIm;
			this.mAkRwNbwIm.IconColor = Color.White;
			this.mAkRwNbwIm.Location = new Point(730, 5);
			this.mAkRwNbwIm.Name = "siticoneControlBox2";
			this.mAkRwNbwIm.ShadowDecoration.Parent = this.mAkRwNbwIm;
			this.mAkRwNbwIm.Size = new Size(25, 21);
			this.mAkRwNbwIm.TabIndex = 56;
			this.mAkRwNbwIm.Click += this.mAkRwNbwIm_Click;
			this.siticoneControlBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.siticoneControlBox_0.BackColor = Color.Transparent;
			this.siticoneControlBox_0.FillColor = Color.Transparent;
			this.siticoneControlBox_0.ForeColor = Color.Transparent;
			this.siticoneControlBox_0.HoverState.Parent = this.siticoneControlBox_0;
			this.siticoneControlBox_0.IconColor = Color.White;
			this.siticoneControlBox_0.Location = new Point(763, 5);
			this.siticoneControlBox_0.Name = "siticoneControlBox1";
			this.siticoneControlBox_0.ShadowDecoration.Parent = this.siticoneControlBox_0;
			this.siticoneControlBox_0.Size = new Size(25, 21);
			this.siticoneControlBox_0.TabIndex = 49;
			this.siticoneControlBox_0.Click += this.siticoneControlBox_0_Click;
			this.siticoneCirclePictureBox_0.FillColor = Color.Red;
			this.siticoneCirclePictureBox_0.ImageRotate = 0f;
			this.siticoneCirclePictureBox_0.Location = new Point(734, 403);
			this.siticoneCirclePictureBox_0.Name = "statusPictureBox1";
			this.siticoneCirclePictureBox_0.ShadowDecoration.Mode = ShadowMode.Circle;
			this.siticoneCirclePictureBox_0.ShadowDecoration.Parent = this.siticoneCirclePictureBox_0;
			this.siticoneCirclePictureBox_0.Size = new Size(12, 12);
			this.siticoneCirclePictureBox_0.TabIndex = 57;
			this.siticoneCirclePictureBox_0.TabStop = false;
			this.siticoneCirclePictureBox_0.Visible = false;
			this.siticoneBorderlessForm_0.BorderRadius = 30;
			this.siticoneBorderlessForm_0.ContainerControl = this;
			this.siticoneBorderlessForm_0.ResizeForm = false;
			this.timer_2.Interval = 2000;
			this.timer_2.Tick += this.timer_2_Tick;
			this.siticonePanel_1.Controls.Add(this.label_4);
			this.siticonePanel_1.Controls.Add(this.siticoneProgressBar_0);
			this.siticonePanel_1.Location = new Point(12, 195);
			this.siticonePanel_1.Name = "updatePanel2";
			this.siticonePanel_1.ShadowDecoration.Parent = this.siticonePanel_1;
			this.siticonePanel_1.Size = new Size(309, 58);
			this.siticonePanel_1.TabIndex = 63;
			this.siticonePanel_1.Visible = false;
			this.label_4.AutoSize = true;
			this.label_4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_4.ForeColor = Color.FromArgb(220, 1, 3);
			this.label_4.Location = new Point(26, 34);
			this.label_4.Name = "label6";
			this.label_4.Size = new Size(249, 20);
			this.label_4.TabIndex = 1;
			this.label_4.Text = "DOWNLOADING UPDATE WAIT!";
			this.siticoneProgressBar_0.Location = new Point(11, 8);
			this.siticoneProgressBar_0.Name = "updatedownloadProgressBar4";
			this.siticoneProgressBar_0.ProgressColor = Color.FromArgb(220, 1, 3);
			this.siticoneProgressBar_0.ProgressColor2 = Color.FromArgb(220, 1, 3);
			this.siticoneProgressBar_0.ShadowDecoration.Parent = this.siticoneProgressBar_0;
			this.siticoneProgressBar_0.Size = new Size(276, 20);
			this.siticoneProgressBar_0.TabIndex = 0;
			this.siticoneProgressBar_0.TextRenderingHint = TextRenderingHint.SystemDefault;
			this.siticoneImageButton_0.BackColor = Color.Transparent;
			this.siticoneImageButton_0.BackgroundImageLayout = ImageLayout.Zoom;
			this.siticoneImageButton_0.CheckedState.ImageSize = new Size(64, 64);
			this.siticoneImageButton_0.CheckedState.Parent = this.siticoneImageButton_0;
			this.siticoneImageButton_0.HoverState.Image = Resources.runemuInverse1;
			this.siticoneImageButton_0.HoverState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_0.HoverState.Parent = this.siticoneImageButton_0;
			this.siticoneImageButton_0.Image = Resources.runemulator_img;
			this.siticoneImageButton_0.ImageOffset = new Point(0, 0);
			this.siticoneImageButton_0.ImageRotate = 0f;
			this.siticoneImageButton_0.ImageSize = new Size(306, 54);
			this.siticoneImageButton_0.Location = new Point(12, 199);
			this.siticoneImageButton_0.Name = "EmulatorStartButton1";
			this.siticoneImageButton_0.PressedState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_0.PressedState.Parent = this.siticoneImageButton_0;
			this.siticoneImageButton_0.ShadowDecoration.Parent = this.siticoneImageButton_0;
			this.siticoneImageButton_0.Size = new Size(309, 54);
			this.siticoneImageButton_0.TabIndex = 64;
			this.siticoneImageButton_0.Click += this.siticoneImageButton_0_Click;
			this.siticoneComboBox_0.BackColor = Color.Transparent;
			this.siticoneComboBox_0.BorderColor = Color.FromArgb(220, 1, 3);
			this.siticoneComboBox_0.BorderRadius = 3;
			this.siticoneComboBox_0.BorderThickness = 2;
			this.siticoneComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
			this.siticoneComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.siticoneComboBox_0.FillColor = Color.Black;
			this.siticoneComboBox_0.FocusedColor = Color.FromArgb(220, 1, 3);
			this.siticoneComboBox_0.FocusedState.BorderColor = Color.FromArgb(220, 1, 3);
			this.siticoneComboBox_0.FocusedState.ForeColor = Color.FromArgb(220, 1, 3);
			this.siticoneComboBox_0.FocusedState.Parent = this.siticoneComboBox_0;
			this.siticoneComboBox_0.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.siticoneComboBox_0.ForeColor = Color.FromArgb(220, 1, 3);
			this.siticoneComboBox_0.HoverState.Parent = this.siticoneComboBox_0;
			this.siticoneComboBox_0.ItemHeight = 30;
			this.siticoneComboBox_0.Items.AddRange(new object[]
			{
				"PUBG GLOBAL",
				"PUBG TAIWAN",
				"PUBG VIETNAM",
				"PUBG KOREA",
				"PUBG INDIA"
			});
			this.siticoneComboBox_0.ItemsAppearance.Parent = this.siticoneComboBox_0;
			this.siticoneComboBox_0.Location = new Point(12, 154);
			this.siticoneComboBox_0.Name = "VersionBox1";
			this.siticoneComboBox_0.ShadowDecoration.Parent = this.siticoneComboBox_0;
			this.siticoneComboBox_0.Size = new Size(294, 36);
			this.siticoneComboBox_0.StartIndex = 0;
			this.siticoneComboBox_0.TabIndex = 65;
			this.siticoneImageButton_2.BackColor = Color.Transparent;
			this.siticoneImageButton_2.BackgroundImageLayout = ImageLayout.Zoom;
			this.siticoneImageButton_2.CheckedState.ImageSize = new Size(64, 64);
			this.siticoneImageButton_2.CheckedState.Parent = this.siticoneImageButton_2;
			this.siticoneImageButton_2.HoverState.Image = Resources.Rungameinverse;
			this.siticoneImageButton_2.HoverState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_2.HoverState.Parent = this.siticoneImageButton_2;
			this.siticoneImageButton_2.Image = Resources.rungame;
			this.siticoneImageButton_2.ImageOffset = new Point(0, 0);
			this.siticoneImageButton_2.ImageRotate = 0f;
			this.siticoneImageButton_2.ImageSize = new Size(306, 54);
			this.siticoneImageButton_2.Location = new Point(12, 263);
			this.siticoneImageButton_2.Name = "GameStartButton2";
			this.siticoneImageButton_2.PressedState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_2.PressedState.Parent = this.siticoneImageButton_2;
			this.siticoneImageButton_2.ShadowDecoration.Parent = this.siticoneImageButton_2;
			this.siticoneImageButton_2.Size = new Size(309, 54);
			this.siticoneImageButton_2.TabIndex = 66;
			this.siticoneImageButton_2.Click += this.siticoneImageButton_2_Click;
			this.siticoneImageButton_1.BackColor = Color.Transparent;
			this.siticoneImageButton_1.BackgroundImageLayout = ImageLayout.Zoom;
			this.siticoneImageButton_1.CheckedState.ImageSize = new Size(64, 64);
			this.siticoneImageButton_1.CheckedState.Parent = this.siticoneImageButton_1;
			this.siticoneImageButton_1.HoverState.Image = Resources.safeexitinverse;
			this.siticoneImageButton_1.HoverState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_1.HoverState.Parent = this.siticoneImageButton_1;
			this.siticoneImageButton_1.Image = Resources.safeexit;
			this.siticoneImageButton_1.ImageOffset = new Point(0, 0);
			this.siticoneImageButton_1.ImageRotate = 0f;
			this.siticoneImageButton_1.ImageSize = new Size(306, 54);
			this.siticoneImageButton_1.Location = new Point(12, 327);
			this.siticoneImageButton_1.Name = "SafeExitButton3";
			this.siticoneImageButton_1.PressedState.ImageSize = new Size(306, 54);
			this.siticoneImageButton_1.PressedState.Parent = this.siticoneImageButton_1;
			this.siticoneImageButton_1.ShadowDecoration.Parent = this.siticoneImageButton_1;
			this.siticoneImageButton_1.Size = new Size(309, 54);
			this.siticoneImageButton_1.TabIndex = 67;
			this.siticoneImageButton_1.Click += this.siticoneImageButton_1_Click;
			this.label_5.AutoSize = true;
			this.label_5.BackColor = Color.Transparent;
			this.label_5.Font = new Font("Ebrima", 9f, FontStyle.Bold);
			this.label_5.ForeColor = Color.FromArgb(0, 192, 192);
			this.label_5.Location = new Point(565, 429);
			this.label_5.Name = "label1";
			this.label_5.Size = new Size(50, 15);
			this.label_5.TabIndex = 68;
			this.label_5.Text = "EXPIRY:";
			this.timer_3.Enabled = true;
			this.timer_3.Interval = 1000;
			this.timer_3.Tick += this.timer_3_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			this.BackgroundImage = Resources.Final;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.siticoneImageButton_1);
			base.Controls.Add(this.siticonePanel_1);
			base.Controls.Add(this.siticoneImageButton_2);
			base.Controls.Add(this.siticoneComboBox_0);
			base.Controls.Add(this.siticoneImageButton_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.mAkRwNbwIm);
			base.Controls.Add(this.siticoneControlBox_0);
			base.Controls.Add(this.siticoneCirclePictureBox_0);
			base.Controls.Add(this.siticonePanel_0);
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(1920, 1040);
			base.Name = "Bypass";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "BYPASS";
			base.FormClosing += this.Bypass_FormClosing;
			base.FormClosed += this.KqAucWlbf;
			base.Load += this.Bypass_Load;
			this.siticonePanel_0.ResumeLayout(false);
			this.siticonePanel_0.PerformLayout();
			((ISupportInitialize)this.siticoneCirclePictureBox_0).EndInit();
			this.siticonePanel_1.ResumeLayout(false);
			this.siticonePanel_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004A28 File Offset: 0x00002C28
		[CompilerGenerated]
		private void method_14()
		{
			try
			{
				if (!Directory.Exists("C:\\ProgramData\\Microosoft"))
				{
					Thread.Sleep(100);
					Directory.CreateDirectory("C:\\ProgramData\\Microosoft");
					this.webClient_0.DownloadFileCompleted += this.webClient_0_DownloadFileCompleted;
					this.webClient_0.DownloadProgressChanged += this.webClient_0_DownloadProgressChanged;
					Uri address = new Uri(this.string_3);
					this.webClient_0.DownloadFileAsync(address, "C:\\ProgramData\\Microosoft\\xyz");
				}
				else if (!File.Exists("C:\\ProgramData\\Microosoft\\" + this.string_2))
				{
					Thread.Sleep(100);
					Bypass.DeleteFilesAndFoldersRecursively("C:\\ProgramData\\Microosoft");
					Thread.Sleep(100);
					Directory.CreateDirectory("C:\\ProgramData\\Microosoft");
					Thread.Sleep(100);
					this.webClient_0.DownloadFileCompleted += this.webClient_0_DownloadFileCompleted;
					this.webClient_0.DownloadProgressChanged += this.webClient_0_DownloadProgressChanged;
					Uri address2 = new Uri(this.string_3);
					this.webClient_0.DownloadFileAsync(address2, "C:\\ProgramData\\Microosoft\\xyz");
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004B48 File Offset: 0x00002D48
		[CompilerGenerated]
		private void method_15()
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				RedirectStandardInput = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			using (StreamWriter standardInput = process.StandardInput)
			{
				if (standardInput.BaseStream.CanWrite)
				{
					this.method_10();
					standardInput.WriteLine("TaskKill /F /IM AndroidemulatorEx.exe");
					standardInput.WriteLine("TaskKill /F /IM AndroidemulatorEx.exe");
					standardInput.WriteLine("TaskKill /F /IM AndroidemulatorEx.exe");
					standardInput.WriteLine("netsh advfirewall firewall delete rule name=LOOP");
				}
			}
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Tencent\\MobileGamePC\\", true))
			{
				if (registryKey != null)
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Tencent\\MobileGamePC\\", true);
					registryKey2.SetValue("AdbDisable", 0);
					registryKey2.Close();
				}
			}
			using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\", true))
			{
				if (registryKey3 != null)
				{
					RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\", true);
					registryKey4.SetValue("Hidden", 0);
					registryKey4.Close();
				}
			}
			RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", true);
			string text = registryKey5.GetValue("InstallPath").ToString();
			this.string_1 = registryKey5.GetValue("InstallPath").ToString() + "\\d3d9.dll";
			registryKey5.Close();
			Task.Delay(5000).Wait();
			if (File.Exists(text + "\\AndroidEmulatorEx.exe"))
			{
				if (!File.Exists(text + "\\d3d9.dll"))
				{
					try
					{
						if (!File.Exists("C:\\ProgramData\\Microosoft\\" + this.string_2))
						{
							MessageBox.Show("New Update Download Failed. Restart Bypass with VPN Connected");
						}
						else
						{
							File.Copy("C:\\ProgramData\\Microosoft\\" + this.string_2, text + "\\d3d9.dll");
						}
						goto IL_2EF;
					}
					catch (Exception)
					{
						goto IL_2EF;
					}
				}
				process.Start();
				using (StreamWriter standardInput2 = process.StandardInput)
				{
					if (standardInput2.BaseStream.CanWrite)
					{
						standardInput2.WriteLine("del /f " + text + "\\d3d9.dll");
						standardInput2.WriteLine("del /f " + text + "\\d3d9.dll");
						try
						{
							if (File.Exists(text + "\\d3d9.dll"))
							{
								File.Delete(text + "\\d3d9.dll");
							}
							if (File.Exists(text + "\\d3d9.dll"))
							{
								File.Delete(text + "\\d3d9.dll");
							}
						}
						catch (Exception)
						{
						}
						Thread.Sleep(2000);
						try
						{
							if (File.Exists("C:\\ProgramData\\Microosoft\\" + this.string_2))
							{
								File.Copy("C:\\ProgramData\\Microosoft\\" + this.string_2, text + "\\d3d9.dll");
							}
							else
							{
								MessageBox.Show("New Update Download Failed. Restart Bypass with VPN Connected");
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			IL_2EF:
			string path = text + "\\d3d9.dll";
			if (File.Exists(path))
			{
				File.GetAttributes(path);
				File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
			}
			if (File.Exists(text + "\\AndroidEmulatorEx.exe"))
			{
				Thread.Sleep(1000);
				this.label_2.Text = "STARTING EMULATOR";
				try
				{
					Process.Start(text + "\\AndroidEmulatorEx.exe", " -vm 100");
				}
				catch (Exception)
				{
				}
			}
			Task.Delay(2000).Wait();
			RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\AOW_Rootfs_100", true);
			string path2 = registryKey6.GetValue("InstallPath").ToString() + "\\comp_ver.conf";
			registryKey6.Close();
			if (File.Exists(path2))
			{
				this.label_2.Text = "Gameloop x64";
			}
			else
			{
				this.label_2.Text = "Gameloop x32";
			}
			Thread.Sleep(8000);
			this.siticoneImageButton_0.Enabled = true;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004FA4 File Offset: 0x000031A4
		[CompilerGenerated]
		private void method_16()
		{
			this.siticoneImageButton_2.Enabled = false;
			this.method_0();
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Tencent\\MobileGamePC\\UI", true);
			registryKey.GetValue("InstallPath").ToString();
			this.string_1 = registryKey.GetValue("InstallPath").ToString() + "\\d3d9.dll";
			registryKey.Close();
			this.label_2.Text = "INITIAL WORKING";
			this.siticoneCirclePictureBox_0.FillColor = Color.Red;
			string path = "C:\\ProgramData\\XD";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (!File.Exists("C:\\Windows\\adb.exe"))
			{
				File.WriteAllBytes("C:\\Windows\\adb.exe", Resources.adb);
				File.WriteAllBytes("C:\\Windows\\AdbWinApi.dll", Resources.AdbWinApi);
			}
			if (!File.Exists("C:\\teneightyp.dll"))
			{
				File.WriteAllBytes("C:\\teneightyp.dll", Resources.teneightyp);
			}
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				RedirectStandardInput = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();
			using (StreamWriter standardInput = process.StandardInput)
			{
				if (standardInput.BaseStream.CanWrite)
				{
					if (this.siticoneComboBox_0.SelectedIndex == 4)
					{
						this.string_0 = "com.pubg.imobile";
					}
					if (this.siticoneComboBox_0.SelectedIndex == 0)
					{
						this.string_0 = "com.tencent.ig";
					}
					if (this.siticoneComboBox_0.SelectedIndex == 2)
					{
						this.string_0 = "com.vng.pubgmobile";
					}
					if (this.siticoneComboBox_0.SelectedIndex == 3)
					{
						this.string_0 = "com.pubg.krmobile";
					}
					if (this.siticoneComboBox_0.SelectedIndex == 1)
					{
						this.string_0 = "com.rekoo.pubgm";
					}
					standardInput.WriteLine("cd C:\\Windows");
					if (!File.Exists(this.string_1))
					{
						standardInput.WriteLine("adb kill-server");
						standardInput.WriteLine("adb devices");
					}
					standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb push C:\\teneightypkr.dll /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb -s emulator-5554 shell content insert --uri content://settings/secure --bind name:s:android_id --bind value:s:%random%6b1a77f674510efbe5216b1b1b41%random%");
					standardInput.WriteLine("adb shell am force-stop com.pubg.imobile");
					standardInput.WriteLine("adb shell am force-stop com.vng.pubgmobile");
					standardInput.WriteLine("adb shell am force-stop com.pubg.krmobile");
					standardInput.WriteLine("adb shell am force-stop com.tencent.ig");
					standardInput.WriteLine("adb shell rm -rf /data/data/com.pubg.imobile/files/AreaData.dat");
					standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb push C:\\teneightyp.dll /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb shell rm -rf /data/data/com.pubg.imobile/files/AreaData.dat");
					standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb push C:\\teneightyp.dll /storage/emulated/0/Android/data/com.pubg.imobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					if (File.Exists("C:\\Windows\\teneightyp2.dll"))
					{
						File.Delete("C:\\Windows\\teneightyp2.dll");
						File.WriteAllBytes("C:\\Windows\\teneightyp2.dll", Resources.teneightyp2);
					}
					else
					{
						File.WriteAllBytes("C:\\Windows\\teneightyp2.dll", Resources.teneightyp2);
					}
					if (File.Exists("C:\\Windows\\teneightyp3.dll"))
					{
						File.Delete("C:\\Windows\\teneightyp3.dll");
						File.WriteAllBytes("C:\\Windows\\teneightyp3.dll", Resources.teneightyp3);
					}
					else
					{
						File.WriteAllBytes("C:\\Windows\\teneightyp3.dll", Resources.teneightyp3);
					}
					standardInput.WriteLine("adb shell rm -rf /data/data/com.pubg.krmobile/files/AreaData.dat");
					standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/GameUserSettings.ini");
					standardInput.WriteLine("adb push C:\\Windows\\teneightyp2.dll /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/UserCustom.ini");
					standardInput.WriteLine("adb push C:\\Windows\\teneightyp3.dll /storage/emulated/0/Android/data/com.pubg.krmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config/Android/GameUserSettings.ini");
					standardInput.WriteLine("adb shell rm -rf /data/data/" + this.string_0 + "/databases");
					standardInput.WriteLine("adb -s emulator-5554 shell rm -rf /sdcard/Android/data/" + this.string_0 + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs");
					standardInput.WriteLine("adb -s emulator-5554 shell rm -rf /sdcard/Android/data/" + this.string_0 + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs0");
					standardInput.WriteLine("adb -s emulator-5554 shell rm -rf /sdcard/Android/data/" + this.string_0 + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs1");
					standardInput.WriteLine("adb shell am force-stop com.pubg.imobile");
					standardInput.WriteLine("adb shell am force-stop com.vng.pubgmobile");
					standardInput.WriteLine("adb shell am force-stop com.pubg.krmobile");
					standardInput.WriteLine("adb shell am force-stop com.tencent.ig");
					standardInput.WriteLine("adb shell am force-stop com.rekoo.pubgm");
					Thread.Sleep(5000);
					this.siticoneCirclePictureBox_0.FillColor = Color.Yellow;
					if (File.Exists(this.string_1))
					{
						this.siticoneImageButton_2.Enabled = true;
						standardInput.WriteLine("adb -s emulator-5554 shell am start -n " + this.string_0 + "/com.epicgames.ue4.SplashActivity filter");
						standardInput.WriteLine("cd C:\\Windows\\System32");
						standardInput.WriteLine("TaskKill /F /IM appmarket.exe");
					}
					else
					{
						this.siticoneImageButton_2.Enabled = true;
						this.label_2.Text = "Restart Emulator";
						this.siticoneCirclePictureBox_0.FillColor = Color.Red;
						standardInput.WriteLine("adb shell am force-stop com.pubg.imobile");
						standardInput.WriteLine("adb shell am force-stop com.vng.pubgmobile");
						standardInput.WriteLine("adb shell am force-stop com.pubg.krmobile");
						standardInput.WriteLine("adb shell am force-stop com.tencent.ig");
					}
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002294 File Offset: 0x00000494
		[CompilerGenerated]
		private void method_17()
		{
			Thread.Sleep(8000);
			this.label_2.Text = "EXIT DONE";
			this.siticoneCirclePictureBox_0.FillColor = Color.Red;
			this.siticoneImageButton_1.Enabled = true;
		}

		// Token: 0x04000002 RID: 2
		public Mem MemLib = new Mem();

		// Token: 0x04000003 RID: 3
		private string string_0;

		// Token: 0x04000004 RID: 4
		private string string_1;

		// Token: 0x04000005 RID: 5
		[CompilerGenerated]
		private Point zPaWorZg8;

		// Token: 0x04000006 RID: 6
		public DiscordRpcClient client;

		// Token: 0x04000007 RID: 7
		private WebClient webClient_0 = new WebClient();

		// Token: 0x04000008 RID: 8
		private string string_2;

		// Token: 0x04000009 RID: 9
		private string string_3;

		// Token: 0x0400000B RID: 11
		private SiticoneDragControl siticoneDragControl_0;

		// Token: 0x0400000C RID: 12
		private SiticoneDragControl siticoneDragControl_1;

		// Token: 0x0400000D RID: 13
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x0400000E RID: 14
		private ToolTip toolTip_0;

		// Token: 0x0400000F RID: 15
		private System.Windows.Forms.Timer timer_1;

		// Token: 0x04000010 RID: 16
		private SiticonePanel siticonePanel_0;

		// Token: 0x04000011 RID: 17
		private SiticoneTrackBar siticoneTrackBar_0;

		// Token: 0x04000012 RID: 18
		private Label label_0;

		// Token: 0x04000013 RID: 19
		private Label label_1;

		// Token: 0x04000014 RID: 20
		private Label label_2;

		// Token: 0x04000015 RID: 21
		private Label label_3;

		// Token: 0x04000016 RID: 22
		private SiticoneControlBox mAkRwNbwIm;

		// Token: 0x04000017 RID: 23
		private SiticoneControlBox siticoneControlBox_0;

		// Token: 0x04000018 RID: 24
		private SiticoneCirclePictureBox siticoneCirclePictureBox_0;

		// Token: 0x04000019 RID: 25
		private SiticoneBorderlessForm siticoneBorderlessForm_0;

		// Token: 0x0400001A RID: 26
		private System.Windows.Forms.Timer timer_2;

		// Token: 0x0400001B RID: 27
		private SiticonePanel siticonePanel_1;

		// Token: 0x0400001C RID: 28
		private Label label_4;

		// Token: 0x0400001D RID: 29
		private SiticoneProgressBar siticoneProgressBar_0;

		// Token: 0x0400001E RID: 30
		private SiticoneImageButton siticoneImageButton_0;

		// Token: 0x0400001F RID: 31
		private SiticoneComboBox siticoneComboBox_0;

		// Token: 0x04000020 RID: 32
		private SiticoneImageButton siticoneImageButton_1;

		// Token: 0x04000021 RID: 33
		private SiticoneImageButton siticoneImageButton_2;

		// Token: 0x04000022 RID: 34
		private Label label_5;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Timer timer_3;

		// Token: 0x02000003 RID: 3
		public struct ProcessEntry32
		{
			// Token: 0x04000024 RID: 36
			public uint dwSize;

			// Token: 0x04000025 RID: 37
			public uint cntUsage;

			// Token: 0x04000026 RID: 38
			public uint th32ProcessID;

			// Token: 0x04000027 RID: 39
			public IntPtr th32DefaultHeapID;

			// Token: 0x04000028 RID: 40
			public uint th32ModuleID;

			// Token: 0x04000029 RID: 41
			public uint cntThreads;

			// Token: 0x0400002A RID: 42
			public uint uint_0;

			// Token: 0x0400002B RID: 43
			public int pcPriClassBase;

			// Token: 0x0400002C RID: 44
			public uint dwFlags;

			// Token: 0x0400002D RID: 45
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}
	}
}
