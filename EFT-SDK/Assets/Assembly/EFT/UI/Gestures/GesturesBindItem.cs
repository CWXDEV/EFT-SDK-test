using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA7 RID: 11943
	public sealed class GesturesBindItem : GestureBaseItem
	{
		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600EBB0 RID: 60336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBB1 RID: 60337 RVA: 0x00002050 File Offset: 0x00000250
		public ECommand Command
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600EBB3 RID: 60339 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600EBB4 RID: 60340 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600EBB5 RID: 60341 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600EBB6 RID: 60342 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600EBB7 RID: 60343 RVA: 0x00002050 File Offset: 0x00000250
		public override int ItemIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (set) Token: 0x0600EBB8 RID: 60344 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(ColorMap colorMap, ECommand command, HashSet<EPhraseTrigger> availablePhrases)
		{
			throw null;
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int index, string caption)
		{
			throw null;
		}

		// Token: 0x0600EBBC RID: 60348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void BindUpdatedHandler(GesturesMenu.GStruct400 bind)
		{
			throw null;
		}

		// Token: 0x0600EBBD RID: 60349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int index, string caption)
		{
			throw null;
		}

		// Token: 0x0600EBBE RID: 60350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UnderPointerChanged(bool isUnderPointer)
		{
			throw null;
		}

		// Token: 0x0600EBBF RID: 60351 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400F0CC RID: 61644
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F0CD RID: 61645
		[SerializeField]
		private Button _bindButton;

		// Token: 0x0400F0CE RID: 61646
		[SerializeField]
		private Image _background;

		// Token: 0x0400F0CF RID: 61647
		[SerializeField]
		private CustomTextMeshProUGUI _commandLabel;

		// Token: 0x0400F0D0 RID: 61648
		[SerializeField]
		private CustomTextMeshProUGUI _bindLabel;

		// Token: 0x0400F0D1 RID: 61649
		private HashSet<EPhraseTrigger> hashSet_0;

		// Token: 0x0400F0D2 RID: 61650
		private ColorMap colorMap_0;

		// Token: 0x0400F0D3 RID: 61651
		private string string_0;

		// Token: 0x0400F0D4 RID: 61652
		private int int_0;

		// Token: 0x0400F0D5 RID: 61653
		[CompilerGenerated]
		private ECommand ecommand_0;
	}
}
