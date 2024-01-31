using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029B9 RID: 10681
	public class CompactCharacteristicPanel : UIElement
	{
		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600D488 RID: 54408 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D489 RID: 54409 RVA: 0x00002050 File Offset: 0x00000250
		public float TextWidth
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

		// Token: 0x140002E9 RID: 745
		// (add) Token: 0x0600D48A RID: 54410 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D48B RID: 54411 RVA: 0x00002050 File Offset: 0x00000250
		public event EventHandler OnTextWidthCalculated
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

		// Token: 0x0600D48C RID: 54412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D48E RID: 54414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemAttributeClass itemAttribute, SimpleTooltip tooltip, bool examined = true, int peakDurability = 100)
		{
			throw null;
		}

		// Token: 0x0600D48F RID: 54415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CompareWith(ItemAttributeClass attribute)
		{
			throw null;
		}

		// Token: 0x0600D490 RID: 54416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetValues()
		{
			throw null;
		}

		// Token: 0x0600D491 RID: 54417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D492 RID: 54418 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600D494 RID: 54420 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D495 RID: 54421 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400D6D7 RID: 54999
		[SerializeField]
		protected Image Icon;

		// Token: 0x0400D6D8 RID: 55000
		[SerializeField]
		protected TextMeshProUGUI NameText;

		// Token: 0x0400D6D9 RID: 55001
		[SerializeField]
		protected TextMeshProUGUI ValueText;

		// Token: 0x0400D6DA RID: 55002
		[SerializeField]
		private Color _increasingColor;

		// Token: 0x0400D6DB RID: 55003
		[SerializeField]
		private Color _decreasingColor;

		// Token: 0x0400D6DC RID: 55004
		protected SimpleTooltip Tooltip;

		// Token: 0x0400D6DD RID: 55005
		protected ItemAttributeClass ItemAttribute;

		// Token: 0x0400D6DE RID: 55006
		protected ItemAttributeClass CompareItemAttribute;

		// Token: 0x0400D6DF RID: 55007
		protected int PeakDurability;

		// Token: 0x0400D6E0 RID: 55008
		protected bool Examined;

		// Token: 0x0400D6E1 RID: 55009
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400D6E2 RID: 55010
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400D6E3 RID: 55011
		private string string_0;

		// Token: 0x0400D6E4 RID: 55012
		private GClass764 gclass764_0;
	}
}
