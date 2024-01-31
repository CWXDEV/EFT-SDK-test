using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000464 RID: 1124
public class BotPeacefulActions : GClass362
{
	// Token: 0x14000030 RID: 48
	// (add) Token: 0x06001B1C RID: 6940 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass346> OnStartPeacefulMove
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

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
	private BotGlobalPatrolSettings BotGlobalPatrolSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDo(GClass346 pairData)
	{
		throw null;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveAction(GClass346 pairData, EGesture gestus, float delay = -1f)
	{
		throw null;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAction()
	{
		throw null;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayer(IPlayer gamePerson)
	{
		throw null;
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass346 data)
	{
		throw null;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass346 obj)
	{
		throw null;
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001738 RID: 5944
	private const float STANDART_DELAY = 1f;

	// Token: 0x04001739 RID: 5945
	private readonly List<EGesture> _list;

	// Token: 0x0400173A RID: 5946
	private float _nextGusture;

	// Token: 0x0400173B RID: 5947
	private GClass346 _activeData;

	// Token: 0x0400173C RID: 5948
	private EGesture _lastGesture;

	// Token: 0x0400173D RID: 5949
	private bool _errorInited;

	// Token: 0x02000465 RID: 1125
	[CompilerGenerated]
	private sealed class Class227
	{
		// Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400173F RID: 5951
		public BotPeacefulActions botPeacefulActions_0;

		// Token: 0x04001740 RID: 5952
		public EGesture gestus;

		// Token: 0x04001741 RID: 5953
		public GClass346 pairData;
	}
}
