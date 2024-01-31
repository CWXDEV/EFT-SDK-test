using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AA2 RID: 10914
	public class BaseNotificationView : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x140002F8 RID: 760
		// (add) Token: 0x0600D8FA RID: 55546 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D8FB RID: 55547 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BaseNotificationView> OnHideComplete
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

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D8FD RID: 55549 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsHiding
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

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool ReturnToPool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D8FF RID: 55551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x0600D900 RID: 55552 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAnimationDone()
		{
			throw null;
		}

		// Token: 0x0600D901 RID: 55553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D902 RID: 55554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasSameNotification(NotificationClass other)
		{
			throw null;
		}

		// Token: 0x0600D903 RID: 55555 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600D904 RID: 55556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartAnimation()
		{
			throw null;
		}

		// Token: 0x0600D905 RID: 55557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopAnimation()
		{
			throw null;
		}

		// Token: 0x0600D906 RID: 55558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HideNotification(bool invokeCallback)
		{
			throw null;
		}

		// Token: 0x0400DBCB RID: 56267
		private const float ANIMATION_PREPARE_TIME = 0.3f;

		// Token: 0x0400DBCC RID: 56268
		private static readonly int _speed;

		// Token: 0x0400DBCD RID: 56269
		private static readonly int _autoComplete;

		// Token: 0x0400DBCE RID: 56270
		private static readonly int _forcedComplete;

		// Token: 0x0400DBCF RID: 56271
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DBD0 RID: 56272
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x0400DBD1 RID: 56273
		[SerializeField]
		private LayoutElement _layout;

		// Token: 0x0400DBD2 RID: 56274
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400DBD3 RID: 56275
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400DBD4 RID: 56276
		[SerializeField]
		private Image _background;

		// Token: 0x0400DBD5 RID: 56277
		[FormerlySerializedAs("_defaultColor")]
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x0400DBD6 RID: 56278
		[SerializeField]
		private Color _defaultBackgroundColor;

		// Token: 0x0400DBD7 RID: 56279
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400DBDA RID: 56282
		private NotificationClass _notification;

		// Token: 0x0400DBDB RID: 56283
		private float _height;
	}
}
