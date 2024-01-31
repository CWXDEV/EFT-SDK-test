using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028F6 RID: 10486
	public sealed class EffectsPanel : UIElement
	{
		// Token: 0x0600D168 RID: 53608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, EBodyPart bodyPart, SimpleTooltip tooltip)
		{
			throw null;
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectsFilter(IEnumerable<Type> effectsFilter)
		{
			throw null;
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_7(Type effect)
		{
			throw null;
		}

		// Token: 0x0600D173 RID: 53619 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8(GClass2457 variation)
		{
			throw null;
		}

		// Token: 0x0400D258 RID: 53848
		[SerializeField]
		private EffectIcon _effectIconTemplate;

		// Token: 0x0400D259 RID: 53849
		private EBodyPart ebodyPart_0;

		// Token: 0x0400D25A RID: 53850
		private IHealthController ihealthController_0;

		// Token: 0x0400D25B RID: 53851
		private GClass3357<GClass2457> gclass3357_0;

		// Token: 0x0400D25C RID: 53852
		private Dictionary<Type, Sprite> dictionary_0;

		// Token: 0x0400D25D RID: 53853
		private bool bool_0;

		// Token: 0x0400D25E RID: 53854
		private bool bool_1;

		// Token: 0x0400D25F RID: 53855
		private IEnumerable<Type> ienumerable_0;

		// Token: 0x020028F7 RID: 10487
		[CompilerGenerated]
		private sealed class Class2384
		{
			// Token: 0x0600D174 RID: 53620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass2457 effect, EffectIcon view)
			{
				throw null;
			}

			// Token: 0x0400D260 RID: 53856
			public SimpleTooltip tooltip;
		}

		// Token: 0x020028F8 RID: 10488
		[CompilerGenerated]
		private sealed class Class2385
		{
			// Token: 0x0600D175 RID: 53621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type filter)
			{
				throw null;
			}

			// Token: 0x0400D261 RID: 53857
			public Type effect;
		}

		// Token: 0x020028F9 RID: 10489
		[CompilerGenerated]
		private sealed class Class2386
		{
			// Token: 0x0600D176 RID: 53622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2457 d)
			{
				throw null;
			}

			// Token: 0x0600D177 RID: 53623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass2457 d)
			{
				throw null;
			}

			// Token: 0x0400D262 RID: 53858
			public GClass2457 newEffect;
		}

		// Token: 0x020028FA RID: 10490
		[CompilerGenerated]
		private sealed class Class2387
		{
			// Token: 0x0600D178 RID: 53624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2457 x)
			{
				throw null;
			}

			// Token: 0x0400D263 RID: 53859
			public GInterface226 activeBuff;
		}

		// Token: 0x020028FB RID: 10491
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2388
		{
			// Token: 0x0600D179 RID: 53625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IEffect effect)
			{
				throw null;
			}

			// Token: 0x0400D264 RID: 53860
			public static readonly EffectsPanel.Class2388 class2388_0;

			// Token: 0x0400D265 RID: 53861
			public static Func<IEffect, bool> func_0;
		}
	}
}
