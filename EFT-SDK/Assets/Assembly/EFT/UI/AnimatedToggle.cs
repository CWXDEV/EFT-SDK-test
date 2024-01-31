using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C20 RID: 11296
	public sealed class AnimatedToggle : Toggle
	{
		// Token: 0x1400030A RID: 778
		// (add) Token: 0x0600DEA2 RID: 56994 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DEA3 RID: 56995 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnMouseDown
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

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600DEA4 RID: 56996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DEA5 RID: 56997 RVA: 0x00002050 File Offset: 0x00000250
		public string OnTrigger
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

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600DEA6 RID: 56998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DEA7 RID: 56999 RVA: 0x00002050 File Offset: 0x00000250
		public string OffTrigger
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

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600DEAB RID: 57003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DEAC RID: 57004 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
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

		// Token: 0x0600DEAD RID: 57005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleSilent(bool value)
		{
			throw null;
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TriggerAnimation(bool value)
		{
			throw null;
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string triggerName)
		{
			throw null;
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InstantClearState()
		{
			throw null;
		}

		// Token: 0x0400E395 RID: 58261
		[SerializeField]
		private string _onTrigger;

		// Token: 0x0400E396 RID: 58262
		[SerializeField]
		private string _offTrigger;

		// Token: 0x0400E397 RID: 58263
		[CompilerGenerated]
		private Action action_0;
	}
}
