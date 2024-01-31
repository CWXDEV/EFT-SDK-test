using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200243F RID: 9279
public class GrenadeClass : Item, IExplosiveItem
{
	// Token: 0x17002116 RID: 8470
	// (get) Token: 0x0600BA42 RID: 47682 RVA: 0x00002050 File Offset: 0x00000250
	public float GetExplDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002117 RID: 8471
	// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x00002050 File Offset: 0x00000250
	public float GetStrength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002118 RID: 8472
	// (get) Token: 0x0600BA44 RID: 47684 RVA: 0x00002050 File Offset: 0x00000250
	public float EmitTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002119 RID: 8473
	// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x00002050 File Offset: 0x00000250
	public float MinTimeToContactExplode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211A RID: 8474
	// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x00002050 File Offset: 0x00000250
	public ThrowWeapType ThrowType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211B RID: 8475
	// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Blindness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211C RID: 8476
	// (get) Token: 0x0600BA48 RID: 47688 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Contusion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211D RID: 8477
	// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 ArmorDistanceDistanceDamage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211E RID: 8478
	// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x00002050 File Offset: 0x00000250
	public float MinExplosionDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700211F RID: 8479
	// (get) Token: 0x0600BA4B RID: 47691 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxExplosionDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002120 RID: 8480
	// (get) Token: 0x0600BA4C RID: 47692 RVA: 0x00002050 File Offset: 0x00000250
	public int FragmentsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002121 RID: 8481
	// (get) Token: 0x0600BA4D RID: 47693 RVA: 0x00002050 File Offset: 0x00000250
	public float MinFragmentDamage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002122 RID: 8482
	// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxFragmentDamage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002123 RID: 8483
	// (get) Token: 0x0600BA4F RID: 47695 RVA: 0x00002050 File Offset: 0x00000250
	public string FragmentType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002124 RID: 8484
	// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanBeHiddenDuringThrow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002125 RID: 8485
	// (get) Token: 0x0600BA51 RID: 47697 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDummy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002126 RID: 8486
	// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x00002050 File Offset: 0x00000250
	public string ExplosionEffectType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BulletClass CreateFragment()
	{
		throw null;
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetItem()
	{
		throw null;
	}

	// Token: 0x0600BA55 RID: 47701 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_7()
	{
		throw null;
	}

	// Token: 0x0600BA56 RID: 47702 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_8()
	{
		throw null;
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_9()
	{
		throw null;
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_10()
	{
		throw null;
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_11()
	{
		throw null;
	}

	// Token: 0x0600BA5A RID: 47706 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_12()
	{
		throw null;
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_13()
	{
		throw null;
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_14()
	{
		throw null;
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_15()
	{
		throw null;
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_16()
	{
		throw null;
	}

	// Token: 0x02002440 RID: 9280
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2047
	{
		// Token: 0x0600BA5F RID: 47711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_0()
		{
			throw null;
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_1()
		{
			throw null;
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_2()
		{
			throw null;
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_3()
		{
			throw null;
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_4()
		{
			throw null;
		}

		// Token: 0x0400BD0E RID: 48398
		public static readonly GrenadeClass.Class2047 class2047_0;

		// Token: 0x0400BD0F RID: 48399
		public static Func<EItemAttributeDisplayType> func_0;

		// Token: 0x0400BD10 RID: 48400
		public static Func<EItemAttributeDisplayType> func_1;

		// Token: 0x0400BD11 RID: 48401
		public static Func<EItemAttributeDisplayType> func_2;

		// Token: 0x0400BD12 RID: 48402
		public static Func<EItemAttributeDisplayType> func_3;

		// Token: 0x0400BD13 RID: 48403
		public static Func<EItemAttributeDisplayType> func_4;
	}
}
