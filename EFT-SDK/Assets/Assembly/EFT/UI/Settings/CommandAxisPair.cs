using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Settings
{
	// Token: 0x02002D28 RID: 11560
	public class CommandAxisPair : MonoBehaviour
	{
		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E36E RID: 58222 RVA: 0x00002050 File Offset: 0x00000250
		public AxisGroup AxisGroup
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

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E370 RID: 58224 RVA: 0x00002050 File Offset: 0x00000250
		public bool Positive
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

		// Token: 0x0600E371 RID: 58225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(CustomTextMeshProUGUI uiText, int pairIndex)
		{
			throw null;
		}

		// Token: 0x0600E373 RID: 58227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(CustomTextMeshProUGUI uiText, int index)
		{
			throw null;
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ConflictIndex(InputSource input)
		{
			throw null;
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetInput(int index)
		{
			throw null;
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Color color)
		{
			throw null;
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3()
		{
			throw null;
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(AxisGroup axisGroup, bool positive)
		{
			throw null;
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400E830 RID: 59440
		[SerializeField]
		private LocalizedText _commandName;

		// Token: 0x0400E831 RID: 59441
		[SerializeField]
		private Button _keyButton;

		// Token: 0x0400E832 RID: 59442
		[SerializeField]
		private CustomTextMeshProUGUI _keyName;

		// Token: 0x0400E833 RID: 59443
		[SerializeField]
		private Button _key2Button;

		// Token: 0x0400E834 RID: 59444
		[SerializeField]
		private CustomTextMeshProUGUI _key2Name;

		// Token: 0x0400E835 RID: 59445
		[SerializeField]
		private Image _commandBackground;

		// Token: 0x0400E836 RID: 59446
		[SerializeField]
		private Image _keyBackground;

		// Token: 0x0400E837 RID: 59447
		[SerializeField]
		private Image _key2Background;

		// Token: 0x0400E838 RID: 59448
		[SerializeField]
		private Color _defaultBackgroundColor;

		// Token: 0x0400E839 RID: 59449
		[SerializeField]
		private Color _resetBackgroundColor;

		// Token: 0x0400E83A RID: 59450
		[CompilerGenerated]
		private AxisGroup axisGroup_0;

		// Token: 0x0400E83B RID: 59451
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400E83C RID: 59452
		internal Action action_0;

		// Token: 0x0400E83D RID: 59453
		internal Action<AxisGroup, InputSource, bool> action_1;
	}
}
