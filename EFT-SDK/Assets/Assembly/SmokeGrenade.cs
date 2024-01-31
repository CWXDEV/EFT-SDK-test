using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT;
using EFT.MovingPlatforms;
using UnityEngine;

// Token: 0x02000701 RID: 1793
public class SmokeGrenade : Grenade, MovingPlatform.GInterface347
{
	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x060029CE RID: 10702 RVA: 0x00002050 File Offset: 0x00000250
	public float EmitTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700073E RID: 1854
	// (get) Token: 0x060029CF RID: 10703 RVA: 0x00002050 File Offset: 0x00000250
	private SmokeGrenadeSettings SmokeGrenadeSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x060029D0 RID: 10704 RVA: 0x00002050 File Offset: 0x00000250
	public SphereCollider Area
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x060029D1 RID: 10705 RVA: 0x00002050 File Offset: 0x00000250
	public float Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x060029D2 RID: 10706 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029D3 RID: 10707 RVA: 0x00002050 File Offset: 0x00000250
	public MovingPlatform Platform
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

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x060029D4 RID: 10708 RVA: 0x00002050 File Offset: 0x00000250
	public GStruct33 NetworkData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x060029D5 RID: 10709 RVA: 0x00002050 File Offset: 0x00000250
	public float LifeTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(GrenadeSettings settings, IPlayer player, GrenadeClass throwWeap, float timeSpent, GInterface355 calculator)
	{
		throw null;
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmission(float time)
	{
		throw null;
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Update Emission Area")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEmissionArea(float normalTime)
	{
		throw null;
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnExplosion()
	{
		throw null;
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetThrowForce(Vector3 force)
	{
		throw null;
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartEmissionBehaviour()
	{
		throw null;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RemoveRigidBodyOnVelocityDrop(Throwable grenade)
	{
		throw null;
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveRigidbody()
	{
		throw null;
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("EmissionEnd")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InvokeEmissionEndEvent()
	{
		throw null;
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator DelayForEmitEvent(float time)
	{
		throw null;
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator EmissionAreaHandler(float rate)
	{
		throw null;
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Board(MovingPlatform platform)
	{
		throw null;
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetOff(MovingPlatform platform)
	{
		throw null;
	}

	// Token: 0x040027F5 RID: 10229
	private float float_7;

	// Token: 0x040027F6 RID: 10230
	private float float_8;

	// Token: 0x040027F7 RID: 10231
	private float float_9;

	// Token: 0x040027F8 RID: 10232
	private Vector3 vector3_2;

	// Token: 0x040027F9 RID: 10233
	public Action<Grenade> EmissionEnd;

	// Token: 0x040027FA RID: 10234
	private const float float_10 = 60f;

	// Token: 0x040027FB RID: 10235
	[CompilerGenerated]
	private MovingPlatform movingPlatform_0;
}
