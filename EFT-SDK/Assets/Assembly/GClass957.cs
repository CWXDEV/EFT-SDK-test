using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using EFT.InputSystem;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using Newtonsoft.Json;

// Token: 0x020019EC RID: 6636
public sealed class GClass957 : GClass952<GClass957>
{
	// Token: 0x17001576 RID: 5494
	// (set) Token: 0x06008D26 RID: 36134 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty]
	public string SystemMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17001577 RID: 5495
	// (get) Token: 0x06008D27 RID: 36135 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008D28 RID: 36136 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x06008D29 RID: 36137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MergeAxisWithDefault(List<AxisGroup> defaultBindings)
	{
		throw null;
	}

	// Token: 0x06008D2A RID: 36138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static AxisGroup smethod_0(List<AxisGroup> axisBindings, EAxis axisName)
	{
		throw null;
	}

	// Token: 0x06008D2B RID: 36139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<AxisGroup> smethod_1(List<AxisGroup> axisBindings)
	{
		throw null;
	}

	// Token: 0x06008D2C RID: 36140 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBoundItemNames(EBoundItem boundItem)
	{
		throw null;
	}

	// Token: 0x06008D2D RID: 36141 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetKeyName(EGameKey key)
	{
		throw null;
	}

	// Token: 0x06008D2E RID: 36142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyGroup[] GetAllKeyBindings()
	{
		throw null;
	}

	// Token: 0x06008D2F RID: 36143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MergeKeysWithDefault(List<KeyGroup> defaultBindings)
	{
		throw null;
	}

	// Token: 0x06008D30 RID: 36144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static KeyGroup smethod_2(IReadOnlyList<KeyGroup> keyBindings, EGameKey keyName)
	{
		throw null;
	}

	// Token: 0x06008D31 RID: 36145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateMergedControl(EGameKey mergedControl, EGameKey control1, EGameKey control2)
	{
		throw null;
	}

	// Token: 0x06008D32 RID: 36146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateControlWithAnotherPressType(GClass1871 value)
	{
		throw null;
	}

	// Token: 0x06008D33 RID: 36147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(EGameKey toRemove)
	{
		throw null;
	}

	// Token: 0x06008D34 RID: 36148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<KeyGroup> smethod_3(List<KeyGroup> keyBindings)
	{
		throw null;
	}

	// Token: 0x06008D35 RID: 36149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass957 Clone()
	{
		throw null;
	}

	// Token: 0x06008D36 RID: 36150 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_4(KeyGroup group1, KeyGroup group2,  ValueTuple<int, int> index, out InputSource result)
	{
		throw null;
	}

	// Token: 0x06008D37 RID: 36151 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_5(InputSource source, InputSource target)
	{
		throw null;
	}

	// Token: 0x04009383 RID: 37763
	public const float MOUSE_SENS_MIN = 0.1f;

	// Token: 0x04009384 RID: 37764
	public const float MOUSE_SENS_MAX = 5f;

	// Token: 0x04009385 RID: 37765
	public const float DOUBLE_CLICK_MIN = 0.3f;

	// Token: 0x04009386 RID: 37766
	public const float DOUBLE_CLICK_MAX = 1f;

	// Token: 0x04009387 RID: 37767
	public static readonly IReadOnlyList<KeyGroup> ReservedKeys;

	// Token: 0x04009388 RID: 37768
	public readonly GameSetting<bool> InvertedXAxis;

	// Token: 0x04009389 RID: 37769
	public readonly GameSetting<bool> InvertedYAxis;

	// Token: 0x0400938A RID: 37770
	public readonly GameSetting<float> MouseSensitivity;

	// Token: 0x0400938B RID: 37771
	public readonly GameSetting<float> MouseAimingSensitivity;

	// Token: 0x0400938C RID: 37772
	public readonly GameSetting<float> DoubleClickTimeout;

	// Token: 0x0400938D RID: 37773
	[JsonProperty("axisBindings")]
	public readonly ListGameSetting<AxisGroup> UserAxisBindings;

	// Token: 0x0400938E RID: 37774
	[JsonProperty("keyBindings")]
	public readonly ListGameSetting<KeyGroup> UserKeyBindings;

	// Token: 0x0400938F RID: 37775
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04009390 RID: 37776
	private readonly List<KeyGroup> list_1;

	// Token: 0x020019ED RID: 6637
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1553
	{
		// Token: 0x06008D38 RID: 36152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(float value)
		{
			throw null;
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(float value)
		{
			throw null;
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(float value)
		{
			throw null;
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(InputSource keyVariant)
		{
			throw null;
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal InputSource method_4(InputSource x)
		{
			throw null;
		}

		// Token: 0x04009391 RID: 37777
		public static readonly GClass957.Class1553 class1553_0;

		// Token: 0x04009392 RID: 37778
		public static Func<float, float> func_0;

		// Token: 0x04009393 RID: 37779
		public static Func<float, float> func_1;

		// Token: 0x04009394 RID: 37780
		public static Func<float, float> func_2;

		// Token: 0x04009395 RID: 37781
		public static Func<InputSource, bool> func_3;

		// Token: 0x04009396 RID: 37782
		public static Func<InputSource, InputSource> func_4;
	}
}
