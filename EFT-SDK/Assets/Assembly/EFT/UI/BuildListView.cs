using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028CD RID: 10445
	public abstract class BuildListView<TWrapper, TBuild> : ButtonFeedback where TWrapper : GClass3017<TBuild> where TBuild : GInterface183
	{
		// Token: 0x0600D091 RID: 53393 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(TWrapper buildWrapper)
		{
			throw null;
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetSelectedVisual(bool selected)
		{
			throw null;
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400D176 RID: 53622
		[SerializeField]
		private TextMeshProUGUI _buildName;

		// Token: 0x0400D177 RID: 53623
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x0400D178 RID: 53624
		[SerializeField]
		private Button _renameButton;

		// Token: 0x0400D179 RID: 53625
		[SerializeField]
		private GameObject _selectedBackground;

		// Token: 0x0400D17A RID: 53626
		protected TWrapper BuildWrapper;
	}
}
