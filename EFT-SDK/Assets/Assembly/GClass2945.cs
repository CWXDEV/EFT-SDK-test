using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.CameraControl;
using UnityEngine;

// Token: 0x02002700 RID: 9984
public abstract class GClass2945
{
	// Token: 0x0600C615 RID: 50709
	public abstract void ManualFixedUpdate(float deltaTime);

	// Token: 0x0600C616 RID: 50710
	public abstract void ManualLateUpdate(float deltaTime);

	// Token: 0x0600C617 RID: 50711
	public abstract void SetPointOfView(EPointOfView pointOfView);

	// Token: 0x0600C618 RID: 50712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0()
	{
		throw null;
	}

	// Token: 0x0600C619 RID: 50713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnter()
	{
		throw null;
	}

	// Token: 0x0600C61A RID: 50714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnExit()
	{
		throw null;
	}

	// Token: 0x0400C7E6 RID: 51174
	protected readonly PlayerCameraController playerCameraController_0;

	// Token: 0x0400C7E7 RID: 51175
	protected readonly Player player_0;

	// Token: 0x0400C7E8 RID: 51176
	protected readonly Camera camera_0;
}
