using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using TMPro;
using UnityEngine;

namespace EFT.UI.Builds
{
	// Token: 0x02002EF3 RID: 12019
	public sealed class EditBuildNameWindow : Window<GClass3089>
	{
		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ShowOnTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ED37 RID: 60727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600ED38 RID: 60728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3089 Show(string savedName, string caption, string placeholderText)
		{
			throw null;
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool hasError)
		{
			throw null;
		}

		// Token: 0x0600ED3A RID: 60730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ED3B RID: 60731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0400F233 RID: 62003
		[SerializeField]
		private ValidationInputField _inputField;

		// Token: 0x0400F234 RID: 62004
		[SerializeField]
		private DefaultUIButton _saveButtonSpawner;

		// Token: 0x0400F235 RID: 62005
		[SerializeField]
		private TextMeshProUGUI _placeholderText;

		// Token: 0x0400F236 RID: 62006
		private GClass3089 gclass3089_0;
	}
}
