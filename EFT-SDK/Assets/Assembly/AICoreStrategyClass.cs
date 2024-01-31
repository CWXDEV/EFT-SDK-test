using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000111 RID: 273
public abstract class AICoreStrategyClass<T>
{
	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AICoreLayerClass<T>> OnLayerChangedTo
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
	private AICoreLayerClass<T> GClass28_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(GClass25 coreAgent)
	{
		throw null;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AICoreActionResultStruct<T>? Update(AICoreActionResultStruct<T> prevResult)
	{
		throw null;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetActiveLayerDebug()
	{
		throw null;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_0(int index, AICoreLayerClass<T> layer, bool activeOnStart)
	{
		throw null;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(int index)
	{
		throw null;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_2(AICoreLayerClass<T> index)
	{
		throw null;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(int index)
	{
		throw null;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(AICoreLayerClass<T> layer)
	{
		throw null;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveLayer<TLayer>() where TLayer : AICoreLayerClass<T>
	{
		throw null;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveLayer<TLayer>(out TLayer layerTarget) where TLayer : AICoreLayerClass<T>
	{
		throw null;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLayerActive<TLayer>() where TLayer : AICoreLayerClass<T>
	{
		throw null;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x040006CE RID: 1742
	private readonly Dictionary<int, AICoreLayerClass<T>> dictionary_0;

	// Token: 0x040006CF RID: 1743
	private readonly List<AICoreLayerClass<T>> list_0;

	// Token: 0x040006D0 RID: 1744
	private GClass25 gclass25_0;

	// Token: 0x040006D1 RID: 1745
	[CompilerGenerated]
	private Action<AICoreLayerClass<T>> action_0;

	// Token: 0x040006D2 RID: 1746
	[CompilerGenerated]
	private AICoreLayerClass<T> gclass28_0;
}
