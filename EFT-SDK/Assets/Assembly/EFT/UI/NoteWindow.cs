using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AA0 RID: 10912
	public class NoteWindow : MonoBehaviour
	{
		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600D8F0 RID: 55536 RVA: 0x00002050 File Offset: 0x00000250
		private RectTransform RectTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D8F1 RID: 55537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Action<string> acceptAction, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillData(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TextChangedHandler(string value)
		{
			throw null;
		}

		// Token: 0x0600D8F6 RID: 55542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TitleChangedHandler(string value)
		{
			throw null;
		}

		// Token: 0x0600D8F7 RID: 55543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateAcceptButton()
		{
			throw null;
		}

		// Token: 0x0400DBB5 RID: 56245
		[SerializeField]
		private RectTransform _mainWindow;

		// Token: 0x0400DBB6 RID: 56246
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400DBB7 RID: 56247
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400DBB8 RID: 56248
		[SerializeField]
		private TMP_InputField _note;

		// Token: 0x0400DBB9 RID: 56249
		[SerializeField]
		private CustomTextMeshProUGUI _lettersCounter;

		// Token: 0x0400DBBA RID: 56250
		[SerializeField]
		private DefaultUIButton _button;

		// Token: 0x0400DBBB RID: 56251
		private Action<string> _acceptAction;

		// Token: 0x0400DBBC RID: 56252
		private Action _cancelAction;
	}
}
