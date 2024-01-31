using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.InventoryLogic
{
	// Token: 0x020022A8 RID: 8872
	public class RepairableComponent : GClass2750, IItemComponent, IRelativeComponent
	{
		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x00002050 File Offset: 0x00000250
		public int TemplateDurability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600B455 RID: 46165 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RepairDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RepairKitDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600B457 RID: 46167 RVA: 0x00002050 File Offset: 0x00000250
		public float RelativeValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1()
		{
			throw null;
		}

		// Token: 0x0400B86C RID: 47212
		public float MaxDurability;

		// Token: 0x0400B86D RID: 47213
		public float Durability;

		// Token: 0x0400B86E RID: 47214
		private readonly GInterface299 ginterface299_0;

		// Token: 0x020022A9 RID: 8873
		[CompilerGenerated]
		private sealed class Class1961
		{
			// Token: 0x0600B45A RID: 46170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0400B86F RID: 47215
			public GClass2748 maxDurabilityAttribute;

			// Token: 0x0400B870 RID: 47216
			public RepairableComponent repairableComponent_0;
		}

		// Token: 0x020022AA RID: 8874
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1962
		{
			// Token: 0x0600B45B RID: 46171 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0600B45C RID: 46172 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_1()
			{
				throw null;
			}

			// Token: 0x0400B871 RID: 47217
			public static readonly RepairableComponent.Class1962 class1962_0;

			// Token: 0x0400B872 RID: 47218
			public static Func<EItemAttributeDisplayType> func_0;

			// Token: 0x0400B873 RID: 47219
			public static Func<EItemAttributeDisplayType> func_1;
		}
	}
}
