using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;

namespace EFT.UI.Tutorial
{
	// Token: 0x02002CCA RID: 11466
	public class KeyBannerGenerator : MonoBehaviour
	{
		// Token: 0x0600E192 RID: 57746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyBindingBannerView GetKeyBindingBanner(Transform container)
		{
			throw null;
		}

		// Token: 0x0600E193 RID: 57747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3094 method_0(KeyCode keyCode, string axisName = "")
		{
			throw null;
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3095 method_1(KeyCombination keyCombination)
		{
			throw null;
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(InputSource axisInput, List<GClass3094> keys)
		{
			throw null;
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Sprite method_3(KeyCode keyCode, string keyAlias, string axisName = "")
		{
			throw null;
		}

		// Token: 0x0400E67B RID: 59003
		public KeyBanner[] Banners;

		// Token: 0x0400E67C RID: 59004
		public KeyBindingBannerView KeyBindingBannerView;

		// Token: 0x0400E67D RID: 59005
		private readonly HashSet<KeyCode> hashSet_0;

		// Token: 0x0400E67E RID: 59006
		public Sprite KeyBig;

		// Token: 0x0400E67F RID: 59007
		public Sprite KeyComma;

		// Token: 0x0400E680 RID: 59008
		public Sprite KeyMouseBoth;

		// Token: 0x0400E681 RID: 59009
		public Sprite KeyMouseLeft;

		// Token: 0x0400E682 RID: 59010
		public Sprite KeyMouseMiddle;

		// Token: 0x0400E683 RID: 59011
		public Sprite KeyMouseRight;

		// Token: 0x0400E684 RID: 59012
		public Sprite KeyPlus;

		// Token: 0x0400E685 RID: 59013
		public Sprite KeySmall;

		// Token: 0x02002CCB RID: 11467
		[CompilerGenerated]
		private sealed class Class2740
		{
			// Token: 0x0600E197 RID: 57751 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AxisGroup e)
			{
				throw null;
			}

			// Token: 0x0400E686 RID: 59014
			public KeyCombination keyCombination;
		}

		// Token: 0x02002CCC RID: 11468
		[CompilerGenerated]
		private sealed class Class2741
		{
			// Token: 0x0600E198 RID: 57752 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyGroup e)
			{
				throw null;
			}

			// Token: 0x0400E687 RID: 59015
			public EGameKey key;
		}

		// Token: 0x02002CCD RID: 11469
		[CompilerGenerated]
		private sealed class Class2742
		{
			// Token: 0x0600E199 RID: 57753 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyGroup e)
			{
				throw null;
			}

			// Token: 0x0400E688 RID: 59016
			public EGameKey secondKey;
		}

		// Token: 0x02002CCE RID: 11470
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2743
		{
			// Token: 0x0600E19A RID: 57754 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(InputSource keyVariant)
			{
				throw null;
			}

			// Token: 0x0600E19B RID: 57755 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(InputSource keyVariant)
			{
				throw null;
			}

			// Token: 0x0600E19C RID: 57756 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(InputSource keyVariant)
			{
				throw null;
			}

			// Token: 0x0400E689 RID: 59017
			public static readonly KeyBannerGenerator.Class2743 class2743_0;

			// Token: 0x0400E68A RID: 59018
			public static Func<InputSource, bool> func_0;

			// Token: 0x0400E68B RID: 59019
			public static Func<InputSource, bool> func_1;

			// Token: 0x0400E68C RID: 59020
			public static Func<InputSource, bool> func_2;
		}
	}
}
