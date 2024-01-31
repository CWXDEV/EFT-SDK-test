using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace ChartAndGraph
{
	// Token: 0x0200316E RID: 12654
	[ExecuteInEditMode]
	public abstract class GraphChartBase : AxisChart, ISerializationCallbackReceiver
	{
		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600F8BB RID: 63675 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8BC RID: 63676 RVA: 0x00002050 File Offset: 0x00000250
		public float HeightRatio
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

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600F8BD RID: 63677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8BE RID: 63678 RVA: 0x00002050 File Offset: 0x00000250
		public float WidthRatio
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

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600F8BF RID: 63679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8C0 RID: 63680 RVA: 0x00002050 File Offset: 0x00000250
		public bool Scrollable
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

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600F8C1 RID: 63681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8C2 RID: 63682 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoScrollHorizontally
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

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600F8C3 RID: 63683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8C4 RID: 63684 RVA: 0x00002050 File Offset: 0x00000250
		public double HorizontalScrolling
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

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600F8C5 RID: 63685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8C6 RID: 63686 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoScrollVertically
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

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600F8C7 RID: 63687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8C8 RID: 63688 RVA: 0x00002050 File Offset: 0x00000250
		public double VerticalScrolling
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

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600F8C9 RID: 63689 RVA: 0x00002050 File Offset: 0x00000250
		public GraphData DataSource
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override double GetScrollOffset(int axis)
		{
			throw null;
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Data_InternalRealTimeDataChanged(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Data_InternalDataChanged(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnLabelSettingChanged()
		{
			throw null;
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnAxisValuesChanged()
		{
			throw null;
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnLabelSettingsSet()
		{
			throw null;
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GClass3392 interpolateInRect(Rect rect, AchievementModelClass point)
		{
			throw null;
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GClass3392 TransformPoint(Rect viewRect, Vector3 point, GStruct417 min, GStruct417 range)
		{
			throw null;
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(AchievementModelClass point, ref double minX, ref double minY, ref double maxX, ref double maxY)
		{
			throw null;
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Rect method_5(Rect completeRect, Rect lineRect)
		{
			throw null;
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected int ClipPoints(IList<AchievementModelClass> points, List<GClass3392> res, out Rect uv)
		{
			throw null;
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TransformPoints(IList<AchievementModelClass> points, Rect viewRect, AchievementModelClass min, AchievementModelClass max)
		{
			throw null;
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TransformPoints(IList<GClass3392> points, List<Vector4> output, Rect viewRect, AchievementModelClass min, AchievementModelClass max)
		{
			throw null;
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ValidateProperties()
		{
			throw null;
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600F8DC RID: 63708 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool SupportsCategoryLabels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600F8DD RID: 63709 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool SupportsGroupLables
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600F8DE RID: 63710 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool SupportsItemLabels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600F8DF RID: 63711 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TotalHeightLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600F8E0 RID: 63712 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TotalWidthLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GenerateRealtime()
		{
			throw null;
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600F8E2 RID: 63714 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TotalDepthLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool HasValues(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override double MaxValue(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override double MinValue(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnItemHoverted(object userData)
		{
			throw null;
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected string StringFromAxisFormat(double val, AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected string StringFromAxisFormat(double val, AxisBase axis, int fractionDigits)
		{
			throw null;
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnItemSelected(object userData)
		{
			throw null;
		}

		// Token: 0x0400FD83 RID: 64899
		[SerializeField]
		protected float heightRatio;

		// Token: 0x0400FD84 RID: 64900
		[SerializeField]
		protected float widthRatio;

		// Token: 0x0400FD85 RID: 64901
		public GraphChartBase.GraphEvent PointClicked;

		// Token: 0x0400FD86 RID: 64902
		public GraphChartBase.GraphEvent PointHovered;

		// Token: 0x0400FD87 RID: 64903
		public UnityEvent NonHovered;

		// Token: 0x0400FD88 RID: 64904
		[SerializeField]
		private bool scrollable;

		// Token: 0x0400FD89 RID: 64905
		[HideInInspector]
		[SerializeField]
		private bool autoScrollHorizontally;

		// Token: 0x0400FD8A RID: 64906
		[HideInInspector]
		[SerializeField]
		private double horizontalScrolling;

		// Token: 0x0400FD8B RID: 64907
		[HideInInspector]
		[SerializeField]
		private bool autoScrollVertically;

		// Token: 0x0400FD8C RID: 64908
		[SerializeField]
		[HideInInspector]
		private double verticalScrolling;

		// Token: 0x0400FD8D RID: 64909
		[SerializeField]
		[HideInInspector]
		protected GraphData Data;

		// Token: 0x0200316F RID: 12655
		public class GClass3394
		{
			// Token: 0x17002AFB RID: 11003
			// (get) Token: 0x0600F8EC RID: 63724 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8ED RID: 63725 RVA: 0x00002050 File Offset: 0x00000250
			public float Magnitude
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002AFC RID: 11004
			// (get) Token: 0x0600F8EE RID: 63726 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8EF RID: 63727 RVA: 0x00002050 File Offset: 0x00000250
			public int Index
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002AFD RID: 11005
			// (get) Token: 0x0600F8F0 RID: 63728 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8F1 RID: 63729 RVA: 0x00002050 File Offset: 0x00000250
			public string XString
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002AFE RID: 11006
			// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8F3 RID: 63731 RVA: 0x00002050 File Offset: 0x00000250
			public string YString
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002AFF RID: 11007
			// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8F5 RID: 63733 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 Position
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002B00 RID: 11008
			// (get) Token: 0x0600F8F6 RID: 63734 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8F7 RID: 63735 RVA: 0x00002050 File Offset: 0x00000250
			public GStruct417 Value
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17002B01 RID: 11009
			// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F8F9 RID: 63737 RVA: 0x00002050 File Offset: 0x00000250
			public string Category
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x0400FD8E RID: 64910
			[CompilerGenerated]
			private float float_0;

			// Token: 0x0400FD8F RID: 64911
			[CompilerGenerated]
			private int int_0;

			// Token: 0x0400FD90 RID: 64912
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400FD91 RID: 64913
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400FD92 RID: 64914
			[CompilerGenerated]
			private Vector3 vector3_0;

			// Token: 0x0400FD93 RID: 64915
			[CompilerGenerated]
			private GStruct417 gstruct417_0;

			// Token: 0x0400FD94 RID: 64916
			[CompilerGenerated]
			private string string_2;
		}

		// Token: 0x02003170 RID: 12656
		[Serializable]
		public class GraphEvent : UnityEvent<GraphChartBase.GClass3394>
		{
		}
	}
}
