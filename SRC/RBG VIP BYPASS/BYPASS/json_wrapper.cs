using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BYPASS
{
	// Token: 0x0200002C RID: 44
	public class json_wrapper
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000027AC File Offset: 0x000009AC
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008720 File Offset: 0x00006920
		public json_wrapper(object obj_to_work_with)
		{
			this.object_0 = obj_to_work_with;
			Type type = this.object_0.GetType();
			this.dataContractJsonSerializer_0 = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.object_0));
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008770 File Offset: 0x00006970
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.dataContractJsonSerializer_0.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000027C9 File Offset: 0x000009C9
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x040000C6 RID: 198
		private DataContractJsonSerializer dataContractJsonSerializer_0;

		// Token: 0x040000C7 RID: 199
		private object object_0;
	}
}
