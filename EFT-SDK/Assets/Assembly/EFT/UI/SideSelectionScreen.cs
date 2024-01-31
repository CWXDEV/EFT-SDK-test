using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002925 RID: 10533
	public sealed class SideSelectionScreen : EftScreen<SideSelectionScreen.GClass3143, SideSelectionScreen>
	{
		// Token: 0x0600D252 RID: 53842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SideSelectionScreen.GClass3143 controller)
		{
			throw null;
		}

		// Token: 0x0600D254 RID: 53844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile bearProfile, Profile usecProfile, GClass1816.GClass1817 profileData, string[] availableCustomizations)
		{
			throw null;
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3(int stateIndex)
		{
			throw null;
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool ready)
		{
			throw null;
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400D3AE RID: 54190
		[SerializeField]
		private SideSelectionState _sideSelectionState;

		// Token: 0x0400D3AF RID: 54191
		[SerializeField]
		private HeadSelectionState _headSelectionState;

		// Token: 0x0400D3B0 RID: 54192
		[SerializeField]
		private PlayerProfilePreview _bearPreview;

		// Token: 0x0400D3B1 RID: 54193
		[SerializeField]
		private PlayerProfilePreview _usecPreview;

		// Token: 0x0400D3B2 RID: 54194
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400D3B3 RID: 54195
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400D3B4 RID: 54196
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400D3B5 RID: 54197
		private List<GClass3012> list_0;

		// Token: 0x0400D3B6 RID: 54198
		private int int_0;

		// Token: 0x0400D3B7 RID: 54199
		private bool bool_1;

		// Token: 0x02002926 RID: 10534
		public sealed class GClass3143 : GClass3142<SideSelectionScreen.GClass3143, SideSelectionScreen>
		{
			// Token: 0x17002571 RID: 9585
			// (get) Token: 0x0600D25E RID: 53854 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002572 RID: 9586
			// (get) Token: 0x0600D25F RID: 53855 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002573 RID: 9587
			// (get) Token: 0x0600D260 RID: 53856 RVA: 0x00002050 File Offset: 0x00000250
			public GClass1816.GClass1817 ProfileData
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002574 RID: 9588
			// (get) Token: 0x0600D261 RID: 53857 RVA: 0x00002050 File Offset: 0x00000250
			public string[] AvailableCustomizations
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400D3B8 RID: 54200
			public readonly Profile BearProfile;

			// Token: 0x0400D3B9 RID: 54201
			public readonly Profile UsecProfile;

			// Token: 0x0400D3BA RID: 54202
			[CompilerGenerated]
			private readonly GClass1816.GClass1817 gclass1817_0;

			// Token: 0x0400D3BB RID: 54203
			[CompilerGenerated]
			private readonly string[] string_0;
		}
	}
}
