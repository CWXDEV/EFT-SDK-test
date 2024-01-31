using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using UnityEngine;

// Token: 0x02000887 RID: 2183
public class UtilityApplication : ClientApplication<BackendDummyClass.GClass1828>
{
	// Token: 0x06003134 RID: 12596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Start()
	{
		throw null;
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1()
	{
		throw null;
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2()
	{
		throw null;
	}

	// Token: 0x04003250 RID: 12880
	[SerializeField]
	private string _locale;

	// Token: 0x04003251 RID: 12881
	[SerializeField]
	private bool _loadTemplatesFromBackend;

	// Token: 0x04003252 RID: 12882
	[SerializeField]
	private bool _dropCache;

	// Token: 0x04003253 RID: 12883
	protected ItemFactory ItemFactory;

	// Token: 0x04003254 RID: 12884
	protected GClass1484 ItemRegistry;
}
