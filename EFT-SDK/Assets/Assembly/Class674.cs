using System;
using System.Runtime.CompilerServices;
using Audio.Vehicles;

// Token: 0x02000D1B RID: 3355
internal abstract class Class674
{
	// Token: 0x17000B57 RID: 2903
	// (get) Token: 0x0600476D RID: 18285
	public abstract EVehicleMovementStatus Status { get; }

	// Token: 0x17000B58 RID: 2904
	// (get) Token: 0x0600476E RID: 18286 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCurrent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600476F RID: 18287 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual EVehicleMovementStatus Run()
	{
		throw null;
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		throw null;
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Exit()
	{
		throw null;
	}

	// Token: 0x04005252 RID: 21074
	protected readonly VehicleMovementSoundContext vehicleMovementSoundContext_0;
}
