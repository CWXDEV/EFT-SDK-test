using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C78 RID: 11384
	[UsedImplicitly]
	public sealed class ValidationInputField : TMP_InputField
	{
		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<string> OnValidatedTextChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ValidateCurrentInput()
		{
			throw null;
		}

		// Token: 0x0600E04D RID: 57421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(string nickname)
		{
			throw null;
		}

		// Token: 0x0600E04E RID: 57422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E04F RID: 57423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ENicknameError method_3(string textValue)
		{
			throw null;
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowErrorFromCode(int errorCode)
		{
			throw null;
		}

		// Token: 0x0600E051 RID: 57425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowError(ENicknameError error)
		{
			throw null;
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideSymbolCountLabel(bool needHide)
		{
			throw null;
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowMessage(string message, bool isError)
		{
			throw null;
		}

		// Token: 0x0600E054 RID: 57428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeSelect()
		{
			throw null;
		}

		// Token: 0x0600E055 RID: 57429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(EValidationType validationType)
		{
			throw null;
		}

		// Token: 0x0600E056 RID: 57430 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E057 RID: 57431 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400E4EA RID: 58602
		private const float float_0 = 0.2f;

		// Token: 0x0400E4EB RID: 58603
		private static readonly ValidationInputField.Struct939[] struct939_0;

		// Token: 0x0400E4EC RID: 58604
		private GClass3355<string> gclass3355_0;

		// Token: 0x0400E4ED RID: 58605
		[SerializeField]
		private TextMeshProUGUI _errorLabel;

		// Token: 0x0400E4EE RID: 58606
		[SerializeField]
		private LocalizedText _usedSymbolsCount;

		// Token: 0x0400E4EF RID: 58607
		[SerializeField]
		private Color _usedSymbolsColor;

		// Token: 0x0400E4F0 RID: 58608
		[SerializeField]
		private Color _outOfRangeColor;

		// Token: 0x0400E4F1 RID: 58609
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400E4F2 RID: 58610
		[SerializeField]
		private EValidationType _validationType;

		// Token: 0x0400E4F3 RID: 58611
		[SerializeField]
		private int _minCharsCount;

		// Token: 0x0400E4F4 RID: 58612
		[SerializeField]
		private int _maxDigitsCount;

		// Token: 0x0400E4F5 RID: 58613
		private readonly Regex regex_0;

		// Token: 0x0400E4F6 RID: 58614
		private Regex regex_1;

		// Token: 0x0400E4F7 RID: 58615
		private Regex regex_2;

		// Token: 0x0400E4F8 RID: 58616
		public readonly BindableState<bool> HasError;

		// Token: 0x02002C79 RID: 11385
		[StructLayout(LayoutKind.Auto)]
		public readonly struct Struct939
		{
			// Token: 0x0400E4F9 RID: 58617
			public readonly EValidationType Type;

			// Token: 0x0400E4FA RID: 58618
			public readonly string Regex;
		}
	}
}
