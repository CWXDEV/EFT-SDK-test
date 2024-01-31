using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AF2 RID: 10994
	public sealed class SplitDialog : MonoBehaviour, IEventSystemHandler, IPointerDownHandler
	{
		// Token: 0x0600DA56 RID: 55894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600DA57 RID: 55895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string title, int maxValue, Vector2 position, Action<int> acceptAction, Action cancelAction, SplitDialog.ESplitDialogType type = SplitDialog.ESplitDialogType.Step)
		{
			throw null;
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string title, int minSliderValue, int maxSliderValue, int minValue, int maxValue, int currentValue, Vector2 position, Action<int> acceptAction, Action cancelAction, SplitDialog.ESplitDialogType type = SplitDialog.ESplitDialogType.Step, bool allowZero = false)
		{
			throw null;
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Accept()
		{
			throw null;
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Action action)
		{
			throw null;
		}

		// Token: 0x0600DA5B RID: 55899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DA5C RID: 55900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400DD4E RID: 56654
		[SerializeField]
		private RectTransform _window;

		// Token: 0x0400DD4F RID: 56655
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400DD50 RID: 56656
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400DD51 RID: 56657
		[SerializeField]
		private Button _acceptButton;

		// Token: 0x0400DD52 RID: 56658
		[SerializeField]
		private StepSlider _stepSlider;

		// Token: 0x0400DD53 RID: 56659
		[SerializeField]
		private IntSlider _intSlider;

		// Token: 0x0400DD54 RID: 56660
		[SerializeField]
		private CustomTextMeshProUGUI _title;

		// Token: 0x0400DD55 RID: 56661
		private Action<int> action_0;

		// Token: 0x0400DD56 RID: 56662
		private Action action_1;

		// Token: 0x0400DD57 RID: 56663
		private Action action_2;

		// Token: 0x02002AF3 RID: 10995
		public enum ESplitDialogType
		{
			// Token: 0x0400DD59 RID: 56665
			Int,
			// Token: 0x0400DD5A RID: 56666
			Float,
			// Token: 0x0400DD5B RID: 56667
			Step
		}
	}
}
