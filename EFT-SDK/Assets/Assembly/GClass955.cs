using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using EFT.Settings.Graphics;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x020019DA RID: 6618
public sealed class GClass955 : GClass952<GClass955>
{
	// Token: 0x1700156B RID: 5483
	// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x00002050 File Offset: 0x00000250
	public bool DLSSEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700156C RID: 5484
	// (get) Token: 0x06008CDA RID: 36058 RVA: 0x00002050 File Offset: 0x00000250
	public bool FSREnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700156D RID: 5485
	// (get) Token: 0x06008CDB RID: 36059 RVA: 0x00002050 File Offset: 0x00000250
	public bool FSR2Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700156E RID: 5486
	// (get) Token: 0x06008CDC RID: 36060 RVA: 0x00002050 File Offset: 0x00000250
	public float ShadowDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001570 RID: 5488
	// (set) Token: 0x06008CDD RID: 36061 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty]
	public string SystemMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17001571 RID: 5489
	// (get) Token: 0x06008CDE RID: 36062 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008CDF RID: 36063 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string SystemMessageLocale
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06008CE1 RID: 36065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct235 GetDisplaySettingsPreset(byte displayIndex)
	{
		throw null;
	}

	// Token: 0x06008CE2 RID: 36066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TextureQualityToMipBias(int quality)
	{
		throw null;
	}

	// Token: 0x06008CE3 RID: 36067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetMipStreamingBias()
	{
		throw null;
	}

	// Token: 0x06008CE4 RID: 36068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct235 GetDisplaySettingsPreset(FullScreenMode mode)
	{
		throw null;
	}

	// Token: 0x06008CE5 RID: 36069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreDisplaySettings(GStruct235 settings)
	{
		throw null;
	}

	// Token: 0x06008CE6 RID: 36070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(byte displayIndex, FullScreenMode fullScreenMode, EftResolution resolution, AspectRatio aspectRatio)
	{
		throw null;
	}

	// Token: 0x06008CE7 RID: 36071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<GStruct235> method_9(GStruct235 settings)
	{
		throw null;
	}

	// Token: 0x06008CE8 RID: 36072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDLSSModeAllowed(EDLSSMode mode)
	{
		throw null;
	}

	// Token: 0x06008CE9 RID: 36073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private EDLSSMode method_10(EDLSSMode mode)
	{
		throw null;
	}

	// Token: 0x06008CEA RID: 36074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static EDLSSMode smethod_0(EDLSSMode mode, EftResolution resolution)
	{
		throw null;
	}

	// Token: 0x06008CEB RID: 36075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFSRModeAllowed(EFSRMode mode)
	{
		throw null;
	}

	// Token: 0x06008CEC RID: 36076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private EFSRMode method_11(EFSRMode mode)
	{
		throw null;
	}

	// Token: 0x06008CED RID: 36077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static EFSRMode smethod_1(EFSRMode mode, EftResolution resolution)
	{
		throw null;
	}

	// Token: 0x06008CEE RID: 36078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFSR2ModeAllowed(EFSR2Mode mode)
	{
		throw null;
	}

	// Token: 0x06008CEF RID: 36079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private EFSR2Mode method_12(EFSR2Mode mode)
	{
		throw null;
	}

	// Token: 0x06008CF0 RID: 36080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static EFSR2Mode smethod_2(EFSR2Mode mode, EftResolution resolution)
	{
		throw null;
	}

	// Token: 0x06008CF1 RID: 36081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float smethod_3(int shadowQuality)
	{
		throw null;
	}

	// Token: 0x06008CF2 RID: 36082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetSuperSamplingFromQuality(ESamplingMode quality)
	{
		throw null;
	}

	// Token: 0x06008CF3 RID: 36083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Is1XSampling(ESamplingMode samplingQuality)
	{
		throw null;
	}

	// Token: 0x06008CF4 RID: 36084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDLSSQuality(EDLSSMode mode)
	{
		throw null;
	}

	// Token: 0x06008CF5 RID: 36085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTaaEnabled()
	{
		throw null;
	}

	// Token: 0x06008CF6 RID: 36086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTaaHigh()
	{
		throw null;
	}

	// Token: 0x06008CF7 RID: 36087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDLSSEnabled()
	{
		throw null;
	}

	// Token: 0x06008CF8 RID: 36088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFSR2Enabled()
	{
		throw null;
	}

	// Token: 0x06008CF9 RID: 36089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass955 Clone()
	{
		throw null;
	}

	// Token: 0x04009314 RID: 37652
	private const long long_0 = 3686400L;

	// Token: 0x04009315 RID: 37653
	private const long long_1 = 8294400L;

	// Token: 0x04009316 RID: 37654
	private const long long_2 = 8294400L;

	// Token: 0x04009317 RID: 37655
	private const long long_3 = 2073600L;

	// Token: 0x04009318 RID: 37656
	public readonly List<GClass1879> Stored;

	// Token: 0x04009319 RID: 37657
	public readonly GameSetting<GStruct235> DisplaySettings;

	// Token: 0x0400931A RID: 37658
	public readonly GameSetting<int?> GraphicsQuality;

