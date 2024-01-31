using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.ProfileEditor.UI
{
	// Token: 0x02001DA3 RID: 7587
	[UsedImplicitly]
	public sealed class DressItemPanel : UIElement
	{
		// Token: 0x06009C6C RID: 40044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EBodyModelPart part, ResourceKey current, GClass2933[] clothes, Action<GClass2933, ResourceKey> onPartChanged)
		{
			throw null;
		}

		// Token: 0x0400A3AC RID: 41900
		[SerializeField]
		private DropDownBox _dropDown;

		// Token: 0x0400A3AD RID: 41901
		[SerializeField]
		private TMP_Text _caption;

		// Token: 0x0400A3AE RID: 41902
		private Dictionary<ResourceKey, GClass2933> dictionary_0;

		// Token: 0x02001DA4 RID: 7588
		[CompilerGenerated]
		private sealed class Class1771
		{
			// Token: 0x06009C6D RID: 40045 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0400A3AF RID: 41903
			public DressItemPanel dressItemPanel_0;

			// Token: 0x0400A3B0 RID: 41904
			public List<ResourceKey> options;

			// Token: 0x0400A3B1 RID: 41905
			public Action<GClass2933, ResourceKey> onPartChanged;
		}

		// Token: 0x02001DA5 RID: 7589
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1772
		{
			// Token: 0x06009C6E RID: 40046 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(ResourceKey x)
			{
				throw null;
			}

			// Token: 0x0400A3B2 RID: 41906
			public static readonly DressItemPanel.Class1772 class1772_0;

			// Token: 0x0400A3B3 RID: 41907
			public static Func<ResourceKey, string> func_0;
		}
	}
}
