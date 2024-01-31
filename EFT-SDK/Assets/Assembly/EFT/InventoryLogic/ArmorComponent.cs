using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

namespace EFT.InventoryLogic
{
	// Token: 0x0200224F RID: 8783
	public class ArmorComponent : GClass2750
	{
		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x00002050 File Offset: 0x00000250
		public MaterialType Material
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x00002050 File Offset: 0x00000250
		public int ArmorClass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x00002050 File Offset: 0x00000250
		public float SpeedPenalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600B309 RID: 45833 RVA: 0x00002050 File Offset: 0x00000250
		public float MousePenalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x0600B30A RID: 45834 RVA: 0x00002050 File Offset: 0x00000250
		public float WeaponErgonomicPenalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x00002050 File Offset: 0x00000250
		public EDeafStrength Deaf
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x00002050 File Offset: 0x00000250
		public float BluntThroughput
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x0600B30D RID: 45837 RVA: 0x00002050 File Offset: 0x00000250
		public EArmorType ArmorType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDestroyed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600B30F RID: 45839 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<EBodyPartColliderType> ArmorColliders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x00002050 File Offset: 0x00000250
		public EArmorPlateCollider ArmorPlateCollidersMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<EBodyPartColliderType> method_0(GClass2507 armorSlot)
		{
			throw null;
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private EArmorPlateCollider method_1(GClass2507 armorSlot)
		{
			throw null;
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<EArmorPlateCollider> GetArmorPlateColliders()
		{
			throw null;
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<string> method_2()
		{
			throw null;
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider)
		{
			throw null;
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Deflects(Vector3 shotDirection, Vector3 hitNormal, GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPenetrationStatus(GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ApplyDamage(ref DamageInfo damageInfo, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, bool damageInfoIsLocal, List<ArmorComponent> armorComponents, SkillManager.GClass1771 lightVestsDamageReduction, SkillManager.GClass1771 heavyVestsDamageReduction)
		{
			throw null;
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryShatter(Player damageSource, bool damageInfoIsLocal = true)
		{
			throw null;
		}

		// Token: 0x1400028D RID: 653
		// (add) Token: 0x0600B31A RID: 45850 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B31B RID: 45851 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<string, float, List<ArmorComponent>> OnDurabilityChanged
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

		// Token: 0x0600B31C RID: 45852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDurabilityDamage(float armorDamage, List<ArmorComponent> armorComponents)
		{
			throw null;
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ApplyExplosionDurabilityDamage(float armorDamage, DamageInfo damageInfo, List<ArmorComponent> armorComponents)
		{
			throw null;
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(DamageInfo damageInfo, float modifiedArmorDamage)
		{
			throw null;
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400B77F RID: 46975
		public readonly GInterface280 Template;

		// Token: 0x0400B780 RID: 46976
		public readonly RepairableComponent Repairable;

		// Token: 0x0400B781 RID: 46977
		public readonly BuffComponent Buff;

		// Token: 0x0400B782 RID: 46978
		[CompilerGenerated]
		private static Action<string, float, List<ArmorComponent>> action_0;

		// Token: 0x02002252 RID: 8786
		[CompilerGenerated]
		private sealed class Class1935
		{
			// Token: 0x0600B32B RID: 45867 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0600B32C RID: 45868 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x0600B32D RID: 45869 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_2()
			{
				throw null;
			}

			// Token: 0x0600B32E RID: 45870 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3()
			{
				throw null;
			}

			// Token: 0x0600B32F RID: 45871 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_4()
			{
				throw null;
			}

			// Token: 0x0600B330 RID: 45872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5()
			{
				throw null;
			}

			// Token: 0x0600B331 RID: 45873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_6()
			{
				throw null;
			}

			// Token: 0x0400B791 RID: 46993
			public ArmorComponent armorComponent_0;

			// Token: 0x0400B792 RID: 46994
			public Item item;
		}

		// Token: 0x02002253 RID: 8787
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1936
		{
			// Token: 0x0600B332 RID: 45874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x0600B333 RID: 45875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_1()
			{
				throw null;
			}

			// Token: 0x0600B334 RID: 45876 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_2()
			{
				throw null;
			}

			// Token: 0x0600B335 RID: 45877 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(EArmorPlateCollider apc)
			{
				throw null;
			}

			// Token: 0x0600B336 RID: 45878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_4(EBodyPartColliderType ac)
			{
				throw null;
			}

			// Token: 0x0600B337 RID: 45879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(string zone)
			{
				throw null;
			}

			// Token: 0x0600B338 RID: 45880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_6(EBodyPartColliderType x)
			{
				throw null;
			}

			// Token: 0x0400B793 RID: 46995
			public static readonly ArmorComponent.Class1936 class1936_0;

			// Token: 0x0400B794 RID: 46996
			public static Func<CompositeArmorComponent, string> func_0;

			// Token: 0x0400B795 RID: 46997
			public static Func<EItemAttributeDisplayType> func_1;

			// Token: 0x0400B796 RID: 46998
			public static Func<EItemAttributeDisplayType> func_2;

			// Token: 0x0400B797 RID: 46999
			public static Func<EArmorPlateCollider, string> func_3;

			// Token: 0x0400B798 RID: 47000
			public static Func<EBodyPartColliderType, string> func_4;

			// Token: 0x0400B799 RID: 47001
			public static Func<string, string> func_5;

			// Token: 0x0400B79A RID: 47002
			public static Func<EBodyPartColliderType, string> func_6;
		}
	}
}
