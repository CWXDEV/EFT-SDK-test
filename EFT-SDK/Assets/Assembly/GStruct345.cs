using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x020021FF RID: 8703
[StructLayout(LayoutKind.Auto)]
public struct GStruct345 : GInterface141<GStruct345>
{
	// Token: 0x17001DD6 RID: 7638
	// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600B1D2 RID: 45522 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct345> Nested
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

	// Token: 0x0600B1D3 RID: 45523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B63E RID: 46654
	public GStruct345.ESyncType SyncType;

	// Token: 0x0400B63F RID: 46655
	public GStruct345.GStruct364 Data;

	// Token: 0x0400B640 RID: 46656
	[CompilerGenerated]
	private GInterface141<GStruct345> ginterface141_0;

	// Token: 0x02002200 RID: 8704
	public enum ESyncType
	{
		// Token: 0x0400B642 RID: 46658
		AddEffect,
		// Token: 0x0400B643 RID: 46659
		RemoveEffect,
		// Token: 0x0400B644 RID: 46660
		EffectNextState,
		// Token: 0x0400B645 RID: 46661
		EffectStateTime,
		// Token: 0x0400B646 RID: 46662
		EffectStrength,
		// Token: 0x0400B647 RID: 46663
		EffectMedResource,
		// Token: 0x0400B648 RID: 46664
		EffectStimulatorBuff,
		// Token: 0x0400B649 RID: 46665
		IsAlive,
		// Token: 0x0400B64A RID: 46666
		BodyHealth,
		// Token: 0x0400B64B RID: 46667
		Energy,
		// Token: 0x0400B64C RID: 46668
		Hydration,
		// Token: 0x0400B64D RID: 46669
		Temperature,
		// Token: 0x0400B64E RID: 46670
		DamageCoeff,
		// Token: 0x0400B64F RID: 46671
		ApplyDamage,
		// Token: 0x0400B650 RID: 46672
		DestroyedBodyPart,
		// Token: 0x0400B651 RID: 46673
		HealthRates,
		// Token: 0x0400B652 RID: 46674
		HealerDone,
		// Token: 0x0400B653 RID: 46675
		BurnEyes,
		// Token: 0x0400B654 RID: 46676
		Poison,
		// Token: 0x0400B655 RID: 46677
		StaminaCoeff
	}

	// Token: 0x02002201 RID: 8705
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct346
	{
		// Token: 0x0600B1D4 RID: 45524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B656 RID: 46678
		public int EffectId;

		// Token: 0x0400B657 RID: 46679
		public byte Type;

		// Token: 0x0400B658 RID: 46680
		public EBodyPart BodyPart;

		// Token: 0x0400B659 RID: 46681
		public float DelayTime;

		// Token: 0x0400B65A RID: 46682
		public float BuildUpTime;

		// Token: 0x0400B65B RID: 46683
		public float WorkTime;

		// Token: 0x0400B65C RID: 46684
		public float ResidueTime;

		// Token: 0x0400B65D RID: 46685
		public float Strength;

		// Token: 0x0400B65E RID: 46686
		public GStruct345.GStruct346.EExtraDataType ExtraDataType;

		// Token: 0x0400B65F RID: 46687
		public GStruct345.GStruct346.GStruct347 ExtraData;

		// Token: 0x02002202 RID: 8706
		public enum EExtraDataType
		{
			// Token: 0x0400B661 RID: 46689
			None,
			// Token: 0x0400B662 RID: 46690
			MedEffect,
			// Token: 0x0400B663 RID: 46691
			Stimulator
		}

		// Token: 0x02002203 RID: 8707
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct347
		{
			// Token: 0x0400B664 RID: 46692
			public GStruct342 MedEffect;

			// Token: 0x0400B665 RID: 46693
			public GStruct343 Stimulator;
		}
	}

	// Token: 0x02002204 RID: 8708
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct348
	{
		// Token: 0x0600B1D5 RID: 45525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B666 RID: 46694
		public int EffectId;
	}

	// Token: 0x02002205 RID: 8709
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct349
	{
		// Token: 0x0600B1D6 RID: 45526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B667 RID: 46695
		public int EffectId;

		// Token: 0x0400B668 RID: 46696
		public float StateTime;
	}

	// Token: 0x02002206 RID: 8710
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct350
	{
		// Token: 0x0600B1D7 RID: 45527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B669 RID: 46697
		public int EffectId;

		// Token: 0x0400B66A RID: 46698
		public float RemainingStateTime;
	}

	// Token: 0x02002207 RID: 8711
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct351
	{
		// Token: 0x0600B1D8 RID: 45528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B66B RID: 46699
		public int EffectId;

		// Token: 0x0400B66C RID: 46700
		public float Strength;
	}

	// Token: 0x02002208 RID: 8712
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct352
	{
		// Token: 0x0600B1D9 RID: 45529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B66D RID: 46701
		public int EffectId;

		// Token: 0x0400B66E RID: 46702
		public float Resource;
	}

	// Token: 0x02002209 RID: 8713
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct353
	{
		// Token: 0x0600B1DA RID: 45530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B66F RID: 46703
		public int EffectId;

		// Token: 0x0400B670 RID: 46704
		public int BuffIndex;

		// Token: 0x0400B671 RID: 46705
		public bool BuffActivate;

		// Token: 0x0400B672 RID: 46706
		public float BuffValue;

		// Token: 0x0400B673 RID: 46707
		public float BuffDuration;

		// Token: 0x0400B674 RID: 46708
		public float BuffDelay;
	}

