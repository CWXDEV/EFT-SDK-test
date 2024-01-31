using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.DataProviding;

// Token: 0x020026E5 RID: 9957
public sealed class GClass2931
{
	// Token: 0x17002348 RID: 9032
	// (get) Token: 0x0600C562 RID: 50530 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass2931 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002349 RID: 9033
	// (get) Token: 0x0600C563 RID: 50531 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Type, GInterface348>.ValueCollection AllInitedData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700234A RID: 9034
	// (get) Token: 0x0600C564 RID: 50532 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasDataToTransfer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C565 RID: 50533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600C566 RID: 50534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Type> method_1<T>() where T : GInterface348
	{
		throw null;
	}

	// Token: 0x0600C567 RID: 50535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref GInterface79 writerStream, bool isFullUpdate = false)
	{
		throw null;
	}

	// Token: 0x0600C568 RID: 50536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(ref GInterface76 readerStream)
	{
		throw null;
	}

	// Token: 0x0600C569 RID: 50537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData<T>(out T dataContainer) where T : class, GInterface348
	{
		throw null;
	}

	// Token: 0x0600C56A RID: 50538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetData(Type containerType, out GInterface348 dataContainer)
	{
		throw null;
	}

	// Token: 0x0600C56B RID: 50539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetData<T>() where T : GInterface348
	{
		throw null;
	}

	// Token: 0x0600C56C RID: 50540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CreateData<T>(EDataLifeTime dataLifeTime)
	{
		throw null;
	}

	// Token: 0x0600C56D RID: 50541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(Type type, EDataLifeTime dataLifeTime)
	{
		throw null;
	}

	// Token: 0x0600C56E RID: 50542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C745 RID: 51013
	private static GClass2931 gclass2931_0;

	// Token: 0x0400C746 RID: 51014
	private readonly GClass570<GInterface348> gclass570_0;

	// Token: 0x0400C747 RID: 51015
	private readonly Dictionary<int, Type> dictionary_0;

	// Token: 0x0400C748 RID: 51016
	private readonly Dictionary<Type, int> dictionary_1;

	// Token: 0x0400C749 RID: 51017
	private readonly Dictionary<Type, EDataLifeTime> dictionary_2;

	// Token: 0x0400C74A RID: 51018
	private readonly Dictionary<EDataLifeTime, List<GInterface348>> dictionary_3;

	// Token: 0x0400C74B RID: 51019
	private readonly List<GInterface349> list_0;

	// Token: 0x0400C74C RID: 51020
	private int int_0;
}
