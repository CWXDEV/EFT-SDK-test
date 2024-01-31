using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003132 RID: 12594
	[Serializable]
	public abstract class AbstractChartData
	{
		// Token: 0x0600F6C2 RID: 63170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RemoveSliderForGroup(string group)
		{
			throw null;
		}

		// Token: 0x0600F6C3 RID: 63171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RemoveSliderForCategory(string category)
		{
			throw null;
		}

		// Token: 0x0600F6C4 RID: 63172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RemoveSlider(string category, string group)
		{
			throw null;
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(AbstractChartData.Slider s)
		{
			throw null;
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateSliders()
		{
			throw null;
		}

		// Token: 0x0600F6C7 RID: 63175
		protected abstract void SetValueInternal(string column, string row, double value);

		// Token: 0x0400FC51 RID: 64593
		protected List<AbstractChartData.Slider> mSliders;

		// Token: 0x02003133 RID: 12595
		protected class Slider
		{
			// Token: 0x0600F6C8 RID: 63176 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool UpdateSlider(AbstractChartData data)
			{
				throw null;
			}

			// Token: 0x0400FC52 RID: 64594
			public string category;

			// Token: 0x0400FC53 RID: 64595
			public string group;

			// Token: 0x0400FC54 RID: 64596
			public double from;

			// Token: 0x0400FC55 RID: 64597
			public double to;

			// Token: 0x0400FC56 RID: 64598
			public float startTime;

			// Token: 0x0400FC57 RID: 64599
			public float totalTime;

			// Token: 0x0400FC58 RID: 64600
			public float timeScale;

			// Token: 0x0400FC59 RID: 64601
			public AnimationCurve curve;
		}

		// Token: 0x02003134 RID: 12596
		[CompilerGenerated]
		private sealed class Class3183
		{
			// Token: 0x0600F6C9 RID: 63177 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AbstractChartData.Slider x)
			{
				throw null;
			}

			// Token: 0x0400FC5A RID: 64602
			public string group;
		}

		// Token: 0x02003135 RID: 12597
		[CompilerGenerated]
		private sealed class Class3184
		{
			// Token: 0x0600F6CA RID: 63178 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AbstractChartData.Slider x)
			{
				throw null;
			}

			// Token: 0x0400FC5B RID: 64603
			public string category;
		}

		// Token: 0x02003136 RID: 12598
		[CompilerGenerated]
		private sealed class Class3185
		{
			// Token: 0x0600F6CB RID: 63179 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AbstractChartData.Slider x)
			{
				throw null;
			}

			// Token: 0x0400FC5C RID: 64604
			public string category;

			// Token: 0x0400FC5D RID: 64605
			public string group;
		}
	}
}
