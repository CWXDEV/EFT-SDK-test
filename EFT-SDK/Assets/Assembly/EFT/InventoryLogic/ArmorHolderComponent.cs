using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x02002254 RID: 8788
	public class ArmorHolderComponent : GClass2750
	{
		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x00002050 File Offset: 0x00000250
		private EArmorMaterial EArmorMaterial_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600B33A RID: 45882 RVA: 0x00002050 File Offset: 0x00000250
		private EArmorType EArmorType_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600B33B RID: 45883 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<EBodyPartColliderType> IEnumerable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<EArmorPlateCollider> IEnumerable_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600B33D RID: 45885 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2629> ArmorPlates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2629> LockedArmorPlates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600B33F RID: 45887 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2629> MoveAbleArmorPlates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600B340 RID: 45888 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2507> ArmorSlots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x0600B341 RID: 45889 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2507> LockedArmorSlots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<GClass2507> MoveAbleArmorSlots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<GClass2507> method_0(ArmorHolderComponent.EArmorPlateFiltering filtering)
		{
			throw null;
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<GClass2629> method_1(ArmorHolderComponent.EArmorPlateFiltering filtering)
		{
			throw null;
		}

		// Token: 0x0400B79B RID: 47003
		private readonly GInterface280 ginterface280_0;

		// Token: 0x02002255 RID: 8789
		private enum EArmorPlateFiltering
		{
			// Token: 0x0400B79D RID: 47005
			Both,
			// Token: 0x0400B79E RID: 47006
			Locked,
			// Token: 0x0400B79F RID: 47007
			MoveAble
		}

		// Token: 0x02002256 RID: 8790
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1937
		{
			// Token: 0x0600B345 RID: 45893 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<EBodyPartColliderType> method_0(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x0600B346 RID: 45894 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<EArmorPlateCollider> method_1(CompositeArmorComponent x)
			{
				throw null;
			}

			// Token: 0x0600B347 RID: 45895 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(EBodyPartColliderType zone)
			{
				throw null;
			}

			// Token: 0x0600B348 RID: 45896 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(EArmorPlateCollider armorCollider)
			{
				throw null;
			}

			// Token: 0x0400B7A0 RID: 47008
			public static readonly ArmorHolderComponent.Class1937 class1937_0;

			// Token: 0x0400B7A1 RID: 47009
			public static Func<CompositeArmorComponent, IEnumerable<EBodyPartColliderType>> func_0;

			// Token: 0x0400B7A2 RID: 47010
			public static Func<CompositeArmorComponent, IEnumerable<EArmorPlateCollider>> func_1;

			// Token: 0x0400B7A3 RID: 47011
			public static Func<EBodyPartColliderType, string> func_2;

			// Token: 0x0400B7A4 RID: 47012
			public static Func<EArmorPlateCollider, string> func_3;
		}

		// Token: 0x02002259 RID: 8793
		[CompilerGenerated]
		private sealed class Class1940
		{
			// Token: 0x0600B354 RID: 45908 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0600B355 RID: 45909 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x0600B356 RID: 45910 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_2()
			{
				throw null;
			}

			// Token: 0x0600B357 RID: 45911 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3()
			{
				throw null;
			}

			// Token: 0x0600B358 RID: 45912 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass3093 method_4()
			{
				throw null;
			}

			// Token: 0x0600B359 RID: 45913 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_5()
			{
				throw null;
			}

			// Token: 0x0400B7B7 RID: 47031
			public ArmorHolderComponent armorHolderComponent_0;

			// Token: 0x0400B7B8 RID: 47032
			public Item item;
		}
	}
}