	// Token: 0x0200220A RID: 8714
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct354
	{
		// Token: 0x0600B1DB RID: 45531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B675 RID: 46709
		public bool IsAlive;

		// Token: 0x0400B676 RID: 46710
		public EDamageType DamageType;
	}

	// Token: 0x0200220B RID: 8715
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct355
	{
		// Token: 0x0600B1DC RID: 45532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B677 RID: 46711
		public EBodyPart BodyPart;

		// Token: 0x0400B678 RID: 46712
		public float Value;
	}

	// Token: 0x0200220C RID: 8716
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct356
	{
		// Token: 0x0600B1DD RID: 45533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B679 RID: 46713
		public float Value;
	}

	// Token: 0x0200220D RID: 8717
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct357
	{
		// Token: 0x0600B1DE RID: 45534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B67A RID: 46714
		public float DamageCoeff;
	}

	// Token: 0x0200220E RID: 8718
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct358
	{
		// Token: 0x0600B1DF RID: 45535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B67B RID: 46715
		public float StaminaCoeff;
	}

	// Token: 0x0200220F RID: 8719
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct359
	{
		// Token: 0x0600B1E0 RID: 45536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B67C RID: 46716
		public EBodyPart BodyPart;

		// Token: 0x0400B67D RID: 46717
		public float Damage;

		// Token: 0x0400B67E RID: 46718
		public EDamageType DamageType;
	}

	// Token: 0x02002210 RID: 8720
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct360
	{
		// Token: 0x0600B1E1 RID: 45537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B67F RID: 46719
		public EBodyPart BodyPart;

		// Token: 0x0400B680 RID: 46720
		public bool IsDestroyed;

		// Token: 0x0400B681 RID: 46721
		public EDamageType DamageType;

		// Token: 0x0400B682 RID: 46722
		public float HealthMaximum;
	}

	// Token: 0x02002211 RID: 8721
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct361
	{
		// Token: 0x0600B1E2 RID: 45538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B683 RID: 46723
		public float HealRate;

		// Token: 0x0400B684 RID: 46724
		public float DamageRate;

		// Token: 0x0400B685 RID: 46725
		public float DamageMultiplier;

		// Token: 0x0400B686 RID: 46726
		public float Energy;

		// Token: 0x0400B687 RID: 46727
		public float Hydration;

		// Token: 0x0400B688 RID: 46728
		public float Temperature;
	}

	// Token: 0x02002212 RID: 8722
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct362
	{
		// Token: 0x0600B1E3 RID: 45539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B689 RID: 46729
		public int EffectId;
	}

	// Token: 0x02002213 RID: 8723
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct363
	{
		// Token: 0x0600B1E4 RID: 45540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B68A RID: 46730
		public Vector3 Position;

		// Token: 0x0400B68B RID: 46731
		public float DistanceStrength;

		// Token: 0x0400B68C RID: 46732
		public float NormalTime;
	}

	// Token: 0x02002214 RID: 8724
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct364
	{
		// Token: 0x0400B68D RID: 46733
		public GStruct345.GStruct346 AddEffect;

		// Token: 0x0400B68E RID: 46734
		public GStruct345.GStruct348 RemoveEffect;

		// Token: 0x0400B68F RID: 46735
		public GStruct345.GStruct349 EffectNextState;

		// Token: 0x0400B690 RID: 46736
		public GStruct345.GStruct350 EffectStateTime;

		// Token: 0x0400B691 RID: 46737
		public GStruct345.GStruct351 EffectStrength;

		// Token: 0x0400B692 RID: 46738
		public GStruct345.GStruct352 EffectMedResource;

		// Token: 0x0400B693 RID: 46739
		public GStruct345.GStruct353 EffectStimulatorBuff;

		// Token: 0x0400B694 RID: 46740
		public GStruct345.GStruct354 IsAlive;

		// Token: 0x0400B695 RID: 46741
		public GStruct345.GStruct355 BodyHealth;

		// Token: 0x0400B696 RID: 46742
		public GStruct345.GStruct356 Energy;

		// Token: 0x0400B697 RID: 46743
		public GStruct345.GStruct356 Hydration;

		// Token: 0x0400B698 RID: 46744
		public GStruct345.GStruct356 Temperature;

		// Token: 0x0400B699 RID: 46745
		public GStruct345.GStruct356 Poison;

		// Token: 0x0400B69A RID: 46746
		public GStruct345.GStruct357 DamageCoeff;

		// Token: 0x0400B69B RID: 46747
		public GStruct345.GStruct358 StaminaCoeff;

		// Token: 0x0400B69C RID: 46748
		public GStruct345.GStruct359 ApplyDamage;

		// Token: 0x0400B69D RID: 46749
		public GStruct345.GStruct360 DestroyedBodyPart;

		// Token: 0x0400B69E RID: 46750
		public GStruct345.GStruct361 HealthRates;

		// Token: 0x0400B69F RID: 46751
		public GStruct345.GStruct362 HealerDone;

		// Token: 0x0400B6A0 RID: 46752
		public GStruct345.GStruct363 BurnEyes;
	}
}
