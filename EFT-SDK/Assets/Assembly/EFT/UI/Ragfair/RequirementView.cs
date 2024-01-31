using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FB8 RID: 12216
	public class RequirementView : UIElement
	{
		// Token: 0x14000363 RID: 867
		// (add) Token: 0x0600F133 RID: 61747 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F134 RID: 61748 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnQuantityChange
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

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600F135 RID: 61749 RVA: 0x00002050 File Offset: 0x00000250
		public HandoverRequirement Requirement
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F137 RID: 61751 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2884 Node
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

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600F138 RID: 61752 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F139 RID: 61753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F13A RID: 61754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2881 handbook)
		{
			throw null;
		}

		// Token: 0x0600F13B RID: 61755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRequirementInformation()
		{
			throw null;
		}

		// Token: 0x0600F13C RID: 61756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string input)
		{
			throw null;
		}

		// Token: 0x0400F737 RID: 63287
		public const int MAX_QUANTITY = 100000000;

		// Token: 0x0400F738 RID: 63288
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400F739 RID: 63289
		private static readonly NumberFormatInfo numberFormatInfo_0;

		// Token: 0x0400F73A RID: 63290
		[SerializeField]
		private Button _clearButton;

		// Token: 0x0400F73B RID: 63291
		[SerializeField]
		private ValidationInputField _inputField;

		// Token: 0x0400F73C RID: 63292
		[SerializeField]
		private ECurrencyType _currency;

		// Token: 0x0400F73D RID: 63293
		[CompilerGenerated]
		private GClass2884 gclass2884_0;

		// Token: 0x0400F73E RID: 63294
		private int int_0;
	}
}
