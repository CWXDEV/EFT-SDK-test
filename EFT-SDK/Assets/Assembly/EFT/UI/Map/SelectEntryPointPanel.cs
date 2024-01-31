using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Map
{
	// Token: 0x02002F1E RID: 12062
	public class SelectEntryPointPanel : UIElement
	{
		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600EE0F RID: 60943 RVA: 0x00002050 File Offset: 0x00000250
		public EntryPoint SelectedPoint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EE10 RID: 60944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EE11 RID: 60945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool allowSelection, EntryPoint[] points, Action<EntryPoint> onSelected = null)
		{
			throw null;
		}

		// Token: 0x0600EE12 RID: 60946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EE13 RID: 60947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EE14 RID: 60948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select(EntryPoint point)
		{
			throw null;
		}

		// Token: 0x0600EE15 RID: 60949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EntryPoint point)
		{
			throw null;
		}

		// Token: 0x0600EE16 RID: 60950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400F34E RID: 62286
		[SerializeField]
		private GameObject _randomPointObject;

		// Token: 0x0400F34F RID: 62287
		[SerializeField]
		private GameObject _selectedPointObject;

		// Token: 0x0400F350 RID: 62288
		[SerializeField]
		private CustomTextMeshProUGUI _entryPointIndex;

		// Token: 0x0400F351 RID: 62289
		[SerializeField]
		private CustomTextMeshProUGUI _entryPointLabel;

		// Token: 0x0400F352 RID: 62290
		[SerializeField]
		private Button _middleButton;

		// Token: 0x0400F353 RID: 62291
		[SerializeField]
		private Button _leftButton;

		// Token: 0x0400F354 RID: 62292
		[SerializeField]
		private Button _rightButton;

		// Token: 0x0400F355 RID: 62293
		private GClass3185 gclass3185_0;

		// Token: 0x0400F356 RID: 62294
		private Action<EntryPoint> action_0;
	}
}
