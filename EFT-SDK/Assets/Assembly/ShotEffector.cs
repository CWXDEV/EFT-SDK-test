using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Animations;
using EFT.Animations.NewRecoil;
using EFT.Animations.Recoil;
using EFT.InventoryLogic;
using FitstPersonAnimations.WeaponAnimation.Effectors.Recoil;
using UnityEngine;

// Token: 0x02000919 RID: 2329
[Serializable]
public class ShotEffector : IEffector
{
	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x06003491 RID: 13457 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003492 RID: 13458 RVA: 0x00002050 File Offset: 0x00000250
	public IRecoilShotEffect CurrentRecoilEffect
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

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x06003493 RID: 13459 RVA: 0x00002050 File Offset: 0x00000250
	private BackendConfigSettingsClass.AimingConfiguration AimingConfiguration_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x06003494 RID: 13460 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003495 RID: 13461 RVA: 0x00002050 File Offset: 0x00000250
	public int Pose
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

	// Token: 0x06003496 RID: 13462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ConvertFromTaxanomy(float f)
	{
		throw null;
	}

	// Token: 0x06003497 RID: 13463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float str = 1f)
	{
		throw null;
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(GInterface320 activeWeapon, SkillManager.GClass1768 buffInfo, Weapon mainWeaponInHands, Player.FirearmController firearms)
	{
		throw null;
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_1()
	{
		throw null;
	}

	// Token: 0x0600349B RID: 13467 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWeaponParametersChanged()
	{
		throw null;
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOldRecoilMode()
	{
		throw null;
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewRecoilMode()
	{
		throw null;
	}

	// Token: 0x0600349F RID: 13471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateRecoilParameters()
	{
		throw null;
	}

	// Token: 0x04003554 RID: 13652
	public RecoilPipelineType RecoilPipeline;

	// Token: 0x04003555 RID: 13653
	public OldRecoilShotEffect OldShotRecoil;

	// Token: 0x04003556 RID: 13654
	public NewRecoilShotEffect NewShotRecoil;

	// Token: 0x04003557 RID: 13655
	private IRecoilShotEffect _currentRecoilEffect;

	// Token: 0x04003558 RID: 13656
	private Player.FirearmController _firearmController;

	// Token: 0x04003559 RID: 13657
	private const float RECOIL_SUPPRESSION_FACTOR = 0.1f;

	// Token: 0x0400355A RID: 13658
	private GInterface320 _weapon;

	// Token: 0x0400355B RID: 13659
	private Weapon _mainWeaponInHands;

	// Token: 0x0400355C RID: 13660
	private BackendConfigSettingsClass.AimingConfiguration _aimingConfig;

	// Token: 0x0400355D RID: 13661
	private SkillManager.GClass1768 _buffs;

	// Token: 0x0400355E RID: 13662
	private int _pose;

	// Token: 0x0200091A RID: 2330
	[Serializable]
	public class RecoilShotVal
	{
		// Token: 0x060034A0 RID: 13472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(IRecoilShotEffect recoilShotEffect)
		{
			throw null;
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(Vector3 rnd)
		{
			throw null;
		}

		// Token: 0x0400355F RID: 13663
		public ComponentType FromAxis;

		// Token: 0x04003560 RID: 13664
		public Target ProcessType;

		// Token: 0x04003561 RID: 13665
		public ComponentType ToAxis;

		// Token: 0x04003562 RID: 13666
		public float IntensityMultiplicator;

		// Token: 0x04003563 RID: 13667
		private IRecoilShotEffect _recoilShotEffectTarget;

		// Token: 0x04003564 RID: 13668
		private int _component;

		// Token: 0x04003565 RID: 13669
		private int _from;
	}
}
