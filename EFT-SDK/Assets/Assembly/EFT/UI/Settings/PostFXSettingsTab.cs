using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D5A RID: 11610
	public class PostFXSettingsTab : SettingsTab
	{
		// Token: 0x0600E46C RID: 58476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass954 settings, SettingsScreen.GClass3160 screenController = null)
		{
			throw null;
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass954 settings)
		{
			throw null;
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task TakeSettingsFrom(SharedGameSettingsClass settingsManager)
		{
			throw null;
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool value)
		{
			throw null;
		}

		// Token: 0x0400E977 RID: 59767
		[SerializeField]
		private UpdatableToggle _overallToggle;

		// Token: 0x0400E978 RID: 59768
		[SerializeField]
		private FloatSlider _brightness;

		// Token: 0x0400E979 RID: 59769
		[SerializeField]
		private FloatSlider _saturation;

		// Token: 0x0400E97A RID: 59770
		[SerializeField]
		private FloatSlider _clarity;

		// Token: 0x0400E97B RID: 59771
		[SerializeField]
		private FloatSlider _colorfulness;

		// Token: 0x0400E97C RID: 59772
		[SerializeField]
		private FloatSlider _lumaSharpen;

		// Token: 0x0400E97D RID: 59773
		[SerializeField]
		private FloatSlider _adaptiveSharpen;

		// Token: 0x0400E97E RID: 59774
		[SerializeField]
		private FloatSlider _filterIntensity;

		// Token: 0x0400E97F RID: 59775
		[SerializeField]
		private FloatSlider _colorblindnessIntensity;

		// Token: 0x0400E980 RID: 59776
		[SerializeField]
		private DropDownBox _colorGrading;

		// Token: 0x0400E981 RID: 59777
		[SerializeField]
		private DropDownBox _colorblindnessType;

		// Token: 0x0400E982 RID: 59778
		[SerializeField]
		protected DefaultUIButton _visualizeButton;

		// Token: 0x0400E983 RID: 59779
		[SerializeField]
		private CanvasGroup[] _toggleRelatedCanvases;

		// Token: 0x0400E984 RID: 59780
		protected GClass954 _postFXSettingsGroup;

		// Token: 0x02002D5B RID: 11611
		[CompilerGenerated]
		private sealed class Class2796
		{
			// Token: 0x0600E470 RID: 58480 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E985 RID: 59781
			public SettingsScreen.GClass3160 screenController;

			// Token: 0x02002D5C RID: 11612
			[StructLayout(LayoutKind.Auto)]
			public struct Struct963 : IAsyncStateMachine
			{
				// Token: 0x0600E471 RID: 58481 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600E472 RID: 58482 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400E986 RID: 59782
				public int int_0;

				// Token: 0x0400E987 RID: 59783
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x0400E988 RID: 59784
				public PostFXSettingsTab.Class2796 class2796_0;

				// Token: 0x0400E989 RID: 59785
				private TaskAwaiter<bool> taskAwaiter_0;
			}
		}
	}
}
