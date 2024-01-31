using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200153A RID: 5434
[StructLayout(LayoutKind.Auto)]
public struct GStruct181
{
	// Token: 0x06007461 RID: 29793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface77 stream, ref GStruct181 packet)
	{
		throw null;
	}

	// Token: 0x06007462 RID: 29794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x04007ACB RID: 31435
	public bool ToggleTacticalCombo;

	// Token: 0x04007ACC RID: 31436
	public GStruct182[] TacticalComboStatuses;

	// Token: 0x0200153B RID: 5435
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1126
	{
		// Token: 0x06007463 RID: 29795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(GStruct182 x)
		{
			throw null;
		}

		// Token: 0x04007ACD RID: 31437
		public static readonly GStruct181.Class1126 class1126_0;

		// Token: 0x04007ACE RID: 31438
		public static Func<GStruct182, string> func_0;
	}
}
