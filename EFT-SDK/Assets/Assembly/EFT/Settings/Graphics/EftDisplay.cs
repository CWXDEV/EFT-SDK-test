using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT.Settings.Graphics
{
	// Token: 0x0200199A RID: 6554
	[Serializable]
	public static class EftDisplay
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00002050 File Offset: 0x00000250
		public static byte DefaultIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte CurrentIndex()
		{
			throw null;
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EftDisplay.GStruct234 Current()
		{
			throw null;
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<EftDisplay.GStruct234> Infos()
		{
			throw null;
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Equal(List<EftDisplay.GStruct234> first, List<EftDisplay.GStruct234> second)
		{
			throw null;
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2Int GetWindowMaxResolution()
		{
			throw null;
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2Int GetWindowPosition()
		{
			throw null;
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsValid(byte index)
		{
			throw null;
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveWindow(byte index, int? width = null, int? height = null)
		{
			throw null;
		}

		// Token: 0x0200199B RID: 6555
		private static class Class1531
		{
			// Token: 0x06008C54 RID: 35924 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static EftDisplay.Class1531.Struct443 smethod_0()
			{
				throw null;
			}

			// Token: 0x06008C55 RID: 35925 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Vector2Int smethod_1()
			{
				throw null;
			}

			// Token: 0x06008C56 RID: 35926 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static EftDisplay.GStruct234 smethod_2()
			{
				throw null;
			}

			// Token: 0x06008C57 RID: 35927 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static EftDisplay.GStruct234 smethod_3(in EftDisplay.Class1531.Struct443 point)
			{
				throw null;
			}

			// Token: 0x06008C58 RID: 35928 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static List<EftDisplay.GStruct234> smethod_4()
			{
				throw null;
			}

			// Token: 0x06008C59 RID: 35929 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void smethod_5(in RectInt rect)
			{
				throw null;
			}

			// Token: 0x06008C5A RID: 35930 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static RectInt smethod_6(in EftDisplay.Class1531.Struct442 rect)
			{
				throw null;
			}

			// Token: 0x06008C5B RID: 35931 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static EftDisplay.GStruct234 smethod_7(EftDisplay.Class1531.Class1532 info, byte index, string[] friendlyNames)
			{
				throw null;
			}

			// Token: 0x06008C5C RID: 35932
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
			private static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

			// Token: 0x06008C5D RID: 35933
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
			private static extern bool ClientToScreen(IntPtr hWnd, ref EftDisplay.Class1531.Struct443 point);

			// Token: 0x06008C5E RID: 35934
			[DllImport("user32.dll")]
			private static extern IntPtr GetActiveWindow();

			// Token: 0x06008C5F RID: 35935
			[DllImport("user32.dll")]
			private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, EftDisplay.Class1531.Delegate12 lpfnEnum, IntPtr dwData);

			// Token: 0x06008C60 RID: 35936
			[DllImport("user32.dll", CharSet = CharSet.Unicode)]
			private static extern bool GetMonitorInfo(IntPtr hMonitor, [In] [Out] EftDisplay.Class1531.Class1532 info);

			// Token: 0x06008C61 RID: 35937
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
			private static extern bool GetWindowRect(IntPtr hWnd, ref EftDisplay.Class1531.Struct442 rect);

			// Token: 0x06008C62 RID: 35938
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
			private static extern bool GetClientRect(IntPtr hWnd, ref EftDisplay.Class1531.Struct442 rect);

			// Token: 0x06008C63 RID: 35939
			[DllImport("user32.dll", ExactSpelling = true)]
			private static extern IntPtr MonitorFromPoint(EftDisplay.Class1531.Struct443 point, int flags);

			// Token: 0x040091E6 RID: 37350
			private const int int_0 = 2;

			// Token: 0x0200199C RID: 6556
			[StructLayout(LayoutKind.Auto)]
			public struct Struct442
			{
				// Token: 0x040091E7 RID: 37351
				public int left;

				// Token: 0x040091E8 RID: 37352
				public int top;

				// Token: 0x040091E9 RID: 37353
				public int right;

				// Token: 0x040091EA RID: 37354
				public int bottom;
			}

			// Token: 0x0200199D RID: 6557
			[StructLayout(LayoutKind.Auto)]
			public struct Struct443
			{
				// Token: 0x040091EB RID: 37355
				public int x;

				// Token: 0x040091EC RID: 37356
				public int y;
			}

			// Token: 0x0200199E RID: 6558
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
			private sealed class Class1532
			{
				// Token: 0x040091ED RID: 37357
				public int cbSize;

				// Token: 0x040091EE RID: 37358
				public EftDisplay.Class1531.Struct442 rcMonitor;

				// Token: 0x040091EF RID: 37359
				public EftDisplay.Class1531.Struct442 rcWork;

				// Token: 0x040091F0 RID: 37360
				public int dwFlags;

				// Token: 0x040091F1 RID: 37361
				[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
				public string szDevice;
			}

			// Token: 0x0200199F RID: 6559
			// (Invoke) Token: 0x06008C64 RID: 35940
			private delegate bool Delegate12(IntPtr hMonitor, IntPtr hdcMonitor, ref EftDisplay.Class1531.Struct442 lprcMonitor, IntPtr dwData);

			// Token: 0x020019A0 RID: 6560
			[CompilerGenerated]
			private sealed class Class1533
			{
				// Token: 0x06008C67 RID: 35943 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(IntPtr hMonitor, IntPtr hdcMonitor, ref EftDisplay.Class1531.Struct442 lprcMonitor, IntPtr dwData)
				{
					throw null;
				}

				// Token: 0x040091F2 RID: 37362
				public IntPtr monitor;

				// Token: 0x040091F3 RID: 37363
				public EftDisplay.GStruct234 result;

				// Token: 0x040091F4 RID: 37364
				public byte index;

				// Token: 0x040091F5 RID: 37365
				public string[] names;
			}

			// Token: 0x020019A1 RID: 6561
			[CompilerGenerated]
			private sealed class Class1534
			{
				// Token: 0x06008C68 RID: 35944 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(IntPtr hMonitor, IntPtr hdcMonitor, ref EftDisplay.Class1531.Struct442 lprcMonitor, IntPtr dwData)
				{
					throw null;
				}

				// Token: 0x040091F6 RID: 37366
				public List<EftDisplay.GStruct234> result;

				// Token: 0x040091F7 RID: 37367
				public string[] names;
			}
		}

		// Token: 0x020019A2 RID: 6562
		[StructLayout(LayoutKind.Auto)]
		public readonly struct GStruct234 : IEquatable<EftDisplay.GStruct234>
		{
			// Token: 0x1700155C RID: 5468
			// (get) Token: 0x06008C69 RID: 35945 RVA: 0x00002050 File Offset: 0x00000250
			public static EftDisplay.GStruct234 Default
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700155D RID: 5469
			// (get) Token: 0x06008C6A RID: 35946 RVA: 0x00002050 File Offset: 0x00000250
			public byte Index
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700155E RID: 5470
			// (get) Token: 0x06008C6B RID: 35947 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsPrimary
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700155F RID: 5471
			// (get) Token: 0x06008C6C RID: 35948 RVA: 0x00002050 File Offset: 0x00000250
			public string Name
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001560 RID: 5472
			// (get) Token: 0x06008C6D RID: 35949 RVA: 0x00002050 File Offset: 0x00000250
			public string FriendlyName
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001561 RID: 5473
			// (get) Token: 0x06008C6E RID: 35950 RVA: 0x00002050 File Offset: 0x00000250
			public RectInt MonitorRect
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001562 RID: 5474
			// (get) Token: 0x06008C6F RID: 35951 RVA: 0x00002050 File Offset: 0x00000250
			public RectInt WorkRect
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008C70 RID: 35952 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Contain(int x, int y)
			{
				throw null;
			}

			// Token: 0x06008C71 RID: 35953 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Distance(int x, int y)
			{
				throw null;
			}

			// Token: 0x06008C72 RID: 35954 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Equals(EftDisplay.GStruct234 other)
			{
				throw null;
			}

			// Token: 0x06008C73 RID: 35955 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x040091F8 RID: 37368
			[CompilerGenerated]
			private readonly byte byte_0;

			// Token: 0x040091F9 RID: 37369
			[CompilerGenerated]
			private readonly bool bool_0;

			// Token: 0x040091FA RID: 37370
			[CompilerGenerated]
			private readonly string string_0;

			// Token: 0x040091FB RID: 37371
			[CompilerGenerated]
			private readonly string string_1;

			// Token: 0x040091FC RID: 37372
			[CompilerGenerated]
			private readonly RectInt rectInt_0;

			// Token: 0x040091FD RID: 37373
			[CompilerGenerated]
			private readonly RectInt rectInt_1;
		}

		// Token: 0x020019A3 RID: 6563
		private static class Class1535
		{
			// Token: 0x06008C74 RID: 35956
			[DllImport("user32.dll")]
			public static extern int GetDisplayConfigBufferSizes(EftDisplay.Class1535.QUERY_DEVICE_CONFIG_FLAGS flags, out uint numPathArrayElements, out uint numModeInfoArrayElements);

			// Token: 0x06008C75 RID: 35957
			[DllImport("user32.dll")]
			public static extern int QueryDisplayConfig(EftDisplay.Class1535.QUERY_DEVICE_CONFIG_FLAGS flags, ref uint numPathArrayElements, [Out] EftDisplay.Class1535.Struct448[] PathInfoArray, ref uint numModeInfoArrayElements, [Out] EftDisplay.Class1535.Struct455[] ModeInfoArray, IntPtr currentTopologyId);

			// Token: 0x06008C76 RID: 35958
			[DllImport("user32.dll")]
			public static extern int DisplayConfigGetDeviceInfo(ref EftDisplay.Class1535.Struct458 deviceName);

			// Token: 0x06008C77 RID: 35959 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static string smethod_0(EftDisplay.Class1535.Struct444 adapterId, uint targetId)
			{
				throw null;
			}

			// Token: 0x06008C78 RID: 35960 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static IEnumerable<string> GetAllMonitorsFriendlyNames()
			{
				throw null;
			}

			// Token: 0x040091FE RID: 37374
			public const int ERROR_SUCCESS = 0;

			// Token: 0x020019A4 RID: 6564
			public enum QUERY_DEVICE_CONFIG_FLAGS : uint
			{
				// Token: 0x04009200 RID: 37376
				QDC_ALL_PATHS = 1U,
				// Token: 0x04009201 RID: 37377
				QDC_ONLY_ACTIVE_PATHS,
				// Token: 0x04009202 RID: 37378
				QDC_DATABASE_CURRENT = 4U
			}

			// Token: 0x020019A5 RID: 6565
			public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY : uint
			{
				// Token: 0x04009204 RID: 37380
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = 4294967295U,
				// Token: 0x04009205 RID: 37381
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0U,
				// Token: 0x04009206 RID: 37382
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO,
				// Token: 0x04009207 RID: 37383
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO,
				// Token: 0x04009208 RID: 37384
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO,
				// Token: 0x04009209 RID: 37385
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI,
				// Token: 0x0400920A RID: 37386
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI,
				// Token: 0x0400920B RID: 37387
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS,
				// Token: 0x0400920C RID: 37388
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8U,
				// Token: 0x0400920D RID: 37389
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI,
				// Token: 0x0400920E RID: 37390
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL,
				// Token: 0x0400920F RID: 37391
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED,
				// Token: 0x04009210 RID: 37392
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL,
				// Token: 0x04009211 RID: 37393
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED,
				// Token: 0x04009212 RID: 37394
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE,
				// Token: 0x04009213 RID: 37395
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST,
				// Token: 0x04009214 RID: 37396
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = 2147483648U,
				// Token: 0x04009215 RID: 37397
				DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019A6 RID: 6566
			public enum DISPLAYCONFIG_SCANLINE_ORDERING : uint
			{
				// Token: 0x04009217 RID: 37399
				DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED,
				// Token: 0x04009218 RID: 37400
				DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE,
				// Token: 0x04009219 RID: 37401
				DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED,
				// Token: 0x0400921A RID: 37402
				DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = 2U,
				// Token: 0x0400921B RID: 37403
				DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST,
				// Token: 0x0400921C RID: 37404
				DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019A7 RID: 6567
			public enum DISPLAYCONFIG_ROTATION : uint
			{
				// Token: 0x0400921E RID: 37406
				DISPLAYCONFIG_ROTATION_IDENTITY = 1U,
				// Token: 0x0400921F RID: 37407
				DISPLAYCONFIG_ROTATION_ROTATE90,
				// Token: 0x04009220 RID: 37408
				DISPLAYCONFIG_ROTATION_ROTATE180,
				// Token: 0x04009221 RID: 37409
				DISPLAYCONFIG_ROTATION_ROTATE270,
				// Token: 0x04009222 RID: 37410
				DISPLAYCONFIG_ROTATION_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019A8 RID: 6568
			public enum DISPLAYCONFIG_SCALING : uint
			{
				// Token: 0x04009224 RID: 37412
				DISPLAYCONFIG_SCALING_IDENTITY = 1U,
				// Token: 0x04009225 RID: 37413
				DISPLAYCONFIG_SCALING_CENTERED,
				// Token: 0x04009226 RID: 37414
				DISPLAYCONFIG_SCALING_STRETCHED,
				// Token: 0x04009227 RID: 37415
				DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX,
				// Token: 0x04009228 RID: 37416
				DISPLAYCONFIG_SCALING_CUSTOM,
				// Token: 0x04009229 RID: 37417
				DISPLAYCONFIG_SCALING_PREFERRED = 128U,
				// Token: 0x0400922A RID: 37418
				DISPLAYCONFIG_SCALING_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019A9 RID: 6569
			public enum DISPLAYCONFIG_PIXELFORMAT : uint
			{
				// Token: 0x0400922C RID: 37420
				DISPLAYCONFIG_PIXELFORMAT_8BPP = 1U,
				// Token: 0x0400922D RID: 37421
				DISPLAYCONFIG_PIXELFORMAT_16BPP,
				// Token: 0x0400922E RID: 37422
				DISPLAYCONFIG_PIXELFORMAT_24BPP,
				// Token: 0x0400922F RID: 37423
				DISPLAYCONFIG_PIXELFORMAT_32BPP,
				// Token: 0x04009230 RID: 37424
				DISPLAYCONFIG_PIXELFORMAT_NONGDI,
				// Token: 0x04009231 RID: 37425
				DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019AA RID: 6570
			public enum DISPLAYCONFIG_MODE_INFO_TYPE : uint
			{
				// Token: 0x04009233 RID: 37427
				DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1U,
				// Token: 0x04009234 RID: 37428
				DISPLAYCONFIG_MODE_INFO_TYPE_TARGET,
				// Token: 0x04009235 RID: 37429
				DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019AB RID: 6571
			public enum DISPLAYCONFIG_DEVICE_INFO_TYPE : uint
			{
				// Token: 0x04009237 RID: 37431
				DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME = 1U,
				// Token: 0x04009238 RID: 37432
				DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME,
				// Token: 0x04009239 RID: 37433
				DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_PREFERRED_MODE,
				// Token: 0x0400923A RID: 37434
				DISPLAYCONFIG_DEVICE_INFO_GET_ADAPTER_NAME,
				// Token: 0x0400923B RID: 37435
				DISPLAYCONFIG_DEVICE_INFO_SET_TARGET_PERSISTENCE,
				// Token: 0x0400923C RID: 37436
				DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_BASE_TYPE,
				// Token: 0x0400923D RID: 37437
				DISPLAYCONFIG_DEVICE_INFO_FORCE_UINT32 = 4294967295U
			}

			// Token: 0x020019AC RID: 6572
			[StructLayout(LayoutKind.Auto)]
			public struct Struct444
			{
				// Token: 0x0400923E RID: 37438
				public uint LowPart;

				// Token: 0x0400923F RID: 37439
				public int HighPart;
			}

			// Token: 0x020019AD RID: 6573
			[StructLayout(LayoutKind.Auto)]
			public struct Struct445
			{
				// Token: 0x04009240 RID: 37440
				public EftDisplay.Class1535.Struct444 adapterId;

				// Token: 0x04009241 RID: 37441
				public uint id;

				// Token: 0x04009242 RID: 37442
				public uint modeInfoIdx;

				// Token: 0x04009243 RID: 37443
				public uint statusFlags;
			}

			// Token: 0x020019AE RID: 6574
			[StructLayout(LayoutKind.Auto)]
			public struct Struct446
			{
				// Token: 0x04009244 RID: 37444
				public EftDisplay.Class1535.Struct444 adapterId;

				// Token: 0x04009245 RID: 37445
				public uint id;

				// Token: 0x04009246 RID: 37446
				public uint modeInfoIdx;

				// Token: 0x04009247 RID: 37447
				private EftDisplay.Class1535.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY displayconfig_VIDEO_OUTPUT_TECHNOLOGY_0;

				// Token: 0x04009248 RID: 37448
				private EftDisplay.Class1535.DISPLAYCONFIG_ROTATION displayconfig_ROTATION_0;

				// Token: 0x04009249 RID: 37449
				private EftDisplay.Class1535.DISPLAYCONFIG_SCALING displayconfig_SCALING_0;

				// Token: 0x0400924A RID: 37450
				private EftDisplay.Class1535.Struct447 struct447_0;

				// Token: 0x0400924B RID: 37451
				private EftDisplay.Class1535.DISPLAYCONFIG_SCANLINE_ORDERING displayconfig_SCANLINE_ORDERING_0;

				// Token: 0x0400924C RID: 37452
				public bool targetAvailable;

				// Token: 0x0400924D RID: 37453
				public uint statusFlags;
			}

			// Token: 0x020019AF RID: 6575
			[StructLayout(LayoutKind.Auto)]
			public struct Struct447
			{
				// Token: 0x0400924E RID: 37454
				public uint Numerator;

				// Token: 0x0400924F RID: 37455
				public uint Denominator;
			}

			// Token: 0x020019B0 RID: 6576
			[StructLayout(LayoutKind.Auto)]
			public struct Struct448
			{
				// Token: 0x04009250 RID: 37456
				public EftDisplay.Class1535.Struct445 sourceInfo;

				// Token: 0x04009251 RID: 37457
				public EftDisplay.Class1535.Struct446 targetInfo;

				// Token: 0x04009252 RID: 37458
				public uint flags;
			}

			// Token: 0x020019B1 RID: 6577
			[StructLayout(LayoutKind.Auto)]
			public struct Struct449
			{
				// Token: 0x04009253 RID: 37459
				public uint cx;

				// Token: 0x04009254 RID: 37460
				public uint cy;
			}

			// Token: 0x020019B2 RID: 6578
			[StructLayout(LayoutKind.Auto)]
			public struct Struct450
			{
				// Token: 0x04009255 RID: 37461
				public ulong pixelRate;

				// Token: 0x04009256 RID: 37462
				public EftDisplay.Class1535.Struct447 hSyncFreq;

				// Token: 0x04009257 RID: 37463
				public EftDisplay.Class1535.Struct447 vSyncFreq;

				// Token: 0x04009258 RID: 37464
				public EftDisplay.Class1535.Struct449 activeSize;

				// Token: 0x04009259 RID: 37465
				public EftDisplay.Class1535.Struct449 totalSize;

				// Token: 0x0400925A RID: 37466
				public uint videoStandard;

				// Token: 0x0400925B RID: 37467
				public EftDisplay.Class1535.DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
			}

			// Token: 0x020019B3 RID: 6579
			[StructLayout(LayoutKind.Auto)]
			public struct Struct451
			{
				// Token: 0x0400925C RID: 37468
				public EftDisplay.Class1535.Struct450 targetVideoSignalInfo;
			}

			// Token: 0x020019B4 RID: 6580
			[StructLayout(LayoutKind.Auto)]
			public struct Struct452
			{
				// Token: 0x0400925D RID: 37469
				private int int_0;

				// Token: 0x0400925E RID: 37470
				private int int_1;
			}

			// Token: 0x020019B5 RID: 6581
			[StructLayout(LayoutKind.Auto)]
			public struct Struct453
			{
				// Token: 0x0400925F RID: 37471
				public uint width;

				// Token: 0x04009260 RID: 37472
				public uint height;

				// Token: 0x04009261 RID: 37473
				public EftDisplay.Class1535.DISPLAYCONFIG_PIXELFORMAT pixelFormat;

				// Token: 0x04009262 RID: 37474
				public EftDisplay.Class1535.Struct452 position;
			}

			// Token: 0x020019B6 RID: 6582
			[StructLayout(LayoutKind.Auto)]
			public struct Struct454
			{
				// Token: 0x04009263 RID: 37475
				public EftDisplay.Class1535.Struct451 targetMode;

				// Token: 0x04009264 RID: 37476
				public EftDisplay.Class1535.Struct453 sourceMode;
			}

			// Token: 0x020019B7 RID: 6583
			[StructLayout(LayoutKind.Auto)]
			public struct Struct455
			{
				// Token: 0x04009265 RID: 37477
				public EftDisplay.Class1535.DISPLAYCONFIG_MODE_INFO_TYPE infoType;

				// Token: 0x04009266 RID: 37478
				public uint id;

				// Token: 0x04009267 RID: 37479
				public EftDisplay.Class1535.Struct444 adapterId;

				// Token: 0x04009268 RID: 37480
				public EftDisplay.Class1535.Struct454 modeInfo;
			}

			// Token: 0x020019B8 RID: 6584
			[StructLayout(LayoutKind.Auto)]
			public struct Struct456
			{
				// Token: 0x04009269 RID: 37481
				public uint value;
			}

			// Token: 0x020019B9 RID: 6585
			[StructLayout(LayoutKind.Auto)]
			public struct Struct457
			{
				// Token: 0x0400926A RID: 37482
				public EftDisplay.Class1535.DISPLAYCONFIG_DEVICE_INFO_TYPE type;

				// Token: 0x0400926B RID: 37483
				public uint size;

				// Token: 0x0400926C RID: 37484
				public EftDisplay.Class1535.Struct444 adapterId;

				// Token: 0x0400926D RID: 37485
				public uint id;
			}

			// Token: 0x020019BA RID: 6586
			[StructLayout(LayoutKind.Auto)]
			public struct Struct458
			{
				// Token: 0x0400926E RID: 37486
				public EftDisplay.Class1535.Struct457 header;

				// Token: 0x0400926F RID: 37487
				public EftDisplay.Class1535.Struct456 flags;

				// Token: 0x04009270 RID: 37488
				public EftDisplay.Class1535.DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

				// Token: 0x04009271 RID: 37489
				public ushort edidManufactureId;

				// Token: 0x04009272 RID: 37490
				public ushort edidProductCodeId;

				// Token: 0x04009273 RID: 37491
				public uint connectorInstance;

				// Token: 0x04009274 RID: 37492
				[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
				public string monitorFriendlyDeviceName;

				// Token: 0x04009275 RID: 37493
				[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
				public string monitorDevicePath;
			}
		}

		// Token: 0x020019BC RID: 6588
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1537
		{
			// Token: 0x06008C7E RID: 35966 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EftDisplay.GStruct234 i)
			{
				throw null;
			}

			// Token: 0x0400927C RID: 37500
			public static readonly EftDisplay.Class1537 class1537_0;

			// Token: 0x0400927D RID: 37501
			public static Func<EftDisplay.GStruct234, bool> func_0;
		}
	}
}
