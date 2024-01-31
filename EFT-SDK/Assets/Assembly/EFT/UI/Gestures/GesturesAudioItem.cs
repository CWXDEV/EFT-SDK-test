using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA3 RID: 11939
	public sealed class GesturesAudioItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600EB98 RID: 60312 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyList<GesturesAudioSubItem> AudioSubItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600EB99 RID: 60313 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasOnlySituational
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002883 RID: 10371
		// (set) Token: 0x0600EB9A RID: 60314 RVA: 0x00002050 File Offset: 0x00000250
		public string LocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EB9C RID: 60316 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOpen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GestureBaseItem CreateNewPhrase(EPhraseTrigger phrase, bool isSituational)
		{
			throw null;
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Sprite defaultBackground, Sprite selectedBackground, Color defaultAudioColor, Color selectedAudioColor, GClass3175 binds, HashSet<EPhraseTrigger> availablePhrases)
		{
			throw null;
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400F0B1 RID: 61617
		public bool GroupIsAlwaysOpen;

		// Token: 0x0400F0B2 RID: 61618
		[SerializeField]
		private LocalizedText _nameText;

		// Token: 0x0400F0B3 RID: 61619
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F0B4 RID: 61620
		[SerializeField]
		private GameObject _selectionGlow;

		// Token: 0x0400F0B5 RID: 61621
		[SerializeField]
		private GameObject _subItemsContainer;

		// Token: 0x0400F0B6 RID: 61622
		[SerializeField]
		private GesturesAudioSubItem _subItemTemplate;

		// Token: 0x0400F0B7 RID: 61623
		[SerializeField]
		private List<GesturesAudioSubItem> _audioSubItems;

		// Token: 0x0400F0B8 RID: 61624
		private bool bool_0;

		// Token: 0x02002EA4 RID: 11940
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2929
		{
			// Token: 0x0600EBA3 RID: 60323 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GesturesAudioSubItem x)
			{
				throw null;
			}

			// Token: 0x0400F0B9 RID: 61625
			public static readonly GesturesAudioItem.Class2929 class2929_0;

			// Token: 0x0400F0BA RID: 61626
			public static Func<GesturesAudioSubItem, bool> func_0;
		}
	}
}
