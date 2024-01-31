using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;

// Token: 0x0200051B RID: 1307
[RequireComponent(typeof(BoxCollider))]
public class AIPlaceInfo : MonoBehaviour, IPhysicsTrigger
{
	// Token: 0x1400004B RID: 75
	// (add) Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnPlayerEnter
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

	// Token: 0x1400004C RID: 76
	// (add) Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnPlayerExit
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

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
	public string Description
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ThrowGrenadePlace> CheckAllStart()
	{
		throw null;
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCount(Func<Player, bool> isGood)
	{
		throw null;
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<int> CheckAllPoints(bool shallRepeat)
	{
		throw null;
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
		throw null;
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(IEnumerable<Door> allDoors, BotsController botsController)
	{
		throw null;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnterPlace(Player player)
	{
		throw null;
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnLeavePlace(Player player)
	{
		throw null;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPhysicsTrigger.OnTriggerExit(Collider col)
	{
		throw null;
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPhysicsTrigger.OnTriggerEnter(Collider col)
	{
		throw null;
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EditorCheck()
	{
		throw null;
	}

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x06002003 RID: 8195 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
	bool IPhysicsTrigger.enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04001E94 RID: 7828
	public int AreaId;

	// Token: 0x04001E95 RID: 7829
	public string Id;

	// Token: 0x04001E96 RID: 7830
	public ThrowGrenadePlace[] GrenadePlaces;

	// Token: 0x04001E97 RID: 7831
	public BoxCollider Collider;

	// Token: 0x04001E98 RID: 7832
	public bool IsOnTrigger;

	// Token: 0x04001E99 RID: 7833
	public bool BlockGrenade;

	// Token: 0x04001E9A RID: 7834
	public bool IsDark;

	// Token: 0x04001E9B RID: 7835
	public bool IsInside;

	// Token: 0x04001E9C RID: 7836
	public bool AtrZone;

	// Token: 0x04001E9D RID: 7837
	private bool _isInited;

	// Token: 0x04001E9E RID: 7838
	private readonly HashSet<Player> _playersInside;

	// Token: 0x04001EA1 RID: 7841
	public AIPlaceInfoLogic InfoLogicAllEnemy;

	// Token: 0x04001EA2 RID: 7842
	public ECoverPointSpecial CoversSpecial;

	// Token: 0x04001EA3 RID: 7843
	private BotsController _botsController;

	// Token: 0x04001EA5 RID: 7845
	public bool UseAsCoverGroupId;
}
