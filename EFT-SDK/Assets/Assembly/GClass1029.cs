using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Koenigz.PerfectCulling;
using Koenigz.PerfectCulling.EFT;
using Unity.Jobs;

// Token: 0x02000DD9 RID: 3545
public sealed class GClass1029 : IDisposable
{
	// Token: 0x17000BDB RID: 3035
	// (get) Token: 0x06004A9D RID: 19101 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004A9E RID: 19102 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass1029 Instance
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

	// Token: 0x17000BDC RID: 3036
	// (get) Token: 0x06004A9F RID: 19103 RVA: 0x00002050 File Offset: 0x00000250
	public static ValueTuple<int, int> SwitchQueueSizes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BDD RID: 3037
	// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x00002050 File Offset: 0x00000250
	public static GStruct76 LastQuery
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BDE RID: 3038
	// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x00002050 File Offset: 0x00000250
	public static int NumDynamicVisibleLastFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000BDF RID: 3039
	// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x00002050 File Offset: 0x00000250
	public static int NumDynamicObjects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCullDynamicObjects(bool flag)
	{
		throw null;
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddDynamic(IAutocullAutomated obj)
	{
		throw null;
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveDynamic(IAutocullAutomated obj)
	{
		throw null;
	}

	// Token: 0x06004AA6 RID: 19110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06004AA7 RID: 19111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06004AA8 RID: 19112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004AA9 RID: 19113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(GStruct76 query)
	{
		throw null;
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<IAutocullAutomated> method_4()
	{
		throw null;
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AutocullLODGroupCell[] method_5()
	{
		throw null;
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040055CD RID: 21965
	[CompilerGenerated]
	private static GClass1029 gclass1029_0;

	// Token: 0x040055CE RID: 21966
	public const float FRAME_SWITCH_AMOUNT_FACTOR = 0.1f;

	// Token: 0x040055CF RID: 21967
	public const int SWITCH_COUNT_PER_FRAME = 150;

	// Token: 0x040055D0 RID: 21968
	private static List<IAutocullAutomated> list_0;

	// Token: 0x040055D1 RID: 21969
	private static BitArray bitArray_0;

	// Token: 0x040055D2 RID: 21970
	private static Stack<int> stack_0;

	// Token: 0x040055D3 RID: 21971
	private static Stack<int> stack_1;

	// Token: 0x040055D4 RID: 21972
	private static List<IAutocullAutomated> list_1;

	// Token: 0x040055D5 RID: 21973
	private static List<IAutocullAutomated> list_2;

	// Token: 0x040055D6 RID: 21974
	private static List<IAutocullAutomated> list_3;

	// Token: 0x040055D7 RID: 21975
	private JobHandle jobHandle_0;

	// Token: 0x040055D8 RID: 21976
	private JobHandle jobHandle_1;

	// Token: 0x040055D9 RID: 21977
	private static GStruct76 gstruct76_0;

	// Token: 0x040055DA RID: 21978
	private GClass1030 gclass1030_0;

	// Token: 0x040055DB RID: 21979
	private PerfectCullingCamera perfectCullingCamera_0;

	// Token: 0x040055DC RID: 21980
	private static int int_0;

	// Token: 0x040055DD RID: 21981
	private static int int_1;

	// Token: 0x040055DE RID: 21982
	private static bool bool_0;

	// Token: 0x02000DDA RID: 3546
	[StructLayout(LayoutKind.Auto, Size = 1)]
	public struct Struct157 : IJobParallelFor
	{
		// Token: 0x06004AB0 RID: 19120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int index)
		{
			throw null;
		}
	}

	// Token: 0x02000DDB RID: 3547
	[StructLayout(LayoutKind.Auto, Size = 1)]
	public struct Struct158 : IJob
	{
		// Token: 0x06004AB1 RID: 19121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}
	}

	// Token: 0x02000DDC RID: 3548
	[StructLayout(LayoutKind.Auto, Size = 1)]
	public struct Struct159 : IJobParallelFor
	{
		// Token: 0x06004AB2 RID: 19122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int index)
		{
			throw null;
		}
	}
}
