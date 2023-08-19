using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000048 RID: 72
internal class Class6
{
	// Token: 0x06000162 RID: 354 RVA: 0x0000B218 File Offset: 0x00009418
	static Class6()
	{
		Class6.assembly_0 = typeof(Class6).Assembly;
		Class6.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class6.bool_0 = false;
		Class6.bool_1 = false;
		Class6.object_2 = null;
		Class6.dictionary_0 = null;
		Class6.object_3 = new object();
		Class6.int_2 = 0;
		Class6.object_0 = new object();
		Class6.list_0 = null;
		Class6.list_1 = null;
		Class6.byte_0 = new byte[0];
		Class6.byte_1 = new byte[0];
		Class6.intptr_1 = IntPtr.Zero;
		Class6.intptr_3 = IntPtr.Zero;
		Class6.string_0 = new string[0];
		Class6.int_1 = new int[0];
		Class6.int_4 = 1;
		Class6.bool_5 = false;
		Class6.sortedList_0 = new SortedList();
		Class6.int_5 = 0;
		Class6.long_0 = 0L;
		Class6.object_1 = null;
		Class6.object_4 = null;
		Class6.long_1 = 0L;
		Class6.int_0 = 0;
		Class6.bool_4 = false;
		Class6.bool_2 = false;
		Class6.int_3 = 0;
		Class6.intptr_0 = IntPtr.Zero;
		Class6.bool_3 = false;
		Class6.hashtable_0 = new Hashtable();
		Class6.delegate4_0 = null;
		Class6.delegate5_0 = null;
		Class6.delegate6_0 = null;
		Class6.delegate7_0 = null;
		Class6.delegate8_0 = null;
		Class6.delegate9_0 = null;
		Class6.intptr_2 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002238 File Offset: 0x00000438
	private void method_0()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0000B394 File Offset: 0x00009594
	internal static byte[] smethod_0(object object_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - object_0.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)object_0.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)object_0.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < object_0.Length; i++)
		{
			array2[i] = object_0[i];
		}
		byte[] array3 = array2;
		int num4 = object_0.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class6.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class6.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class6.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class6.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class6.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class6.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class6.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class6.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class6.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class6.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class6.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class6.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class6.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class6.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class6.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class6.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class6.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002BDB File Offset: 0x00000DDB
	private static void smethod_1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Class6.smethod_5(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + object_0[(int)uint_4] + Class6.uint_0[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002C04 File Offset: 0x00000E04
	private static void smethod_2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Class6.smethod_5(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + object_0[(int)uint_4] + Class6.uint_0[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002C2D File Offset: 0x00000E2D
	private static void smethod_3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Class6.smethod_5(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + object_0[(int)uint_4] + Class6.uint_0[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002C53 File Offset: 0x00000E53
	private static void smethod_4(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Class6.smethod_5(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + object_0[(int)uint_4] + Class6.uint_0[(int)(uint_5 - 1U)], ushort_0);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002C7A File Offset: 0x00000E7A
	private static uint smethod_5(uint uint_0, ushort ushort_0)
	{
		return uint_0 >> (int)(32 - ushort_0) | uint_0 << (int)ushort_0;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002C8C File Offset: 0x00000E8C
	internal static bool smethod_6()
	{
		if (!Class6.bool_0)
		{
			Class6.smethod_8();
			Class6.bool_0 = true;
		}
		return Class6.bool_1;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000022D8 File Offset: 0x000004D8
	internal Class6()
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	private void method_1(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int num = byte_2.Length % 4;
		int num2 = byte_2.Length / 4;
		byte[] array = new byte[byte_2.Length];
		int num3 = byte_0.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_0[(int)(num7 + 3U)] << 24 | (int)byte_0[(int)(num7 + 2U)] << 16 | (int)byte_0[(int)(num7 + 1U)] << 8 | (int)byte_0[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_2[byte_2.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 = 70286530U * (num13 & 15U) + (num13 >> 4);
			uint num14 = 1979386766U + num13;
			uint num15 = (num13 << 5 | num13 >> 27) + num14;
			uint num16 = num15 & 16711935U;
			num15 &= 4278255360U;
			num13 = (num15 >> 8 | num16 << 8);
			uint num17 = num14 / 47090332U + 47090332U;
			uint num18 = (num14 + num14) * num17 + num14;
			num13 ^= num13 << 5;
			num13 += 791857896U;
			num13 ^= num13 << 12;
			num13 += num13;
			num13 ^= num13 >> 21;
			num13 += num18;
			num13 = ((num13 << 8) + num14 ^ num13) + num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num19 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num19 & num9) >> num10);
				}
			}
			else
			{
				uint num20 = num4 ^ num11;
				array[num6] = (byte)(num20 & 255U);
				array[num6 + 1] = (byte)((num20 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num20 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num20 & 4278190080U) >> 24);
			}
		}
		Class6.byte_0 = array;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0000BC9C File Offset: 0x00009E9C
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class6.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000BD1C File Offset: 0x00009F1C
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class6.bool_1 = true;
			return;
		}
		try
		{
			Class6.bool_1 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002CA5 File Offset: 0x00000EA5
	internal static byte[] smethod_9(byte[] object_0)
	{
		if (!Class6.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(object_0);
		}
		return Class6.smethod_0(object_0);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000BD68 File Offset: 0x00009F68
	internal static void smethod_10(HashAlgorithm object_0, Stream object_1, uint uint_0, byte[] object_2)
	{
		while (uint_0 > 0U)
		{
			int num = (uint_0 > (uint)object_2.Length) ? object_2.Length : ((int)uint_0);
			object_1.Read(object_2, 0, num);
			Class6.smethod_11(object_0, object_2, 0, num);
			uint_0 -= (uint)num;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002CC0 File Offset: 0x00000EC0
	internal static void smethod_11(HashAlgorithm object_0, byte[] object_1, int int_0, int int_1)
	{
		object_0.TransformBlock(object_1, int_0, int_1, object_1, int_0);
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000BDA4 File Offset: 0x00009FA4
	internal static uint smethod_12(uint uint_0, int int_0, long long_0, BinaryReader object_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			object_0.BaseStream.Position = long_0 + (long)(i * 40 + 8);
			uint num = object_0.ReadUInt32();
			uint num2 = object_0.ReadUInt32();
			object_0.ReadUInt32();
			uint num3 = object_0.ReadUInt32();
			if (num2 <= uint_0 && uint_0 < num2 + num)
			{
				return num3 + uint_0 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000BE00 File Offset: 0x0000A000
	public static void smethod_13(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class6.dictionary_0 == null)
			{
				object obj = Class6.object_3;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class6).Assembly.GetManifestResourceStream("NjFBuvh0iTt2N51XYJ.avEUwY0o0u4dgDm2xx"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							num3 += 0U;
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num9 & num5) >> num6);
								}
							}
							else
							{
								uint num10 = num3 ^ num7;
								array2[num4] = (byte)(num10 & 255U);
								array2[num4 + 1] = (byte)((num10 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num10 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num10 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num11 = array.Length / 8;
						Class6.Class9 @class = new Class6.Class9(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class6.dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = Class6.dictionary_0[metadataToken];
					bool flag2 = (num12 & 1073741824) > 0;
					num12 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(Class6).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num13 = parameters.Length + 1;
						Type[] array3 = new Type[num13];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num14 = 0; num14 < num13; num14++)
						{
							switch (num14)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num14);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002CCE File Offset: 0x00000ECE
	private static uint smethod_14(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002238 File Offset: 0x00000438
	internal static void smethod_16()
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000C288 File Offset: 0x0000A488
	private static void smethod_17(Stream object_0, int int_0)
	{
		Class6.Class9 @class = new Class6.Class9(object_0);
		@class.method_0().Position = 0L;
		byte[] array = @class.method_1((int)@class.method_0().Length);
		@class.method_4();
		byte[] array2 = new byte[32];
		array2[0] = 181;
		array2[0] = 189;
		array2[0] = 143;
		array2[0] = 149;
		array2[0] = 204;
		array2[1] = 136;
		array2[1] = 110;
		array2[1] = 122;
		array2[1] = 205;
		array2[1] = 174;
		array2[2] = 104;
		array2[2] = 140;
		array2[2] = 17;
		array2[3] = 123;
		array2[3] = 95;
		array2[3] = 155;
		array2[4] = 114;
		array2[4] = 84;
		array2[4] = 131;
		array2[5] = 118;
		array2[5] = 92;
		array2[5] = 166;
		array2[5] = 231;
		array2[6] = 136;
		array2[6] = 209;
		array2[6] = 122;
		array2[6] = 134;
		array2[7] = 90;
		array2[7] = 126;
		array2[7] = 84;
		array2[7] = 156;
		array2[7] = 14;
		array2[8] = 184;
		array2[8] = 153;
		array2[8] = 26;
		array2[8] = 139;
		array2[9] = 138;
		array2[9] = 118;
		array2[9] = 187;
		array2[10] = 86;
		array2[10] = 4;
		array2[10] = 87;
		array2[10] = 90;
		array2[10] = 135;
		array2[10] = 109;
		array2[11] = 125;
		array2[11] = 84;
		array2[11] = 119;
		array2[11] = 114;
		array2[11] = 150;
		array2[12] = 152;
		array2[12] = 113;
		array2[12] = 145;
		array2[12] = 116;
		array2[12] = 161;
		array2[12] = 122;
		array2[13] = 39;
		array2[13] = 154;
		array2[13] = 137;
		array2[14] = 111;
		array2[14] = 164;
		array2[14] = 43;
		array2[15] = 23;
		array2[15] = 90;
		array2[15] = 169;
		array2[15] = 124;
		array2[15] = 217;
		array2[16] = 123;
		array2[16] = 119;
		array2[16] = 71;
		array2[16] = 138;
		array2[16] = 222;
		array2[17] = 113;
		array2[17] = 165;
		array2[17] = 115;
		array2[17] = 180;
		array2[17] = 202;
		array2[18] = 126;
		array2[18] = 109;
		array2[18] = 35;
		array2[19] = 90;
		array2[19] = 84;
		array2[19] = 77;
		array2[19] = 136;
		array2[19] = 167;
		array2[19] = 43;
		array2[20] = 136;
		array2[20] = 147;
		array2[20] = 179;
		array2[21] = 125;
		array2[21] = 145;
		array2[21] = 96;
		array2[22] = 153;
		array2[22] = 117;
		array2[22] = 128;
		array2[22] = 114;
		array2[22] = 133;
		array2[22] = 181;
		array2[23] = 109;
		array2[23] = 79;
		array2[23] = 136;
		array2[23] = 235;
		array2[24] = 155;
		array2[24] = 32;
		array2[24] = 104;
		array2[24] = 155;
		array2[24] = 144;
		array2[24] = 63;
		array2[25] = 101;
		array2[25] = 103;
		array2[25] = 154;
		array2[25] = 57;
		array2[25] = 33;
		array2[26] = 165;
		array2[26] = 84;
		array2[26] = 42;
		array2[27] = 97;
		array2[27] = 64;
		array2[27] = 128;
		array2[27] = 113;
		array2[27] = 23;
		array2[28] = 118;
		array2[28] = 134;
		array2[28] = 125;
		array2[28] = 97;
		array2[28] = 8;
		array2[29] = 217;
		array2[29] = 83;
		array2[29] = 113;
		array2[30] = 110;
		array2[30] = 134;
		array2[30] = 41;
		array2[31] = 75;
		array2[31] = 94;
		array2[31] = 109;
		array2[31] = 15;
		byte[] array3 = array2;
		byte[] array4 = new byte[16];
		array4[0] = 124;
		array4[0] = 119;
		array4[0] = 80;
		array4[1] = 92;
		array4[1] = 213;
		array4[1] = 114;
		array4[1] = 180;
		array4[2] = 77;
		array4[2] = 78;
		array4[2] = 112;
		array4[2] = 145;
		array4[2] = 27;
		array4[3] = 34;
		array4[3] = 118;
		array4[3] = 84;
		array4[3] = 139;
		array4[3] = 173;
		array4[4] = 125;
		array4[4] = 154;
		array4[4] = 36;
		array4[5] = 71;
		array4[5] = 124;
		array4[5] = 114;
		array4[5] = 129;
		array4[5] = 226;
		array4[6] = 209;
		array4[6] = 133;
		array4[6] = 191;
		array4[7] = 104;
		array4[7] = 130;
		array4[7] = 131;
		array4[8] = 125;
		array4[8] = 183;
		array4[8] = 184;
		array4[9] = 152;
		array4[9] = 153;
		array4[9] = 100;
		array4[9] = 137;
		array4[10] = 138;
		array4[10] = 89;
		array4[10] = 109;
		array4[10] = 132;
		array4[10] = 4;
		array4[10] = 21;
		array4[11] = 90;
		array4[11] = 135;
		array4[11] = 191;
		array4[11] = 147;
		array4[11] = 140;
		array4[12] = 107;
		array4[12] = 224;
		array4[12] = 130;
		array4[12] = 106;
		array4[12] = 103;
		array4[12] = 171;
		array4[13] = 161;
		array4[13] = 77;
		array4[13] = 136;
		array4[13] = 170;
		array4[13] = 48;
		array4[14] = 103;
		array4[14] = 57;
		array4[14] = 122;
		array4[14] = 136;
		array4[14] = 194;
		array4[15] = 97;
		array4[15] = 114;
		array4[15] = 155;
		array4[15] = 168;
		array4[15] = 166;
		array4[15] = 204;
		byte[] array5 = array4;
		Array.Reverse(array5);
		byte[] publicKeyToken = Class6.assembly_0.GetName().GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken.Length != 0)
		{
			array5[1] = publicKeyToken[0];
			array5[3] = publicKeyToken[1];
			array5[5] = publicKeyToken[2];
			array5[7] = publicKeyToken[3];
			array5[9] = publicKeyToken[4];
			array5[11] = publicKeyToken[5];
			array5[13] = publicKeyToken[6];
			array5[15] = publicKeyToken[7];
		}
		for (int i = 0; i < array5.Length; i++)
		{
			array3[i] ^= array5[i];
		}
		if (int_0 == -1)
		{
			SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
			Stream stream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Class6.byte_0 = Class6.smethod_32(stream);
			stream.Close();
			cryptoStream.Close();
			array = Class6.byte_0;
		}
		if (Class6.assembly_0.EntryPoint == null)
		{
			Class6.int_2 = 80;
		}
		new Class6().method_1(array3, array5, array);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000CC48 File Offset: 0x0000AE48
	internal static string smethod_18(int int_0)
	{
		if (Class6.byte_0.Length == 0)
		{
			Class6.list_0 = new List<string>();
			Class6.list_1 = new List<int>();
			Class6.smethod_17(Class6.assembly_0.GetManifestResourceStream("eGuOHuRPeW8KuFAKLi.cOTGaqGr24bEwkhrDR"), int_0);
		}
		if (Class6.int_2 < 75)
		{
			if (Class6.assembly_0 != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			Class6.int_2++;
		}
		object obj = Class6.object_0;
		lock (obj)
		{
			int num = BitConverter.ToInt32(Class6.byte_0, int_0);
			if (num >= Class6.list_1.Count || Class6.list_1[num] != int_0)
			{
				try
				{
					byte[] array = new byte[num];
					Array.Copy(Class6.byte_0, int_0 + 4, array, 0, num);
					string @string = Encoding.Unicode.GetString(array, 0, array.Length);
					Class6.list_0.Add(@string);
					Class6.list_1.Add(int_0);
					Array.Copy(BitConverter.GetBytes(Class6.list_0.Count - 1), 0, Class6.byte_0, int_0, 4);
					return @string;
				}
				catch
				{
					goto IL_128;
				}
			}
			return Class6.list_0[num];
		}
		IL_128:
		return "";
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
	internal static string smethod_19(string object_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(object_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
	private static void smethod_21()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
	private static Delegate smethod_22(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_0,
			type_0
		});
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000CE58 File Offset: 0x0000B058
	internal static object smethod_23(Assembly object_0)
	{
		try
		{
			if (File.Exists(((Assembly)object_0).Location))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)object_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString()))
			{
				return object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x0600017C RID: 380
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	// Token: 0x0600017D RID: 381
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	// Token: 0x0600017E RID: 382 RVA: 0x0000CF68 File Offset: 0x0000B168
	private static IntPtr smethod_24(IntPtr intptr_0, string object_0, uint uint_0)
	{
		if (Class6.delegate4_0 == null)
		{
			Class6.delegate4_0 = (Class6.Delegate4)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Find ".Trim() + "ResourceA"), typeof(Class6.Delegate4));
		}
		return Class6.delegate4_0(intptr_0, object_0, uint_0);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
	private static IntPtr smethod_25(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (Class6.delegate5_0 == null)
		{
			Class6.delegate5_0 = (Class6.Delegate5)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Virtual ".Trim() + "Alloc"), typeof(Class6.Delegate5));
		}
		return Class6.delegate5_0(intptr_0, uint_0, uint_1, uint_2);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000D01C File Offset: 0x0000B21C
	private static int smethod_26(IntPtr intptr_0, IntPtr intptr_1, [In] [Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (Class6.delegate6_0 == null)
		{
			Class6.delegate6_0 = (Class6.Delegate6)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class6.Delegate6));
		}
		return Class6.delegate6_0(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000D084 File Offset: 0x0000B284
	private static int smethod_27(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (Class6.delegate7_0 == null)
		{
			Class6.delegate7_0 = (Class6.Delegate7)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Virtual ".Trim() + "Protect"), typeof(Class6.Delegate7));
		}
		return Class6.delegate7_0(intptr_0, int_0, int_1, ref int_2);
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
	private static IntPtr smethod_28(uint uint_0, int int_0, uint uint_1)
	{
		if (Class6.delegate8_0 == null)
		{
			Class6.delegate8_0 = (Class6.Delegate8)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Open ".Trim() + "Process"), typeof(Class6.Delegate8));
		}
		return Class6.delegate8_0(uint_0, int_0, uint_1);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000D138 File Offset: 0x0000B338
	private static int smethod_29(IntPtr intptr_0)
	{
		if (Class6.delegate9_0 == null)
		{
			Class6.delegate9_0 = (Class6.Delegate9)Marshal.GetDelegateForFunctionPointer(Class6.GetProcAddress(Class6.smethod_30(), "Close ".Trim() + "Handle"), typeof(Class6.Delegate9));
		}
		return Class6.delegate9_0(intptr_0);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002CDA File Offset: 0x00000EDA
	private static IntPtr smethod_30()
	{
		if (Class6.intptr_2 == IntPtr.Zero)
		{
			Class6.intptr_2 = Class6.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class6.intptr_2;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000D190 File Offset: 0x0000B390
	private static byte[] smethod_31(string object_0)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(object_0, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002D10 File Offset: 0x00000F10
	internal static byte[] smethod_32(MemoryStream object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
	private static byte[] smethod_33(byte[] object_0)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			86,
			108,
			97,
			162,
			83,
			114,
			49,
			52,
			210,
			135,
			206,
			168,
			221,
			237,
			179,
			181,
			109,
			188,
			45,
			64,
			90,
			76,
			83,
			84,
			9,
			107,
			130,
			67,
			65,
			2,
			31,
			112
		};
		symmetricAlgorithm.IV = new byte[]
		{
			199,
			187,
			160,
			111,
			231,
			15,
			237,
			196,
			159,
			38,
			68,
			58,
			183,
			188,
			200,
			25
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(object_0, 0, object_0.Length);
		cryptoStream.Close();
		return Class6.smethod_32(stream);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002D1D File Offset: 0x00000F1D
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002D1D File Offset: 0x00000F1D
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002D20 File Offset: 0x00000F20
	private byte[] method_4()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002D3B File Offset: 0x00000F3B
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002D56 File Offset: 0x00000F56
	private byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002D71 File Offset: 0x00000F71
	private byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002D8C File Offset: 0x00000F8C
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002DA7 File Offset: 0x00000FA7
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002DC2 File Offset: 0x00000FC2
	internal byte[] method_10()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002DDD File Offset: 0x00000FDD
	internal byte[] method_11()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002DF8 File Offset: 0x00000FF8
	internal static bool smethod_34()
	{
		return null == null;
	}

	// Token: 0x04000119 RID: 281
	internal static Assembly assembly_0;

	// Token: 0x0400011A RID: 282
	private static bool bool_0;

	// Token: 0x0400011B RID: 283
	private static bool bool_1;

	// Token: 0x0400011C RID: 284
	private static object object_0;

	// Token: 0x0400011D RID: 285
	private static List<string> list_0;

	// Token: 0x0400011E RID: 286
	private static long long_0;

	// Token: 0x0400011F RID: 287
	internal static object object_1;

	// Token: 0x04000120 RID: 288
	private static long long_1;

	// Token: 0x04000121 RID: 289
	private static int int_0;

	// Token: 0x04000122 RID: 290
	private static IntPtr intptr_0;

	// Token: 0x04000123 RID: 291
	private static Class6.Delegate4 delegate4_0;

	// Token: 0x04000124 RID: 292
	private static Class6.Delegate7 delegate7_0;

	// Token: 0x04000125 RID: 293
	private static SortedList sortedList_0;

	// Token: 0x04000126 RID: 294
	internal static object object_2;

	// Token: 0x04000127 RID: 295
	private static int[] int_1;

	// Token: 0x04000128 RID: 296
	private static bool bool_2;

	// Token: 0x04000129 RID: 297
	private static List<int> list_1;

	// Token: 0x0400012A RID: 298
	private static int int_2;

	// Token: 0x0400012B RID: 299
	private static Class6.Delegate8 delegate8_0;

	// Token: 0x0400012C RID: 300
	[Class6.Attribute0(typeof(Class6.Attribute0.Class7<object>[]))]
	private static bool bool_3;

	// Token: 0x0400012D RID: 301
	private static Class6.Delegate6 delegate6_0;

	// Token: 0x0400012E RID: 302
	private static IntPtr intptr_1;

	// Token: 0x0400012F RID: 303
	private static int int_3;

	// Token: 0x04000130 RID: 304
	private static bool bool_4;

	// Token: 0x04000131 RID: 305
	private static object object_3;

	// Token: 0x04000132 RID: 306
	private static string[] string_0;

	// Token: 0x04000133 RID: 307
	internal static Hashtable hashtable_0;

	// Token: 0x04000134 RID: 308
	internal static object object_4;

	// Token: 0x04000135 RID: 309
	private static Class6.Delegate5 delegate5_0;

	// Token: 0x04000136 RID: 310
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x04000137 RID: 311
	private static bool bool_5;

	// Token: 0x04000138 RID: 312
	private static int int_4;

	// Token: 0x04000139 RID: 313
	private static uint[] uint_0;

	// Token: 0x0400013A RID: 314
	private static int int_5;

	// Token: 0x0400013B RID: 315
	private static Class6.Delegate9 delegate9_0;

	// Token: 0x0400013C RID: 316
	private static bool bool_6 = false;

	// Token: 0x0400013D RID: 317
	private static byte[] byte_0;

	// Token: 0x0400013E RID: 318
	private static IntPtr intptr_2;

	// Token: 0x0400013F RID: 319
	private static IntPtr intptr_3;

	// Token: 0x04000140 RID: 320
	private static byte[] byte_1;

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x06000194 RID: 404
	private delegate void Delegate1(object o);

	// Token: 0x0200004A RID: 74
	internal class Attribute0 : Attribute
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002DFE File Offset: 0x00000FFE
		public Attribute0(object object_0)
		{
		}

		// Token: 0x0200004B RID: 75
		internal class Class7<T>
		{
			// Token: 0x06000199 RID: 409 RVA: 0x00002E06 File Offset: 0x00001006
			internal static bool smethod_0()
			{
				return Class6.Attribute0.Class7<T>.object_0 == null;
			}

			// Token: 0x04000141 RID: 321
			internal static object object_0;
		}
	}

	// Token: 0x0200004C RID: 76
	internal class Class8
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0000D25C File Offset: 0x0000B45C
		internal static string smethod_0(string object_0, string object_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(object_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class6.smethod_9(Encoding.Unicode.GetBytes(object_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class6.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x0200004D RID: 77
	// (Invoke) Token: 0x0600019D RID: 413
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x0200004E RID: 78
	// (Invoke) Token: 0x060001A1 RID: 417
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x0200004F RID: 79
	internal struct Struct8
	{
		// Token: 0x04000142 RID: 322
		internal bool bool_0;

		// Token: 0x04000143 RID: 323
		internal byte[] byte_0;
	}

	// Token: 0x02000050 RID: 80
	internal class Class9
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002E10 File Offset: 0x00001010
		public Class9(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002E24 File Offset: 0x00001024
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002E31 File Offset: 0x00001031
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002E3F File Offset: 0x0000103F
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002E4F File Offset: 0x0000104F
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002E5C File Offset: 0x0000105C
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x04000144 RID: 324
		private BinaryReader binaryReader_0;
	}

	// Token: 0x02000051 RID: 81
	// (Invoke) Token: 0x060001AB RID: 427
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = 2)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x02000052 RID: 82
	// (Invoke) Token: 0x060001AF RID: 431
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x02000053 RID: 83
	// (Invoke) Token: 0x060001B3 RID: 435
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x02000054 RID: 84
	// (Invoke) Token: 0x060001B7 RID: 439
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000055 RID: 85
	// (Invoke) Token: 0x060001BB RID: 443
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000056 RID: 86
	// (Invoke) Token: 0x060001BF RID: 447
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x02000057 RID: 87
	[Flags]
	private enum Enum0
	{

	}
}
