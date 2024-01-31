using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AEB RID: 10987
	public sealed class SpecifiedContextButtons : SerializedMonoBehaviour
	{
		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x00002050 File Offset: 0x00000250
		private Dictionary<Enum, SpecifiedContextButtons.GClass3055> Dictionary_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DA3F RID: 55871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<SimpleContextMenuButton, RectTransform>? GetButton(Enum key)
		{
			throw null;
		}

		// Token: 0x0400DD36 RID: 56630
		[SerializeField]
		private List<Dictionary<Enum, SpecifiedContextButtons.GClass3055>> _buttons;

		// Token: 0x0400DD37 RID: 56631
		private Dictionary<Enum, SpecifiedContextButtons.GClass3055> dictionary_0;

		// Token: 0x02002AEC RID: 10988
		public sealed class GClass3055
		{
			// Token: 0x0400DD38 RID: 56632
			public SimpleContextMenuButton Button;

			// Token: 0x0400DD39 RID: 56633
			public RectTransform Container;
		}

		// Token: 0x02002AED RID: 10989
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2576
		{
			// Token: 0x0600DA40 RID: 55872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<KeyValuePair<Enum, SpecifiedContextButtons.GClass3055>> method_0(Dictionary<Enum, SpecifiedContextButtons.GClass3055> dict)
			{
				throw null;
			}

			// Token: 0x0600DA41 RID: 55873 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Enum method_1(KeyValuePair<Enum, SpecifiedContextButtons.GClass3055> pair)
			{
				throw null;
			}

			// Token: 0x0600DA42 RID: 55874 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal SpecifiedContextButtons.GClass3055 method_2(KeyValuePair<Enum, SpecifiedContextButtons.GClass3055> pair)
			{
				throw null;
			}

			// Token: 0x0400DD3A RID: 56634
			public static readonly SpecifiedContextButtons.Class2576 class2576_0;

			// Token: 0x0400DD3B RID: 56635
			public static Func<Dictionary<Enum, SpecifiedContextButtons.GClass3055>, IEnumerable<KeyValuePair<Enum, SpecifiedContextButtons.GClass3055>>> func_0;

			// Token: 0x0400DD3C RID: 56636
			public static Func<KeyValuePair<Enum, SpecifiedContextButtons.GClass3055>, Enum> func_1;

			// Token: 0x0400DD3D RID: 56637
			public static Func<KeyValuePair<Enum, SpecifiedContextButtons.GClass3055>, SpecifiedContextButtons.GClass3055> func_2;
		}
	}
}
