using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Console.Core;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002892 RID: 10386
	public class ConsoleAutoCompletePanel : MonoBehaviour
	{
		// Token: 0x140002DE RID: 734
		// (add) Token: 0x0600CF46 RID: 53062 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CF47 RID: 53063 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<AutoCompleteItem> OnSelect
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

		// Token: 0x0600CF48 RID: 53064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateList(AutoCompleteItem[] items)
		{
			throw null;
		}

		// Token: 0x0600CF4A RID: 53066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400D034 RID: 53300
		private const int int_0 = 30;

		// Token: 0x0400D035 RID: 53301
		[SerializeField]
		private GameObject _container;

		// Token: 0x0400D036 RID: 53302
		[SerializeField]
		private ConsoleAutoCompleteItem _prefabItem;

		// Token: 0x0400D037 RID: 53303
		[SerializeField]
		private GameObject _documentationContainer;

		// Token: 0x0400D038 RID: 53304
		[SerializeField]
		private TMP_Text _documentation;

		// Token: 0x0400D039 RID: 53305
		[CompilerGenerated]
		private Action<AutoCompleteItem> action_0;

		// Token: 0x0400D03A RID: 53306
		private int int_1;

		// Token: 0x0400D03B RID: 53307
		private List<ValueTuple<AutoCompleteItem, ConsoleAutoCompleteItem>> list_0;
	}
}
