using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020003EE RID: 1006
public class EnemyPart
{
	// Token: 0x0600182A RID: 6186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<BodyPartType, EnemyPart> Create(IPlayer person, PlayerBones bonse)
	{
		throw null;
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x0600182B RID: 6187 RVA: 0x00002050 File Offset: 0x00000250
	public IPlayer Owner
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x0600182C RID: 6188 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x0600182D RID: 6189 RVA: 0x00002050 File Offset: 0x00000250
	public BodyPartType BodyPartType
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x0600182E RID: 6190 RVA: 0x00002050 File Offset: 0x00000250
	public BodyPartCollider Collider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001830 RID: 6192 RVA: 0x00002050 File Offset: 0x00000250
	public float GrassDist
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

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06001831 RID: 6193 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001832 RID: 6194 RVA: 0x00002050 File Offset: 0x00000250
	public byte GreenType
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

	// Token: 0x06001833 RID: 6195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPartPositionWithOffset(Vector3 offset)
	{
		throw null;
	}

	// Token: 0x040014FE RID: 5374
	private readonly BifacialTransform _transform;

	// Token: 0x040014FF RID: 5375
	private readonly BodyPartCollider _bodyPartCollider;

	// Token: 0x04001500 RID: 5376
	private Vector3 _positionCached;

	// Token: 0x04001502 RID: 5378
	private int _posCachedForFrame;

	// Token: 0x04001506 RID: 5382
	public GClass521 VisibilityResult;
}
