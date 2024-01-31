using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AnimationEventSystem;
using EFT;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x02001FD0 RID: 8144
public abstract class GClass2364
{
	// Token: 0x17001BC7 RID: 7111
	// (get) Token: 0x0600A917 RID: 43287 RVA: 0x00002050 File Offset: 0x00000250
	public FirearmsAnimator FirearmsAnimator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BC8 RID: 7112
	// (get) Token: 0x0600A918 RID: 43288 RVA: 0x00002050 File Offset: 0x00000250
	public BaseAnimationHandsController HandsAnimationController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A919 RID: 43289 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2364 CreateInstance(EHandsControllerType controllerType, GameObject gameObject, IPlayer player, PlayerBones bones, GClass2372 handsController)
	{
		throw null;
	}

	// Token: 0x0600A91A RID: 43290 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup(GClass2372 handsController, IAnimator playerAnimator, FirearmsAnimator weaponPrefabFirearmsAnimator, AnimationEventsEmitter weaponPrefabAnimationEventsEmitter, EHandsControllerType handsControllerType, Func<bool> needFastForward, Func<bool> isPlayerCulled)
	{
		throw null;
	}

	// Token: 0x0600A91B RID: 43291 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Spawn(float animationSpeed)
	{
		throw null;
	}

	// Token: 0x0600A91C RID: 43292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Unspawn(float animationSpeed, bool fastHide)
	{
		throw null;
	}

	// Token: 0x0600A91D RID: 43293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Destroy()
	{
		throw null;
	}

	// Token: 0x0600A91E RID: 43294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ChangeMod()
	{
		throw null;
	}

	// Token: 0x0600A91F RID: 43295
	public abstract Task Execute(GInterface218 command);

	// Token: 0x0600A920 RID: 43296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FastForward()
	{
		throw null;
	}

	// Token: 0x0400AFC7 RID: 44999
	private readonly TimeSpan timeSpan_0;

	// Token: 0x0400AFC8 RID: 45000
	private BaseAnimationHandsController baseAnimationHandsController_0;

	// Token: 0x0400AFC9 RID: 45001
	private GClass2372 gclass2372_0;
}
