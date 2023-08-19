using System;
using System.Reflection;

// Token: 0x02000046 RID: 70
internal class Class5
{
	// Token: 0x0600015B RID: 347 RVA: 0x0000B1AC File Offset: 0x000093AC
	internal static void smethod_0(int typemdt)
	{
		Type type = Class5.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class5.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000118 RID: 280
	internal static Module module_0 = typeof(Class5).Assembly.ManifestModule;

	// Token: 0x02000047 RID: 71
	// (Invoke) Token: 0x0600015F RID: 351
	internal delegate void Delegate0(object o);
}