	// Token: 0x0400931B RID: 37659
	public readonly GameSetting<int> ShadowsQuality;

	// Token: 0x0400931C RID: 37660
	public readonly GameSetting<int> TextureQuality;

	// Token: 0x0400931D RID: 37661
	public readonly GameSetting<bool> SDMode;

	// Token: 0x0400931E RID: 37662
	public readonly GameSetting<bool> VSync;

	// Token: 0x0400931F RID: 37663
	public readonly GameSetting<int> LobbyFramerate;

	// Token: 0x04009320 RID: 37664
	public readonly GameSetting<int> GameFramerate;

	// Token: 0x04009321 RID: 37665
	public readonly GameSetting<ESamplingMode> SuperSampling;

	// Token: 0x04009322 RID: 37666
	public readonly GameSetting<AnisotropicFiltering> AnisotropicFiltering;

	// Token: 0x04009323 RID: 37667
	public readonly GameSetting<float> OverallVisibility;

	// Token: 0x04009324 RID: 37668
	public readonly GameSetting<float> LodBias;

	// Token: 0x04009325 RID: 37669
	public readonly GameSetting<int> MipStreamingBufferSize;

	// Token: 0x04009326 RID: 37670
	public readonly GameSetting<int> MipStreamingIOCount;

	// Token: 0x04009327 RID: 37671
	public readonly GameSetting<ESSAOMode> Ssao;

	// Token: 0x04009328 RID: 37672
	public readonly GameSetting<float> Sharpen;

	// Token: 0x04009329 RID: 37673
	public readonly GameSetting<ESSRMode> SSR;

	// Token: 0x0400932A RID: 37674
	public readonly GameSetting<EAntialiasingMode> AntiAliasing;

	// Token: 0x0400932B RID: 37675
	public readonly GameSetting<ENvidiaReflexMode> NVidiaReflex;

	// Token: 0x0400932C RID: 37676
	public readonly GameSetting<bool> GrassShadow;

	// Token: 0x0400932D RID: 37677
	public readonly GameSetting<bool> ChromaticAberrations;

	// Token: 0x0400932E RID: 37678
	public readonly GameSetting<bool> Noise;

	// Token: 0x0400932F RID: 37679
	public readonly GameSetting<bool> ZBlur;

	// Token: 0x04009330 RID: 37680
	public readonly GameSetting<bool> HighQualityColor;

	// Token: 0x04009331 RID: 37681
	public readonly GameSetting<bool> MipStreaming;

	// Token: 0x04009332 RID: 37682
	public readonly GameSetting<bool> SdTarkovStreets;

	// Token: 0x04009333 RID: 37683
	public readonly GameSetting<EDLSSMode> DLSSMode;

	// Token: 0x04009334 RID: 37684
	public readonly GameSetting<EFSRMode> FSRMode;

	// Token: 0x04009335 RID: 37685
	public readonly GameSetting<EFSR2Mode> FSR2Mode;

	// Token: 0x04009336 RID: 37686
	[CanBeNull]
	private readonly GClass946 gclass946_0;

	// Token: 0x04009337 RID: 37687
	[CompilerGenerated]
	private string string_0;

	// Token: 0x020019DB RID: 6619
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1544
	{
		// Token: 0x06008CFA RID: 36090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(int value)
		{
			throw null;
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(int value)
		{
			throw null;
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(float value)
		{
			throw null;
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_3(int value)
		{
			throw null;
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_4(int value)
		{
			throw null;
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_5(float value)
		{
			throw null;
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_6(float value)
		{
			throw null;
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ENvidiaReflexMode method_7(ENvidiaReflexMode value)
		{
			throw null;
		}

		// Token: 0x04009338 RID: 37688
		public static readonly GClass955.Class1544 class1544_0;

		// Token: 0x04009339 RID: 37689
		public static Func<int, int> func_0;

		// Token: 0x0400933A RID: 37690
		public static Func<int, int> func_1;

		// Token: 0x0400933B RID: 37691
		public static Func<float, float> func_2;

		// Token: 0x0400933C RID: 37692
		public static Func<int, int> func_3;

		// Token: 0x0400933D RID: 37693
		public static Func<int, int> func_4;

		// Token: 0x0400933E RID: 37694
		public static Func<float, float> func_5;

		// Token: 0x0400933F RID: 37695
		public static Func<float, float> func_6;

		// Token: 0x04009340 RID: 37696
		public static Func<ENvidiaReflexMode, ENvidiaReflexMode> func_7;
	}

	// Token: 0x020019DC RID: 6620
	[CompilerGenerated]
	private sealed class Class1545
	{
		// Token: 0x06008D02 RID: 36098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1879 stored)
		{
			throw null;
		}

		// Token: 0x04009341 RID: 37697
		public byte displayIndex;
	}

	// Token: 0x020019DD RID: 6621
	[CompilerGenerated]
	private sealed class Class1546
	{
		// Token: 0x06008D03 RID: 36099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1879 stored)
		{
			throw null;
		}

		// Token: 0x04009342 RID: 37698
		public byte displayIndex;
	}
}
