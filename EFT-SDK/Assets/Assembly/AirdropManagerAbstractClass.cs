using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Airdrop;
using EFT.SynchronizableObjects;
using UnityEngine;

// Token: 0x02001E41 RID: 7745
public abstract class AirdropManagerAbstractClass : IDisposable
{
	// Token: 0x17001932 RID: 6450
	// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009EE4 RID: 40676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(bool enableAirdrops)
	{
		throw null;
	}

	// Token: 0x06009EE5 RID: 40677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06009EE6 RID: 40678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AirdropEvent(long buttonClickLastTime)
	{
		throw null;
	}

	// Token: 0x06009EE7 RID: 40679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddProjectile(GameObject projectile, float expiredTime)
	{
		throw null;
	}

	// Token: 0x06009EE8 RID: 40680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFlareSuccessEvent(bool canSendAirdrop)
	{
		throw null;
	}

	// Token: 0x06009EE9 RID: 40681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<bool> InitContainerLoot(AirdropSynchronizableObject container)
	{
		throw null;
	}

	// Token: 0x06009EEA RID: 40682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject TakeAirdropPoint(bool takeNearbyPoint = false, Vector3 position = default(Vector3))
	{
		throw null;
	}

	// Token: 0x06009EEB RID: 40683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 pointPosition)
	{
		throw null;
	}

	// Token: 0x06009EEC RID: 40684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009EED RID: 40685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400A766 RID: 42854
	private List<AirdropPoint> list_0;

	// Token: 0x0400A767 RID: 42855
	protected List<AirdropPoint> list_1;

	// Token: 0x0400A768 RID: 42856
	protected TimerClass gclass698_0;

	// Token: 0x0400A769 RID: 42857
	protected LocationSettingsClass.Location.GClass1218 gclass1218_0;

	// Token: 0x0400A76A RID: 42858
	public LocationSettingsClass.Location.GClass1218[] AirdropParameters;

	// Token: 0x0400A76B RID: 42859
	protected bool bool_0;
}
