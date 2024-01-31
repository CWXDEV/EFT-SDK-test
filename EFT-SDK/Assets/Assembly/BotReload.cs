using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;

// Token: 0x020002E9 RID: 745
public abstract class BotReload : GClass362
{
	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
	protected IFirearmHandsController ShootController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
	public bool NoAmmoForReloadCached
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxBulletCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
	public int BulletCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
	public bool Reloading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotReload Create(BotOwner owner, Weapon weapon, EquipmentSlot slot)
	{
		throw null;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool FightShallReload()
	{
		throw null;
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckReloadLongTime()
	{
		throw null;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanReload(bool withCheckByPeriod)
	{
		throw null;
	}

	// Token: 0x06000FE1 RID: 4065
	public abstract bool CanReload(bool withCheckByPeriod, out MagazineClass foundMag, out List<BulletClass> ammoForInternalReload);

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CanReloadPreCheck(bool withCheckByPeriod, out MagazineClass currentMagazine)
	{
		throw null;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Reload()
	{
		throw null;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ReloadMagazine(MagazineClass foundMag)
	{
		throw null;
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ReloadAmmo(List<BulletClass> foundAmmo)
	{
		throw null;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryStopReload()
	{
		throw null;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryReload()
	{
		throw null;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void TryUploadMagazine()
	{
		throw null;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected MagazineClass GetMagazineForReload(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddAmmoToPockets(string templateId, int targetCount)
	{
		throw null;
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Weapon weapon, MagazineClass foundMag)
	{
		throw null;
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BulletClass method_3(Weapon weapon, MagazineClass foundMag)
	{
		throw null;
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryFillMagazines()
	{
		throw null;
	}

	// Token: 0x04000F19 RID: 3865
	protected const int AMMO_RELOAD_MAX_TIME = 40;

	// Token: 0x04000F1A RID: 3866
	protected const int MAG_RELOAD_MAX_TIME = 16;

	// Token: 0x04000F1B RID: 3867
	protected const float PAUSE_BETWEEN_TRY_TO_RELOAD = 0.5f;

	// Token: 0x04000F1C RID: 3868
	protected static readonly EquipmentSlot[] _availableEquipmentSlots;

	// Token: 0x04000F1D RID: 3869
	protected static readonly List<MagazineClass> _preallocatedMagazineList;

	// Token: 0x04000F1E RID: 3870
	protected static readonly List<BulletClass> _preallocatedAmmoList;

	// Token: 0x04000F1F RID: 3871
	protected readonly Player _player;

	// Token: 0x04000F20 RID: 3872
	protected float _reloadStartTime;

	// Token: 0x04000F21 RID: 3873
	protected bool _reloading;

	// Token: 0x04000F22 RID: 3874
	protected float _nextReloadTime;

	// Token: 0x04000F23 RID: 3875
	protected bool _reloadFailDebug;

	// Token: 0x04000F24 RID: 3876
	protected BotReload.EReloadType _reloadType;

	// Token: 0x04000F25 RID: 3877
	protected float _nextCanExtraLoadAmmo;

	// Token: 0x04000F26 RID: 3878
	protected float _nextPossibleTryStopReload;

	// Token: 0x04000F27 RID: 3879
	protected Weapon _weapon;

	// Token: 0x020002EA RID: 746
	protected enum EReloadType
	{
		// Token: 0x04000F2A RID: 3882
		MagReload,
		// Token: 0x04000F2B RID: 3883
		AmmoReload
	}

	// Token: 0x020002EB RID: 747
	[CompilerGenerated]
	private sealed class Class165
	{
		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x04000F2C RID: 3884
		public MagazineClass magModInWeapon;

		// Token: 0x04000F2D RID: 3885
		public BotReload botReload_0;
	}

	// Token: 0x020002EC RID: 748
	[CompilerGenerated]
	[Serializable]
	private sealed class Class166
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2765 x)
		{
			throw null;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x04000F2E RID: 3886
		public static readonly BotReload.Class166 class166_0;

		// Token: 0x04000F2F RID: 3887
		public static Func<GClass2765, bool> func_0;
	}

	// Token: 0x020002ED RID: 749
	[CompilerGenerated]
	private sealed class Class167
	{
		// Token: 0x04000F30 RID: 3888
		public BotReload botReload_0;

		// Token: 0x04000F31 RID: 3889
		public int stockCount;
	}

	// Token: 0x020002EE RID: 750
	[CompilerGenerated]
	private sealed class Class168
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult s)
		{
			throw null;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult s)
		{
			throw null;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IResult s)
		{
			throw null;
		}

		// Token: 0x04000F32 RID: 3890
		public string ammoToAdd;

		// Token: 0x04000F33 RID: 3891
		public BotReload.Class167 class167_0;
	}

	// Token: 0x020002EF RID: 751
	[CompilerGenerated]
	private sealed class Class169
	{
		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item x)
		{
			throw null;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Item x)
		{
			throw null;
		}

		// Token: 0x04000F34 RID: 3892
		public string templateId;

		// Token: 0x04000F35 RID: 3893
		public Func<Item, bool> func_0;
	}

	// Token: 0x020002F0 RID: 752
	[CompilerGenerated]
	private sealed class Class170
	{
		// Token: 0x06000FFB RID: 4091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(MagazineClass mag)
		{
			throw null;
		}

		// Token: 0x04000F36 RID: 3894
		public Slot magazineSlot;
	}
}
