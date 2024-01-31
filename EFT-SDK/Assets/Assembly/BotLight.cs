using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x020002C9 RID: 713
public class BotLight : GClass362
{
	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
	public BotStroboscopeLight Stroboscope
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateStrope()
	{
		throw null;
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
	private Player.FirearmController FirearmController_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003AE RID: 942
	// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInDarkPlace
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float UpdateLightEnable(float curLightDist)
	{
		throw null;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindLight()
	{
		throw null;
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOff(bool dependceOnEnemy = true, bool anyTime = false)
	{
		throw null;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOn(bool anyTime = false)
	{
		throw null;
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanUseBySettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_1(float botVisibleDist)
	{
		throw null;
	}

	// Token: 0x04000E62 RID: 3682
	private const float DELAY = 3f;

	// Token: 0x04000E63 RID: 3683
	private bool _haveLight;

	// Token: 0x04000E64 RID: 3684
	private bool _canUseNow;

	// Token: 0x04000E65 RID: 3685
	private bool _isInDarkPlace;

	// Token: 0x04000E66 RID: 3686
	private float _curLightDist;

	// Token: 0x04000E67 RID: 3687
	private Player.FirearmController _firearmController;

	// Token: 0x04000E68 RID: 3688
	private float _nextTimeUpdaDist;

	// Token: 0x04000E69 RID: 3689
	private LightComponent _lightMod;

	// Token: 0x04000E6A RID: 3690
	private float _nextCanToggleTime;

	// Token: 0x04000E6B RID: 3691
	private BotStroboscopeLight _stroboscope;
}
