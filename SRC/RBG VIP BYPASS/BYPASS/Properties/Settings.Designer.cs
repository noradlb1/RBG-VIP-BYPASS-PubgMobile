using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BYPASS.Properties
{
	// Token: 0x02000042 RID: 66
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002B8A File Offset: 0x00000D8A
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000112 RID: 274
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
