using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002274 RID: 8820
	public sealed class FoldableComponent : GClass2750
	{
		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600B3C4 RID: 46020 RVA: 0x00002050 File Offset: 0x00000250
		public int SizeReduceRight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanBeFolded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFolded(bool value)
		{
			throw null;
		}

		// Token: 0x0400B800 RID: 47104
		[CanBeNull]
		public readonly Slot FoldedSlot;

		// Token: 0x0400B801 RID: 47105
		public bool Folded;

		// Token: 0x0400B802 RID: 47106
		[NonSerialized]
		public readonly BindableEvent OnChanged;

		// Token: 0x0400B803 RID: 47107
		private readonly GInterface286 ginterface286_0;

		// Token: 0x02002275 RID: 8821
		[CompilerGenerated]
		private sealed class Class1948
		{
			// Token: 0x0600B3C7 RID: 46023 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot x)
			{
				throw null;
			}

			// Token: 0x0400B804 RID: 47108
			public GInterface286 template;
		}
	}
}
