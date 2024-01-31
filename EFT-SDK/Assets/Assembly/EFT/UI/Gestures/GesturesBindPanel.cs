using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA8 RID: 11944
	public sealed class GesturesBindPanel : UIElement
	{
		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600EBC0 RID: 60352 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyList<GesturesBindItem> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3175 binds, ColorMap colorMap, HashSet<EPhraseTrigger> availablePhrases)
		{
			throw null;
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GestureBaseItem.GStruct399 click)
		{
			throw null;
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400F0D6 RID: 61654
		[SerializeField]
		private GesturesBindItem _leftTemplate;

		// Token: 0x0400F0D7 RID: 61655
		[SerializeField]
		private GesturesBindItem _rightTemplate;

		// Token: 0x0400F0D8 RID: 61656
		[SerializeField]
		private RectTransform _leftContainer;

		// Token: 0x0400F0D9 RID: 61657
		[SerializeField]
		private RectTransform _rightContainer;

		// Token: 0x0400F0DA RID: 61658
		[NonSerialized]
		public readonly GClass3355<int> OnItemSelected;

		// Token: 0x0400F0DB RID: 61659
		private readonly List<GesturesBindItem> list_0;
	}
}
