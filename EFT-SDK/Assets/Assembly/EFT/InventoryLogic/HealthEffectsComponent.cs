using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;

namespace EFT.InventoryLogic
{
	// Token: 0x02002282 RID: 8834
	public sealed class HealthEffectsComponent : StimulatorBuffsComponent
	{
		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600B3D8 RID: 46040 RVA: 0x00002050 File Offset: 0x00000250
		public float UseTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600B3D9 RID: 46041 RVA: 0x00002050 File Offset: 0x00000250
		public KeyValuePair<EBodyPart, float>[] BodyPartTimeMults
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EHealthFactorType, GClass1233> HealthEffects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600B3DB RID: 46043 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EDamageEffectType, GClass1232> DamageEffects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AffectsAny(params EDamageEffectType[] effectTypes)
		{
			throw null;
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float UseTimeFor(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0()
		{
			throw null;
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_1()
		{
			throw null;
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(EDamageEffectType type)
		{
			throw null;
		}

		// Token: 0x0400B818 RID: 47128
		private readonly GInterface290 ginterface290_0;

		// Token: 0x02002283 RID: 8835
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1952
		{
			// Token: 0x0600B3E2 RID: 46050 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0400B819 RID: 47129
			public static readonly HealthEffectsComponent.Class1952 class1952_0;

			// Token: 0x0400B81A RID: 47130
			public static Func<EItemAttributeDisplayType> func_0;
		}
	}
}
