using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020004D2 RID: 1234
public class RecoilData
{
	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RecoilOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LosingRecoil()
	{
		throw null;
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckEndRecoil()
	{
		throw null;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Recoil()
	{
		throw null;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Info()
	{
		throw null;
	}

	// Token: 0x040019B5 RID: 6581
	private float _remainRecoilTime;

	// Token: 0x040019B6 RID: 6582
	private float _lastRecoilSetTime;

	// Token: 0x040019B7 RID: 6583
	private Vector3 _recoilOffset;

	// Token: 0x040019B8 RID: 6584
	private Vector3 _lastRecoilFullOffset;

	// Token: 0x040019B9 RID: 6585
	private readonly BotOwner _owner;

	// Token: 0x040019BA RID: 6586
	private float _endRecoilTime;

	// Token: 0x040019BB RID: 6587
	private readonly bool _endRecoilCheck;
}
