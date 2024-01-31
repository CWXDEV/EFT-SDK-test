using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003178 RID: 12664
	public class WorldSpaceGraphChart : GraphChartBase
	{
		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600F949 RID: 63817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F94A RID: 63818 RVA: 0x00002050 File Offset: 0x00000250
		public Camera TextCamera
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

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600F94B RID: 63819 RVA: 0x00002050 File Offset: 0x00000250
		protected override Camera TextCameraLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600F94C RID: 63820 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F94D RID: 63821 RVA: 0x00002050 File Offset: 0x00000250
		public float TextIdleDistance
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

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600F94E RID: 63822 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TextIdleDistanceLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600F94F RID: 63823 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TotalDepthLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F950 RID: 63824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPropertyUpdated()
		{
			throw null;
		}

		// Token: 0x0600F951 RID: 63825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GameObject method_6(GraphData.CategoryData data)
		{
			throw null;
		}

		// Token: 0x0600F952 RID: 63826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private FillPathGenerator method_7(GraphData.CategoryData data)
		{
			throw null;
		}

		// Token: 0x0600F953 RID: 63827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PathGenerator method_8(GraphData.CategoryData data)
		{
			throw null;
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnNonHoverted()
		{
			throw null;
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnItemHoverted(object userData)
		{
			throw null;
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(string cat, BillboardText text)
		{
			throw null;
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ClearChart()
		{
			throw null;
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void GenerateRealtime()
		{
			throw null;
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InternalGenerateChart()
		{
			throw null;
		}

		// Token: 0x0400FDDD RID: 64989
		[SerializeField]
		private float _textIdleDistance;

		// Token: 0x0400FDDE RID: 64990
		[SerializeField]
		[Tooltip("If this value is set all the text in the chart will be rendered to this specific camera. otherwise text is rendered to the main camera")]
		private Camera _textCamera;

		// Token: 0x0400FDDF RID: 64991
		private readonly Dictionary<string, List<BillboardText>> dictionary_0;

		// Token: 0x0400FDE0 RID: 64992
		private float float_0;

		// Token: 0x0400FDE1 RID: 64993
		private GameObject gameObject_0;

		// Token: 0x0400FDE2 RID: 64994
		private readonly HashSet<BillboardText> hashSet_0;

		// Token: 0x02003179 RID: 12665
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3204
		{
			// Token: 0x0600F95A RID: 63834 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector3 method_0(AchievementModelClass x)
			{
				throw null;
			}

			// Token: 0x0400FDE3 RID: 64995
			public static readonly WorldSpaceGraphChart.Class3204 class3204_0;

			// Token: 0x0400FDE4 RID: 64996
			public static Func<AchievementModelClass, Vector3> func_0;
		}
	}
}
