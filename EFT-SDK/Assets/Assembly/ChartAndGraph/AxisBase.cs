using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace ChartAndGraph
{
	// Token: 0x0200313C RID: 12604
	public abstract class AxisBase : ChartSettingItemBase, ISerializationCallbackReceiver
	{
		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600F723 RID: 63267 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F724 RID: 63268 RVA: 0x00002050 File Offset: 0x00000250
		public AxisFormat Format
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

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600F725 RID: 63269 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F726 RID: 63270 RVA: 0x00002050 File Offset: 0x00000250
		public AutoFloat Depth
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

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600F727 RID: 63271 RVA: 0x00002050 File Offset: 0x00000250
		public ChartDivisionInfo MainDivisions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x00002050 File Offset: 0x00000250
		public ChartDivisionInfo SubDivisions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F729 RID: 63273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600F72A RID: 63274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ValidateProperties()
		{
			throw null;
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(AnyChart parent, ChartOrientation orientation, float total, out float start, out float end)
		{
			throw null;
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Interface21 mesh, float length, float offset)
		{
			throw null;
		}

		// Token: 0x0600F72D RID: 63277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(double scrollOffset, AnyChart parent, Transform parentTransform, ChartDivisionInfo info, Interface21 mesh, int group, ChartOrientation orientation, double gap, bool oppositeSide, double mainGap)
		{
			throw null;
		}

		// Token: 0x0600F72E RID: 63278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(AnyChart parent, ChartDivisionInfo info, ChartOrientation orientation, float scrollOffset, bool oppositeSide, out AchievementModelClass startPosition, out AchievementModelClass lengthDirection, out AchievementModelClass advanceDirection)
		{
			throw null;
		}

		// Token: 0x0600F72F RID: 63279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_8(double scrollOffset, AnyChart parent, Transform parentTransform, Interface21 mesh, ChartOrientation orientation)
		{
			throw null;
		}

		// Token: 0x0600F730 RID: 63280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private double? method_9(AnyChart parent, double range)
		{
			throw null;
		}

		// Token: 0x0600F731 RID: 63281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_10(double scrollOffset, AnyChart parent, Transform parentTransform, Interface21 mesh, ChartOrientation orientation)
		{
			throw null;
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0400FC77 RID: 64631
		[SerializeField]
		private bool SimpleView;

		// Token: 0x0400FC78 RID: 64632
		[Tooltip("the format of the axis labels. This can be either a number, time or date time. If the selected value is either DateTime or Time , user ChartDateUtillity to convert dates to double values that can be set to the graph")]
		[SerializeField]
		private AxisFormat format;

		// Token: 0x0400FC79 RID: 64633
		[SerializeField]
		[Tooltip("the depth of the axis reltive to the chart position")]
		private AutoFloat depth;

		// Token: 0x0400FC7A RID: 64634
		[SerializeField]
		[Tooltip("The main divisions of the chart axis")]
		[FormerlySerializedAs("MainDivisions")]
		private ChartMainDivisionInfo mainDivisions;

		// Token: 0x0400FC7B RID: 64635
		[SerializeField]
		[Tooltip("The sub divisions of each main division")]
		[FormerlySerializedAs("SubDivisions")]
		private ChartSubDivisionInfo subDivisions;

		// Token: 0x0400FC7C RID: 64636
		private Dictionary<double, string> dictionary_0;

		// Token: 0x0400FC7D RID: 64637
		private List<double> list_0;

		// Token: 0x0200313D RID: 12605
		internal class Class3186
		{
			// Token: 0x0400FC7E RID: 64638
			public ChartDivisionInfo info;

			// Token: 0x0400FC7F RID: 64639
			public float interp;

			// Token: 0x0400FC80 RID: 64640
			public int fractionDigits;
		}

		// Token: 0x0200313E RID: 12606
		[CompilerGenerated]
		private sealed class Class3187
		{
			// Token: 0x0600F734 RID: 63284 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal double method_0(double x)
			{
				throw null;
			}

			// Token: 0x0400FC81 RID: 64641
			public double startValue;

			// Token: 0x0400FC82 RID: 64642
			public double range;

			// Token: 0x0400FC83 RID: 64643
			public double parentSize;
		}
	}
}
