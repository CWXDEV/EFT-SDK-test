using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02001565 RID: 5477
public static class GClass1663
{
	// Token: 0x06007567 RID: 30055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(IReadOnlyDictionary<GInterface94, GStruct173> playerAndDistances, IExplosiveItem grenadeItem, Vector3 grenadePosition, Func<DamageInfo> getDamageInfo, float directionalDamageMultiplier, float directionalDamageAngle, Vector3? explosionDirection)
	{
		throw null;
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Explosion(this IExplosiveItem grenadeItem, Vector3 explosionPosition, [CanBeNull] string playerProfileIDWhoThrew, GInterface355 ballisticsCalculator, [CanBeNull] Item originalWeaponItem, Func<DamageInfo> getDamageInfo, float directionalDamageMultiplier, float directionalDamageAngle, [CanBeNull] Vector3? explosionDirection)
	{
		throw null;
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerator smethod_1(bool groundExpl, bool skyExpl, int fragmentsCount, GInterface355 calculator, IExplosiveItem grenadeItem, Vector3 grenadePosition, [CanBeNull] string playerProfileID, [CanBeNull] Item originalWeaponItem)
	{
		throw null;
	}

	// Token: 0x04007B69 RID: 31593
	private const int int_0 = 10;

	// Token: 0x04007B6A RID: 31594
	private const int int_1 = 30;

	// Token: 0x04007B6B RID: 31595
	private const int int_2 = 8;

	// Token: 0x04007B6C RID: 31596
	private static int int_3;

	// Token: 0x04007B6D RID: 31597
	private static readonly Dictionary<GStruct196, float> dictionary_0;

	// Token: 0x04007B6E RID: 31598
	private static readonly Collider[] collider_0;

	// Token: 0x04007B6F RID: 31599
	private static readonly List<BodyPartCollider> list_0;

	// Token: 0x04007B70 RID: 31600
	private static readonly Dictionary<GInterface94, GStruct173> dictionary_1;

	// Token: 0x02001566 RID: 5478
	[CompilerGenerated]
	private sealed class Class1133
	{
		// Token: 0x04007B71 RID: 31601
		public Vector3 grenadePosition;

		// Token: 0x04007B72 RID: 31602
		public LayerMask limbsMask;
	}

	// Token: 0x02001567 RID: 5479
	[CompilerGenerated]
	private sealed class Class1134
	{
		// Token: 0x04007B73 RID: 31603
		public Vector3 hitPosition;

		// Token: 0x04007B74 RID: 31604
		public RaycastHit hit;

		// Token: 0x04007B75 RID: 31605
		public float distance;

		// Token: 0x04007B76 RID: 31606
		public GClass1663.Class1133 class1133_0;
	}

	// Token: 0x02001568 RID: 5480
	[CompilerGenerated]
	private sealed class Class1135
	{
		// Token: 0x0600756A RID: 30058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x04007B77 RID: 31607
		public Vector3 forwardHitPoint;

		// Token: 0x04007B78 RID: 31608
		public GClass1663.Class1134 class1134_0;
	}
}
