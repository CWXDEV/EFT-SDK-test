using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003137 RID: 12599
	[Serializable]
	public abstract class AnyChart : MonoBehaviour, IInternalUse
	{
		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600F6CC RID: 63180 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<int, string> VerticalValueToStringMap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600F6CD RID: 63181 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<int, string> HorizontalValueToStringMap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600F6CE RID: 63182 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual Camera TextCameraLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600F6CF RID: 63183 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual float TextIdleDistanceLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600F6D0 RID: 63184 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6D1 RID: 63185 RVA: 0x00002050 File Offset: 0x00000250
		public bool KeepOrthoSize
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

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600F6D2 RID: 63186 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6D3 RID: 63187 RVA: 0x00002050 File Offset: 0x00000250
		public bool VRSpaceText
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

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600F6D4 RID: 63188 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6D5 RID: 63189 RVA: 0x00002050 File Offset: 0x00000250
		public float VRSpaceScale
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

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600F6D6 RID: 63190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6D7 RID: 63191 RVA: 0x00002050 File Offset: 0x00000250
		private bool IsUnderCanvas
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600F6D8 RID: 63192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6D9 RID: 63193 RVA: 0x00002050 File Offset: 0x00000250
		private bool CanvasChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mHorizontalAxis_InternalOnDataUpdate(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F6DB RID: 63195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPropertyUpdated()
		{
			throw null;
		}

		// Token: 0x0600F6DC RID: 63196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mGroupLabels_InternalOnDataChanged(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F6DD RID: 63197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mGroupLabels_InternalOnDataUpdate(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F6DE RID: 63198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnLabelSettingChanged()
		{
			throw null;
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600F6DF RID: 63199
		protected abstract float TotalDepthLink { get; }

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600F6E0 RID: 63200
		protected abstract float TotalHeightLink { get; }

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600F6E1 RID: 63201
		protected abstract float TotalWidthLink { get; }

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual double GetScrollOffset(int axis)
		{
			throw null;
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600F6E3 RID: 63203 RVA: 0x00002050 File Offset: 0x00000250
		bool IInternalUse.HideHierarchy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnAxisValuesChanged()
		{
			throw null;
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnLabelSettingsSet()
		{
			throw null;
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool start)
		{
			throw null;
		}

		// Token: 0x0600F6E8 RID: 63208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F6E9 RID: 63209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600F6EA RID: 63210 RVA: 0x00002050 File Offset: 0x00000250
		protected bool Invalidating
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Invalidate()
		{
			throw null;
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnValidate()
		{
			throw null;
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600F6EF RID: 63215 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6F0 RID: 63216 RVA: 0x00002050 File Offset: 0x00000250
		private TextController TextController
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600F6F1 RID: 63217
		protected abstract bool HasValues(AxisBase axis);

		// Token: 0x0600F6F2 RID: 63218
		protected abstract double MaxValue(AxisBase axis);

		// Token: 0x0600F6F3 RID: 63219
		protected abstract double MinValue(AxisBase axis);

		// Token: 0x0600F6F4 RID: 63220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F6F5 RID: 63221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GenerateChart()
		{
			throw null;
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InternalGenerateChart()
		{
			throw null;
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ClearChart()
		{
			throw null;
		}

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnNonHoverted()
		{
			throw null;
		}

		// Token: 0x0600F6FA RID: 63226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnItemLeave(object userData)
		{
			throw null;
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnItemSelected(object userData)
		{
			throw null;
		}

		// Token: 0x0600F6FC RID: 63228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnItemHoverted(object userData)
		{
			throw null;
		}

		// Token: 0x0600F6FD RID: 63229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal virtual GInterface398 InternalUpdateAxis(ref GameObject axisObject, AxisBase axisBase, ChartOrientation axisOrientation, bool isSubDiv, bool forceRecreate, double scrollOffset)
		{
			throw null;
		}

		// Token: 0x0600F6FE RID: 63230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ValidateProperties()
		{
			throw null;
		}

		// Token: 0x0600F6FF RID: 63231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void GenerateAxis(bool force)
		{
			throw null;
		}

		// Token: 0x1400039A RID: 922
		// (add) Token: 0x0600F700 RID: 63232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F701 RID: 63233 RVA: 0x00002050 File Offset: 0x00000250
		private event Action Event_0
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

		// Token: 0x1400039B RID: 923
		// (add) Token: 0x0600F702 RID: 63234 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F703 RID: 63235 RVA: 0x00002050 File Offset: 0x00000250
		event Action IInternalUse.Generated
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600F704 RID: 63236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInternalUse.InternalItemSelected(object userData)
		{
			throw null;
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInternalUse.InternalItemLeave(object userData)
		{
			throw null;
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInternalUse.InternalItemHovered(object userData)
		{
			throw null;
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IInternalUse.CallOnValidate()
		{
			throw null;
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600F708 RID: 63240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F709 RID: 63241 RVA: 0x00002050 File Offset: 0x00000250
		ItemLabels IInternalUse.ItemLabels
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

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600F70A RID: 63242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F70B RID: 63243 RVA: 0x00002050 File Offset: 0x00000250
		VerticalAxis IInternalUse.VerticalAxis
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

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600F70C RID: 63244 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F70D RID: 63245 RVA: 0x00002050 File Offset: 0x00000250
		HorizontalAxis IInternalUse.HorizontalAxis
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

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600F70E RID: 63246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F70F RID: 63247 RVA: 0x00002050 File Offset: 0x00000250
		CategoryLabels IInternalUse.CategoryLabels
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

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600F710 RID: 63248 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F711 RID: 63249 RVA: 0x00002050 File Offset: 0x00000250
		GroupLabels IInternalUse.GroupLabels
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

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600F712 RID: 63250 RVA: 0x00002050 File Offset: 0x00000250
		TextController IInternalUse.InternalTextController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600F713 RID: 63251 RVA: 0x00002050 File Offset: 0x00000250
		Camera IInternalUse.InternalTextCamera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600F714 RID: 63252 RVA: 0x00002050 File Offset: 0x00000250
		float IInternalUse.InternalTextIdleDistance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IInternalUse.InternalHasValues(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		double IInternalUse.InternalMaxValue(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		double IInternalUse.InternalMinValue(AxisBase axis)
		{
			throw null;
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600F718 RID: 63256 RVA: 0x00002050 File Offset: 0x00000250
		float IInternalUse.InternalTotalDepth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600F719 RID: 63257 RVA: 0x00002050 File Offset: 0x00000250
		float IInternalUse.InternalTotalWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600F71A RID: 63258 RVA: 0x00002050 File Offset: 0x00000250
		float IInternalUse.InternalTotalHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600F71B RID: 63259
		protected abstract bool SupportsCategoryLabels { get; }

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600F71C RID: 63260
		protected abstract bool SupportsItemLabels { get; }

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600F71D RID: 63261
		protected abstract bool SupportsGroupLables { get; }

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600F71E RID: 63262 RVA: 0x00002050 File Offset: 0x00000250
		bool IInternalUse.InternalSupportsCategoryLables
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600F71F RID: 63263 RVA: 0x00002050 File Offset: 0x00000250
		bool IInternalUse.InternalSupportsGroupLabels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600F720 RID: 63264 RVA: 0x00002050 File Offset: 0x00000250
		bool IInternalUse.InternalSupportsItemLabels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400FC5E RID: 64606
		private bool mGenerating;

		// Token: 0x0400FC5F RID: 64607
		private Dictionary<int, string> mHorizontalValueToStringMap;

		// Token: 0x0400FC60 RID: 64608
		private Dictionary<int, string> mVerticalValueToStringMap;

		// Token: 0x0400FC61 RID: 64609
		[SerializeField]
		private bool keepOrthoSize;

		// Token: 0x0400FC62 RID: 64610
		[SerializeField]
		private bool vRSpaceText;

		// Token: 0x0400FC63 RID: 64611
		[SerializeField]
		private float vRSpaceScale;

		// Token: 0x0400FC64 RID: 64612
		private HashSet<object> mHovered;

		// Token: 0x0400FC67 RID: 64615
		protected ItemLabels mItemLabels;

		// Token: 0x0400FC68 RID: 64616
		protected VerticalAxis mVerticalAxis;

		// Token: 0x0400FC69 RID: 64617
		protected HorizontalAxis mHorizontalAxis;

		// Token: 0x0400FC6A RID: 64618
		protected CategoryLabels mCategoryLabels;

		// Token: 0x0400FC6B RID: 64619
		protected GroupLabels mGroupLabels;

		// Token: 0x0400FC6C RID: 64620
		protected GameObject VerticalMainDevisions;

		// Token: 0x0400FC6D RID: 64621
		protected GameObject VerticalSubDevisions;

		// Token: 0x0400FC6E RID: 64622
		protected GameObject HorizontalMainDevisions;

		// Token: 0x0400FC6F RID: 64623
		protected GameObject HorizontalSubDevisions;

		// Token: 0x0400FC70 RID: 64624
		private bool mGenerateOnNextUpdate;

		// Token: 0x0400FC71 RID: 64625
		protected bool hideHierarchy;

		// Token: 0x0400FC72 RID: 64626
		private List<GInterface398> mAxis;

		// Token: 0x0400FC74 RID: 64628
		[CompilerGenerated]
		private Action ChartGenerated;
	}
}
