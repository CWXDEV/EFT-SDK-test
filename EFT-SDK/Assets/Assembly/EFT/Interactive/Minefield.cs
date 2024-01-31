using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002788 RID: 10120
	public class Minefield : BorderZone
	{
		// Token: 0x0600CAB5 RID: 51893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsInTriggerZone(Vector3 global)
		{
			throw null;
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator FireCoroutine(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IPlayer player, bool first)
		{
			throw null;
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IPlayer player, float distance, bool first, bool isCollateral)
		{
			throw null;
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_4(BodyPartCollider x)
		{
			throw null;
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5(BodyPartCollider x)
		{
			throw null;
		}

		// Token: 0x0400CAC7 RID: 51911
		private const float float_1 = 1f;

		// Token: 0x0400CAC8 RID: 51912
		[SerializeField]
		private float _zoneDistortionPeriod;

		// Token: 0x0400CAC9 RID: 51913
		[SerializeField]
		private float _zoneDistortionPower;

		// Token: 0x0400CACA RID: 51914
		[SerializeField]
		private float _contusionStrength;

		// Token: 0x0400CACB RID: 51915
		[SerializeField]
		private float _contusionDuration;

		// Token: 0x0400CACC RID: 51916
		[SerializeField]
		private float _collateralContusionRange;

		// Token: 0x0400CACD RID: 51917
		[SerializeField]
		private float _collateralDamageRange;

		// Token: 0x0400CACE RID: 51918
		[SerializeField]
		private List<EBodyPart> _explosionTarget;

		// Token: 0x0400CACF RID: 51919
		[SerializeField]
		private List<EBodyPart> _collateralDamageTarget;

		// Token: 0x0400CAD0 RID: 51920
		[SerializeField]
		private float _firstExplosionDamage;

		// Token: 0x0400CAD1 RID: 51921
		[SerializeField]
		private float _minRangeToNextExplosion;

		// Token: 0x0400CAD2 RID: 51922
		[SerializeField]
		private float _maxRangeToNextExplosion;

		// Token: 0x0400CAD3 RID: 51923
		[SerializeField]
		private float _secondExplosionDamage;

		// Token: 0x0200278A RID: 10122
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2285
		{
			// Token: 0x0600CABF RID: 51903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EBodyPart method_0(BodyPartCollider x)
			{
				throw null;
			}

			// Token: 0x0400CADB RID: 51931
			public static readonly Minefield.Class2285 class2285_0;

			// Token: 0x0400CADC RID: 51932
			public static Func<BodyPartCollider, EBodyPart> func_0;
		}
	}
}
