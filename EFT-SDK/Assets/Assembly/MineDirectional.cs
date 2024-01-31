using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200066B RID: 1643
public class MineDirectional : MonoBehaviour, IPhysicsTrigger
{
	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
	public string Tag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Player player)
	{
		throw null;
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Collider other)
	{
		throw null;
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerExit(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetArmed(bool isArmed)
	{
		throw null;
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Explosion()
	{
		throw null;
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(MineDirectional.MineSettings mineData, Vector3 explosionPosition, GInterface355 ballisticsCalculator)
	{
		throw null;
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private DamageInfo method_3()
	{
		throw null;
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
	bool IPhysicsTrigger.enabled
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

	// Token: 0x040024BC RID: 9404
	private static int int_0;

	// Token: 0x040024BD RID: 9405
	public static List<MineDirectional> Mines;

	// Token: 0x040024BE RID: 9406
	private static Lazy<GInterface355> lazy_0;

	// Token: 0x040024BF RID: 9407
	[SerializeField]
	private MineDirectional.MineSettings _mineData;

	// Token: 0x040024C0 RID: 9408
	private bool bool_0;

	// Token: 0x040024C1 RID: 9409
	private bool bool_1;

	// Token: 0x0200066C RID: 1644
	public class GClass607
	{
		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Serialize(MineDirectional mineDirectional)
		{
			throw null;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector3 Deserialize(byte[] data)
		{
			throw null;
		}

		// Token: 0x040024C2 RID: 9410
		private ArrayPool<byte> arrayPool_0;
	}

	// Token: 0x0200066D RID: 1645
	[Serializable]
	public struct MineSettings : IExplosiveItem
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x00002050 File Offset: 0x00000250
		public WildSpawnType IgnoreRole
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00002050 File Offset: 0x00000250
		public float ArmorDamage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00002050 File Offset: 0x00000250
		public float StaminaBurnRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x00002050 File Offset: 0x00000250
		public float PenetrationPower
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		public string FXName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Blindness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Contusion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 ArmorDistanceDistanceDamage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00002050 File Offset: 0x00000250
		public float MinExplosionDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00002050 File Offset: 0x00000250
		public float MaxExplosionDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x00002050 File Offset: 0x00000250
		public int FragmentsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00002050 File Offset: 0x00000250
		public float GetStrength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00002050 File Offset: 0x00000250
		public float GetDirectionalDamageAngle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00002050 File Offset: 0x00000250
		public float GetDirectionalDamageMultiplier
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x00002050 File Offset: 0x00000250
		public string Tag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BulletClass CreateFragment()
		{
			throw null;
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00002050 File Offset: 0x00000250
		public string FragmentType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDummy
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040024C3 RID: 9411
		[SerializeField]
		private Vector3 _blindness;

		// Token: 0x040024C4 RID: 9412
		[SerializeField]
		private Vector3 _contusion;

		// Token: 0x040024C5 RID: 9413
		[SerializeField]
		private Vector3 _armorDistanceDistanceDamage;

		// Token: 0x040024C6 RID: 9414
		[SerializeField]
		private float _minExplosionDistance;

		// Token: 0x040024C7 RID: 9415
		[SerializeField]
		private float _maxExplosionDistance;

		// Token: 0x040024C8 RID: 9416
		[SerializeField]
		private int _fragmentsCount;

		// Token: 0x040024C9 RID: 9417
		[SerializeField]
		private float _strength;

		// Token: 0x040024CA RID: 9418
		[SerializeField]
		private string _tag;

		// Token: 0x040024CB RID: 9419
		[SerializeField]
		private float _armorDamage;

		// Token: 0x040024CC RID: 9420
		[SerializeField]
		private float _staminaBurnRate;

		// Token: 0x040024CD RID: 9421
		[SerializeField]
		private float _penetrationPower;

		// Token: 0x040024CE RID: 9422
		[SerializeField]
		private string _fragmentType;

		// Token: 0x040024CF RID: 9423
		[SerializeField]
		private string _fxName;

		// Token: 0x040024D0 RID: 9424
		[SerializeField]
		private WildSpawnType _ignoreRole;

		// Token: 0x040024D1 RID: 9425
		[SerializeField]
		private float _directionalDamageAngle;

		// Token: 0x040024D2 RID: 9426
		[SerializeField]
		private float _directionalDamageMultiplier;
	}

	// Token: 0x0200066E RID: 1646
	[CompilerGenerated]
	[Serializable]
	private sealed class Class316
	{
		// Token: 0x060025B9 RID: 9657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GInterface355 method_0()
		{
			throw null;
		}

		// Token: 0x040024D3 RID: 9427
		public static readonly MineDirectional.Class316 class316_0;
	}
}
