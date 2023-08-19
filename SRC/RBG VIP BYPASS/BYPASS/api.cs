using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BYPASS
{
	// Token: 0x02000021 RID: 33
	public class api
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00006928 File Offset: 0x00004B28
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs \n Make sure you've added your application name, secret, ownerID, and version in correctly, and that you have KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000069BC File Offset: 0x00004BBC
		public void init()
		{
			this.string_1 = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.string_1, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found. Please check your application name, secret, ownerID, and version.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				this.method_0(@class.appinfo);
				this.string_0 = @class.sessionid;
				this.bool_0 = true;
				return;
			}
			if (@class.message == "invalidver")
			{
				this.app_data.downloadLink = @class.download;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006B40 File Offset: 0x00004D40
		public void register(string username, string pass, string key)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.string_1, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				this.method_1(@class.info);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006CAC File Offset: 0x00004EAC
		public void login(string username, string pass)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				this.method_1(@class.info);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006E00 File Offset: 0x00005000
		public void web_login()
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener = new HttpListener();
			string text = "handshake";
			text = "http://localhost:1337/" + text + "/";
			httpListener.Prefixes.Add(text);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "Via");
			httpListenerResponse.AddHeader("Location", "Location");
			httpListenerResponse.AddHeader("Retry-After", "Retry");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string text2 = request.RawUrl.Replace("/handshake?user=", "").Replace("&token=", " ");
			string value2 = text2.Split(Array.Empty<char>())[0];
			string value3 = text2.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = this.string_0;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.smethod_1(nameValueCollection);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(json);
			this.VmmRsybEvd(@class);
			bool flag = true;
			if (@class.success)
			{
				this.method_1(@class.info);
				httpListenerResponse.StatusCode = 420;
				httpListenerResponse.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(@class.message);
				httpListenerResponse.StatusCode = 200;
				httpListenerResponse.StatusDescription = @class.message;
				flag = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			httpListenerResponse.OutputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1250);
			httpListener.Stop();
			if (!flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007074 File Offset: 0x00005274
		public void button(string button)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first");
				Environment.Exit(0);
			}
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + button + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "Via");
			httpListenerResponse.AddHeader("Location", "Location");
			httpListenerResponse.AddHeader("Retry-After", "Rety");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListenerResponse.StatusCode = 420;
			httpListenerResponse.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000716C File Offset: 0x0000536C
		public void upgrade(string username, string key)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.string_1, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			@class.success = false;
			this.VmmRsybEvd(@class);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000729C File Offset: 0x0000549C
		public void license(string key)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.string_1, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				this.method_1(@class.info);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000073D8 File Offset: 0x000055D8
		public void check()
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 b4AnEwRcZuAoVixN0W0_ = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(b4AnEwRcZuAoVixN0W0_);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000074C0 File Offset: 0x000056C0
		public void setvar(string var, string data)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.string_1, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 b4AnEwRcZuAoVixN0W0_ = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(b4AnEwRcZuAoVixN0W0_);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000075D8 File Offset: 0x000057D8
		public string getvar(string var)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return @class.response;
			}
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000076E8 File Offset: 0x000058E8
		public void ban(string reason = null)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["reason"] = reason;
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 b4AnEwRcZuAoVixN0W0_ = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(b4AnEwRcZuAoVixN0W0_);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000077DC File Offset: 0x000059DC
		public string var(string varid)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return @class.message;
			}
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000078FC File Offset: 0x00005AFC
		public List<api.users> fetchOnline()
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("fetchOnline"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return @class.users;
			}
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000079F4 File Offset: 0x00005BF4
		public List<api.msg> chatget(string channelname)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return @class.messages;
			}
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007B04 File Offset: 0x00005D04
		public bool chatsend(string msg, string channelname)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.string_1, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			return @class.success;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007C28 File Offset: 0x00005E28
		public bool checkblack()
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			return @class.success;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007D44 File Offset: 0x00005F44
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
				return null;
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.string_1, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.string_1, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.string_1, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return @class.response;
			}
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007EA4 File Offset: 0x000060A4
		public byte[] download(string fileid)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.smethod_0(nameValueCollection);
			text2 = encryption.decrypt(text2, this.string_1, text);
			api.Class0 @class = this.json_wrapper_0.string_to_generic<api.Class0>(text2);
			this.VmmRsybEvd(@class);
			if (@class.success)
			{
				return encryption.str_to_byte_arr(@class.contents);
			}
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007FBC File Offset: 0x000061BC
		public void log(string message)
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.string_1, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.string_1, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.string_0));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.smethod_0(nameValueCollection);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000080B8 File Offset: 0x000062B8
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008128 File Offset: 0x00006328
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008178 File Offset: 0x00006378
		private static string smethod_0(NameValueCollection object_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", object_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					result = "";
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008200 File Offset: 0x00006400
		private static string smethod_1(NameValueCollection object_0)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.1/", object_0);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					Thread.Sleep(1000);
					result = api.smethod_0(object_0);
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008288 File Offset: 0x00006488
		private void method_0(api.Class2 tGeKpaRLbHXWOxyg9Tq_0)
		{
			this.app_data.numUsers = tGeKpaRLbHXWOxyg9Tq_0.numUsers;
			this.app_data.numOnlineUsers = tGeKpaRLbHXWOxyg9Tq_0.numOnlineUsers;
			this.app_data.numKeys = tGeKpaRLbHXWOxyg9Tq_0.numKeys;
			this.app_data.version = tGeKpaRLbHXWOxyg9Tq_0.version;
			this.app_data.customerPanelLink = tGeKpaRLbHXWOxyg9Tq_0.customerPanelLink;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000082EC File Offset: 0x000064EC
		private void method_1(api.Class1 rsKhrtRX3Br7jZvMvxG_0)
		{
			this.user_data.username = rsKhrtRX3Br7jZvMvxG_0.username;
			this.user_data.ip = rsKhrtRX3Br7jZvMvxG_0.ip;
			this.user_data.hwid = rsKhrtRX3Br7jZvMvxG_0.hwid;
			this.user_data.createdate = rsKhrtRX3Br7jZvMvxG_0.createdate;
			this.user_data.lastlogin = rsKhrtRX3Br7jZvMvxG_0.lastlogin;
			this.user_data.subscriptions = rsKhrtRX3Br7jZvMvxG_0.subscriptions;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008360 File Offset: 0x00006560
		public string expirydaysleft()
		{
			if (!this.bool_0)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(string.Concat(new string[]
			{
				"AFTER ",
				timeSpan.Days.ToString(),
				" DAYS ",
				timeSpan.Hours.ToString(),
				" HOURS"
			}));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002491 File Offset: 0x00000691
		private void VmmRsybEvd(api.Class0 b4AnEwRcZuAoVixN0W0_0)
		{
			this.response.success = b4AnEwRcZuAoVixN0W0_0.success;
			this.response.message = b4AnEwRcZuAoVixN0W0_0.message;
		}

		// Token: 0x04000090 RID: 144
		public string name;

		// Token: 0x04000091 RID: 145
		public string ownerid;

		// Token: 0x04000092 RID: 146
		public string secret;

		// Token: 0x04000093 RID: 147
		public string version;

		// Token: 0x04000094 RID: 148
		private string string_0;

		// Token: 0x04000095 RID: 149
		private string string_1;

		// Token: 0x04000096 RID: 150
		private bool bool_0;

		// Token: 0x04000097 RID: 151
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000098 RID: 152
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000099 RID: 153
		public api.response_class response = new api.response_class();

		// Token: 0x0400009A RID: 154
		private json_wrapper json_wrapper_0 = new json_wrapper(new api.Class0());

		// Token: 0x02000022 RID: 34
		[DataContract]
		private class Class0
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000089 RID: 137 RVA: 0x000024B5 File Offset: 0x000006B5
			// (set) Token: 0x0600008A RID: 138 RVA: 0x000024BD File Offset: 0x000006BD
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000024C6 File Offset: 0x000006C6
			// (set) Token: 0x0600008C RID: 140 RVA: 0x000024CE File Offset: 0x000006CE
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600008D RID: 141 RVA: 0x000024D7 File Offset: 0x000006D7
			// (set) Token: 0x0600008E RID: 142 RVA: 0x000024DF File Offset: 0x000006DF
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000024E8 File Offset: 0x000006E8
			// (set) Token: 0x06000090 RID: 144 RVA: 0x000024F0 File Offset: 0x000006F0
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000024F9 File Offset: 0x000006F9
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00002501 File Offset: 0x00000701
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000093 RID: 147 RVA: 0x0000250A File Offset: 0x0000070A
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00002512 File Offset: 0x00000712
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000095 RID: 149 RVA: 0x0000251B File Offset: 0x0000071B
			// (set) Token: 0x06000096 RID: 150 RVA: 0x00002523 File Offset: 0x00000723
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.Class1 info { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000097 RID: 151 RVA: 0x0000252C File Offset: 0x0000072C
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00002534 File Offset: 0x00000734
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.Class2 appinfo { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000099 RID: 153 RVA: 0x0000253D File Offset: 0x0000073D
			// (set) Token: 0x0600009A RID: 154 RVA: 0x00002545 File Offset: 0x00000745
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600009B RID: 155 RVA: 0x0000254E File Offset: 0x0000074E
			// (set) Token: 0x0600009C RID: 156 RVA: 0x00002556 File Offset: 0x00000756
			[DataMember]
			public List<api.users> users { get; set; }

			// Token: 0x0400009B RID: 155
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x0400009C RID: 156
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400009D RID: 157
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400009E RID: 158
			[CompilerGenerated]
			private string string_2;

			// Token: 0x0400009F RID: 159
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000A0 RID: 160
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000A1 RID: 161
			[CompilerGenerated]
			private api.Class1 class1_0;

			// Token: 0x040000A2 RID: 162
			[CompilerGenerated]
			private api.Class2 class2_0;

			// Token: 0x040000A3 RID: 163
			[CompilerGenerated]
			private List<api.msg> list_0;

			// Token: 0x040000A4 RID: 164
			[CompilerGenerated]
			private List<api.users> list_1;
		}

		// Token: 0x02000023 RID: 35
		public class msg
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600009E RID: 158 RVA: 0x0000255F File Offset: 0x0000075F
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00002567 File Offset: 0x00000767
			public string message { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002570 File Offset: 0x00000770
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002578 File Offset: 0x00000778
			public string author { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002581 File Offset: 0x00000781
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002589 File Offset: 0x00000789
			public string timestamp { get; set; }

			// Token: 0x040000A5 RID: 165
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000A6 RID: 166
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000A7 RID: 167
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x02000024 RID: 36
		public class users
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002592 File Offset: 0x00000792
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000259A File Offset: 0x0000079A
			public string credential { get; set; }

			// Token: 0x040000A8 RID: 168
			[CompilerGenerated]
			private string string_0;
		}

		// Token: 0x02000025 RID: 37
		[DataContract]
		private class Class1
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x000025A3 File Offset: 0x000007A3
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x000025AB File Offset: 0x000007AB
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000AA RID: 170 RVA: 0x000025B4 File Offset: 0x000007B4
			// (set) Token: 0x060000AB RID: 171 RVA: 0x000025BC File Offset: 0x000007BC
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000AC RID: 172 RVA: 0x000025C5 File Offset: 0x000007C5
			// (set) Token: 0x060000AD RID: 173 RVA: 0x000025CD File Offset: 0x000007CD
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000AE RID: 174 RVA: 0x000025D6 File Offset: 0x000007D6
			// (set) Token: 0x060000AF RID: 175 RVA: 0x000025DE File Offset: 0x000007DE
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x000025E7 File Offset: 0x000007E7
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x000025EF File Offset: 0x000007EF
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x000025F8 File Offset: 0x000007F8
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002600 File Offset: 0x00000800
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000A9 RID: 169
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000AA RID: 170
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000AB RID: 171
			[CompilerGenerated]
			private string string_2;

			// Token: 0x040000AC RID: 172
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000AD RID: 173
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000AE RID: 174
			[CompilerGenerated]
			private List<api.Data> list_0;
		}

		// Token: 0x02000026 RID: 38
		[DataContract]
		private class Class2
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002609 File Offset: 0x00000809
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002611 File Offset: 0x00000811
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000261A File Offset: 0x0000081A
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002622 File Offset: 0x00000822
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000262B File Offset: 0x0000082B
			// (set) Token: 0x060000BA RID: 186 RVA: 0x00002633 File Offset: 0x00000833
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000BB RID: 187 RVA: 0x0000263C File Offset: 0x0000083C
			// (set) Token: 0x060000BC RID: 188 RVA: 0x00002644 File Offset: 0x00000844
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000BD RID: 189 RVA: 0x0000264D File Offset: 0x0000084D
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002655 File Offset: 0x00000855
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000BF RID: 191 RVA: 0x0000265E File Offset: 0x0000085E
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002666 File Offset: 0x00000866
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x040000AF RID: 175
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000B0 RID: 176
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000B1 RID: 177
			[CompilerGenerated]
			private string string_2;

			// Token: 0x040000B2 RID: 178
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000B3 RID: 179
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000B4 RID: 180
			[CompilerGenerated]
			private string string_5;
		}

		// Token: 0x02000027 RID: 39
		public class app_data_class
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000266F File Offset: 0x0000086F
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002677 File Offset: 0x00000877
			public string numUsers { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002680 File Offset: 0x00000880
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002688 File Offset: 0x00000888
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002691 File Offset: 0x00000891
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002699 File Offset: 0x00000899
			public string numKeys { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x000026A2 File Offset: 0x000008A2
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x000026AA File Offset: 0x000008AA
			public string version { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000CA RID: 202 RVA: 0x000026B3 File Offset: 0x000008B3
			// (set) Token: 0x060000CB RID: 203 RVA: 0x000026BB File Offset: 0x000008BB
			public string customerPanelLink { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000CC RID: 204 RVA: 0x000026C4 File Offset: 0x000008C4
			// (set) Token: 0x060000CD RID: 205 RVA: 0x000026CC File Offset: 0x000008CC
			public string downloadLink { get; set; }

			// Token: 0x040000B5 RID: 181
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000B6 RID: 182
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000B7 RID: 183
			[CompilerGenerated]
			private string string_2;

			// Token: 0x040000B8 RID: 184
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000B9 RID: 185
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000BA RID: 186
			[CompilerGenerated]
			private string string_5;
		}

		// Token: 0x02000028 RID: 40
		public class user_data_class
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000CF RID: 207 RVA: 0x000026D5 File Offset: 0x000008D5
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x000026DD File Offset: 0x000008DD
			public string username { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x000026E6 File Offset: 0x000008E6
			// (set) Token: 0x060000D2 RID: 210 RVA: 0x000026EE File Offset: 0x000008EE
			public string ip { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x000026F7 File Offset: 0x000008F7
			// (set) Token: 0x060000D4 RID: 212 RVA: 0x000026FF File Offset: 0x000008FF
			public string hwid { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002708 File Offset: 0x00000908
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002710 File Offset: 0x00000910
			public string createdate { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002719 File Offset: 0x00000919
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002721 File Offset: 0x00000921
			public string lastlogin { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000272A File Offset: 0x0000092A
			// (set) Token: 0x060000DA RID: 218 RVA: 0x00002732 File Offset: 0x00000932
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000BB RID: 187
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000BC RID: 188
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000BD RID: 189
			[CompilerGenerated]
			private string string_2;

			// Token: 0x040000BE RID: 190
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000BF RID: 191
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000C0 RID: 192
			[CompilerGenerated]
			private List<api.Data> list_0;
		}

		// Token: 0x02000029 RID: 41
		public class Data
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000DC RID: 220 RVA: 0x0000273B File Offset: 0x0000093B
			// (set) Token: 0x060000DD RID: 221 RVA: 0x00002743 File Offset: 0x00000943
			public string subscription { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000274C File Offset: 0x0000094C
			// (set) Token: 0x060000DF RID: 223 RVA: 0x00002754 File Offset: 0x00000954
			public string expiry { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000275D File Offset: 0x0000095D
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002765 File Offset: 0x00000965
			public string timeleft { get; set; }

			// Token: 0x040000C1 RID: 193
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000C2 RID: 194
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000C3 RID: 195
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x0200002A RID: 42
		public class response_class
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000276E File Offset: 0x0000096E
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002776 File Offset: 0x00000976
			public bool success { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000277F File Offset: 0x0000097F
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002787 File Offset: 0x00000987
			public string message { get; set; }

			// Token: 0x040000C4 RID: 196
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x040000C5 RID: 197
			[CompilerGenerated]
			private string string_0;
		}
	}
}
