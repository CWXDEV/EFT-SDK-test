using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C8E RID: 11406
	public class MessageWindow : DialogWindow<GClass3087>
	{
		// Token: 0x17002733 RID: 10035
		// (set) Token: 0x0600E0C4 RID: 57540 RVA: 0x00002050 File Offset: 0x00000250
		public TextAlignmentOptions MessageAlignment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E0C6 RID: 57542 RVA: 0x00002050 File Offset: 0x00000250
		private string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600E0C7 RID: 57543 RVA: 0x00002050 File Offset: 0x00000250
		protected TextMeshProUGUI Message
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E0C8 RID: 57544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 Show(string title, string message, Action acceptAction, [CanBeNull] Action cancelAction, float time = 0f)
		{
			throw null;
		}

		// Token: 0x0600E0C9 RID: 57545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string title, string description)
		{
			throw null;
		}

		// Token: 0x0600E0CA RID: 57546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task AnimateText(Color color)
		{
			throw null;
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3(DateTime endTime, [CanBeNull] Action onFinished)
		{
			throw null;
		}

		// Token: 0x0600E0CC RID: 57548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0400E576 RID: 58742
		private const float float_0 = 0.15f;

		// Token: 0x0400E577 RID: 58743
		private const int int_2 = 8;

		// Token: 0x0400E578 RID: 58744
		[SerializeField]
		private TextMeshProUGUI _message;

		// Token: 0x0400E579 RID: 58745
		private Coroutine coroutine_0;

		// Token: 0x0400E57A RID: 58746
		[CompilerGenerated]
		private string string_2;
	}
}
