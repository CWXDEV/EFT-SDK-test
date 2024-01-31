using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003183 RID: 12675
	[RequireComponent(typeof(AnyChart))]
	[ExecuteInEditMode]
	public abstract class ChartSettingItemBase : MonoBehaviour, IInternalSettings
	{
		// Token: 0x140003B0 RID: 944
		// (add) Token: 0x0600F9C4 RID: 63940 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F9C5 RID: 63941 RVA: 0x00002050 File Offset: 0x00000250
		private event EventHandler Event_0
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

		// Token: 0x140003B1 RID: 945
		// (add) Token: 0x0600F9C6 RID: 63942 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F9C7 RID: 63943 RVA: 0x00002050 File Offset: 0x00000250
		private event EventHandler Event_1
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

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600F9C8 RID: 63944
		protected abstract Action<IInternalUse, bool> Assign { get; }

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600F9C9 RID: 63945 RVA: 0x00002050 File Offset: 0x00000250
		private AnyChart AnyChart_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void AddInnerItem(IInternalSettings item)
		{
			throw null;
		}

		// Token: 0x0600F9CB RID: 63947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F9CC RID: 63948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600F9CD RID: 63949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RaiseOnChanged()
		{
			throw null;
		}

		// Token: 0x0600F9CE RID: 63950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RaiseOnUpdate()
		{
			throw null;
		}

		// Token: 0x0600F9CF RID: 63951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool clear)
		{
			throw null;
		}

		// Token: 0x0600F9D0 RID: 63952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F9D1 RID: 63953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F9D2 RID: 63954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestory()
		{
			throw null;
		}

		// Token: 0x0600F9D3 RID: 63955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600F9D4 RID: 63956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x140003B2 RID: 946
		// (add) Token: 0x0600F9D5 RID: 63957 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F9D6 RID: 63958 RVA: 0x00002050 File Offset: 0x00000250
		event EventHandler IInternalSettings.InternalOnDataUpdate
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

		// Token: 0x140003B3 RID: 947
		// (add) Token: 0x0600F9D7 RID: 63959 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F9D8 RID: 63960 RVA: 0x00002050 File Offset: 0x00000250
		event EventHandler IInternalSettings.InternalOnDataChanged
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

		// Token: 0x0400FDFA RID: 65018
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400FDFB RID: 65019
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x0400FDFC RID: 65020
		private AnyChart anyChart_0;
	}
}
