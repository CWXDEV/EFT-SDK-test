using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C95 RID: 11413
	public abstract class Window<TContext> : UIInputNode, IEventSystemHandler, IPointerDownHandler where TContext : GClass3085, new()
	{
		// Token: 0x1400031C RID: 796
		// (add) Token: 0x0600E0E0 RID: 57568 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E0E1 RID: 57569 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnWindowClick
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x00002050 File Offset: 0x00000250
		private TContext WindowContext
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

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool DragEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600E0E5 RID: 57573 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool ClickPutsOnTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600E0E6 RID: 57574 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool ShowOnTop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600E0E7 RID: 57575 RVA: 0x00002050 File Offset: 0x00000250
		protected TextMeshProUGUI Caption
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600E0E8 RID: 57576 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform WindowTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600E0E9 RID: 57577 RVA: 0x00002050 File Offset: 0x00000250
		protected Button CloseButton
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TContext Show(Action onClosed)
		{
			throw null;
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task<bool> CloseInterruption()
		{
			throw null;
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual TContext CreateContext()
		{
			throw null;
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E0F0 RID: 57584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600E0F1 RID: 57585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E0F2 RID: 57586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400E594 RID: 58772
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400E595 RID: 58773
		[SerializeField]
		private RectTransform _windowTransform;

		// Token: 0x0400E596 RID: 58774
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400E597 RID: 58775
		[SerializeField]
		private TextMeshProUGUI _caption;

		// Token: 0x0400E598 RID: 58776
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400E599 RID: 58777
		[CompilerGenerated]
		private TContext gparam_0;

		// Token: 0x0400E59A RID: 58778
		protected bool Open;

		// Token: 0x0400E59B RID: 58779
		protected Action CloseAction;

		// Token: 0x0400E59C RID: 58780
		private Task<bool> task_0;
	}
}
