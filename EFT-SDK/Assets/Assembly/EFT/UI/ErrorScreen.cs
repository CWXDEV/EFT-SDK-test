using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002889 RID: 10377
	public sealed class ErrorScreen : Window<GClass3087>
	{
		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600CF28 RID: 53032 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool DragEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3087 Show(string title, string message, Action closeManuallyCallback = null, float waitingTime = 0f, Action timeOutCallback = null, ErrorScreen.EButtonType buttonType = ErrorScreen.EButtonType.OkButton, bool removeHtml = true)
		{
			throw null;
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(string source)
		{
			throw null;
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2(DateTime endTime)
		{
			throw null;
		}

		// Token: 0x0600CF2D RID: 53037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool timeOut)
		{
			throw null;
		}

		// Token: 0x0400D00F RID: 53263
		private const string string_0 = "ERROR";

		// Token: 0x0400D010 RID: 53264
		[SerializeField]
		private TextMeshProUGUI _errorDescription;

		// Token: 0x0400D011 RID: 53265
		[SerializeField]
		private DefaultUIButton _exitButton;

		// Token: 0x0400D012 RID: 53266
		private Action action_1;

		// Token: 0x0400D013 RID: 53267
		private Coroutine coroutine_0;

		// Token: 0x0400D014 RID: 53268
		private string string_1;

		// Token: 0x0200288A RID: 10378
		public enum EButtonType
		{
			// Token: 0x0400D016 RID: 53270
			OkButton,
			// Token: 0x0400D017 RID: 53271
			CancelButton,
			// Token: 0x0400D018 RID: 53272
			QuitButton
		}

		// Token: 0x0200288B RID: 10379
		[CompilerGenerated]
		private sealed class Class2351
		{
			// Token: 0x0600CF32 RID: 53042 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D019 RID: 53273
			public GClass3087 context;

			// Token: 0x0400D01A RID: 53274
			public ErrorScreen errorScreen_0;
		}
	}
}
