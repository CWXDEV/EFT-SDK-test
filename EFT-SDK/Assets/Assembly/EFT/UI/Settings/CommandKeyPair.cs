using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Settings
{
	// Token: 0x02002D2A RID: 11562
	public sealed class CommandKeyPair : UIElement
	{
		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600E37F RID: 58239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E380 RID: 58240 RVA: 0x00002050 File Offset: 0x00000250
		public KeyGroup KeyGroup
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

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x00002050 File Offset: 0x00000250
		public bool DropdownAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E382 RID: 58242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(TMP_Text uiText, int variantIndex)
		{
			throw null;
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(TMP_Text uiText, int variantIndex)
		{
			throw null;
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int valueIndex)
		{
			throw null;
		}

		// Token: 0x0600E386 RID: 58246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Color color)
		{
			throw null;
		}

		// Token: 0x0600E387 RID: 58247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetInput(int index)
		{
			throw null;
		}

		// Token: 0x0600E388 RID: 58248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ConflictIndex(InputSource input)
		{
			throw null;
		}

		// Token: 0x0600E389 RID: 58249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5()
		{
			throw null;
		}

		// Token: 0x0600E38A RID: 58250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(int index)
		{
			throw null;
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(KeyGroup keyGroup, Dictionary<string, EPressType> pressTypes, bool interactable = true)
		{
			throw null;
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E38D RID: 58253 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600E38E RID: 58254 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0400E845 RID: 59461
		private const string string_0 = "Settings/NotSet";

		// Token: 0x0400E846 RID: 59462
		[SerializeField]
		private LocalizedText _commandName;

		// Token: 0x0400E847 RID: 59463
		[SerializeField]
		private Button _keyButton;

		// Token: 0x0400E848 RID: 59464
		[SerializeField]
		private TMP_Text _keyName;

		// Token: 0x0400E849 RID: 59465
		[SerializeField]
		private Button _key2Button;

		// Token: 0x0400E84A RID: 59466
		[SerializeField]
		private TMP_Text _key2Name;

		// Token: 0x0400E84B RID: 59467
		[SerializeField]
		private GameObject _emptyPressTypeCell;

		// Token: 0x0400E84C RID: 59468
		[SerializeField]
		private GameObject _unavailableCell;

		// Token: 0x0400E84D RID: 59469
		[SerializeField]
		private DropDownBox _typeDropdown;

		// Token: 0x0400E84E RID: 59470
		[SerializeField]
		private Image _commandBackground;

		// Token: 0x0400E84F RID: 59471
		[SerializeField]
		private Image _keyBackground;

		// Token: 0x0400E850 RID: 59472
		[SerializeField]
		private Image _key2Background;

		// Token: 0x0400E851 RID: 59473
		[SerializeField]
		private Image _pressTypeBackground;

		// Token: 0x0400E852 RID: 59474
		[SerializeField]
		private Image _unavailableBackground;

		// Token: 0x0400E853 RID: 59475
		[SerializeField]
		private Color _defaultBackgroundColor;

		// Token: 0x0400E854 RID: 59476
		[SerializeField]
		private Color _resetBackgroundColor;

		// Token: 0x0400E855 RID: 59477
		[SerializeField]
		private Color _notInteractableTextColor;

		// Token: 0x0400E856 RID: 59478
		[CompilerGenerated]
		private KeyGroup keyGroup_0;

		// Token: 0x0400E857 RID: 59479
		internal Action action_0;

		// Token: 0x0400E858 RID: 59480
		internal Func<KeyGroup, InputSource, bool, bool> func_0;

		// Token: 0x0400E859 RID: 59481
		private bool bool_0;

		// Token: 0x0400E85A RID: 59482
		private bool bool_1;

		// Token: 0x0400E85B RID: 59483
		private List<EPressType> list_0;

		// Token: 0x02002D2B RID: 11563
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2768
		{
			// Token: 0x0600E392 RID: 58258 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(InputSource variant)
			{
				throw null;
			}

			// Token: 0x0600E393 RID: 58259 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(InputSource variant)
			{
				throw null;
			}

			// Token: 0x0600E394 RID: 58260 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(InputSource keyVariant)
			{
				throw null;
			}

			// Token: 0x0400E85C RID: 59484
			public static readonly CommandKeyPair.Class2768 class2768_0;

			// Token: 0x0400E85D RID: 59485
			public static Func<InputSource, bool> func_0;

			// Token: 0x0400E85E RID: 59486
			public static Func<InputSource, bool> func_1;

			// Token: 0x0400E85F RID: 59487
			public static Func<InputSource, bool> func_2;
		}

		// Token: 0x02002D2D RID: 11565
		[CompilerGenerated]
		private sealed class Class2770
		{
			// Token: 0x0600E399 RID: 58265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(InputSource t, int i)
			{
				throw null;
			}

			// Token: 0x0400E867 RID: 59495
			public int index;
		}
	}
}
