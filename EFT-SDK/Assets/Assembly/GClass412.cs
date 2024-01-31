using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;

// Token: 0x020003F3 RID: 1011
public class GClass412 : GClass411
{
	// Token: 0x14000027 RID: 39
	// (add) Token: 0x06001848 RID: 6216 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001849 RID: 6217 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnNoDamagedParts
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

	// Token: 0x14000028 RID: 40
	// (add) Token: 0x0600184A RID: 6218 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600184B RID: 6219 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnStartApply
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

	// Token: 0x14000029 RID: 41
	// (add) Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600184D RID: 6221 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnEndApply
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

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x0600184E RID: 6222 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsBleeding
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x0600184F RID: 6223 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual float min_percent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06001850 RID: 6224 RVA: 0x00002050 File Offset: 0x00000250
	public float LastEndTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06001851 RID: 6225 RVA: 0x00002050 File Offset: 0x00000250
	public bool Have2Do
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001853 RID: 6227 RVA: 0x00002050 File Offset: 0x00000250
	public bool Damaged
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

	// Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallStartUse()
	{
		throw null;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetHpPercent(EBodyPart percent)
	{
		throw null;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetDamaged()
	{
		throw null;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPartDamaged(EBodyPart partType)
	{
		throw null;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryApplyToCurrentPart(int? varianAnim = null, Action callback = null)
	{
		throw null;
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRandomPartToHeal()
	{
		throw null;
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckParts()
	{
		throw null;
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
		throw null;
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FirstAidApplied()
	{
		throw null;
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshMeds()
	{
		throw null;
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FindDamagedPart()
	{
		throw null;
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(MedsClass med, EDamageEffectType damageEffectType)
	{
		throw null;
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(int? varianAnim = null, Action callback = null)
	{
		throw null;
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04001525 RID: 5413
	private static readonly EDamageEffectType[] edamageEffectType_0;

	// Token: 0x04001526 RID: 5414
	protected float float_1;

	// Token: 0x04001527 RID: 5415
	private bool bool_2;

	// Token: 0x04001528 RID: 5416
	private bool bool_3;

	// Token: 0x04001529 RID: 5417
	private bool bool_4;

	// Token: 0x0400152A RID: 5418
	private bool bool_5;

	// Token: 0x0400152B RID: 5419
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400152C RID: 5420
	[CompilerGenerated]
	private Action<BotOwner> action_2;

	// Token: 0x0400152D RID: 5421
	[CompilerGenerated]
	private Action<BotOwner> action_3;

	// Token: 0x0400152E RID: 5422
	[CompilerGenerated]
	private bool bool_6;

	// Token: 0x020003F4 RID: 1012
	[CompilerGenerated]
	[Serializable]
	private sealed class Class211
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2722 kit)
		{
			throw null;
		}

		// Token: 0x0400152F RID: 5423
		public static readonly GClass412.Class211 class211_0;

		// Token: 0x04001530 RID: 5424
		public static Func<GClass2722, bool> func_0;
	}

	// Token: 0x020003F5 RID: 1013
	[CompilerGenerated]
	private sealed class Class212
	{
		// Token: 0x06001865 RID: 6245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GInterface130> hands)
		{
			throw null;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(Result<GInterface135> applyResult)
		{
			throw null;
		}

		// Token: 0x04001531 RID: 5425
		public Action callback;

		// Token: 0x04001532 RID: 5426
		public GClass412 gclass412_0;

		// Token: 0x04001533 RID: 5427
		public Callback<GInterface135> callback_0;
	}
}
