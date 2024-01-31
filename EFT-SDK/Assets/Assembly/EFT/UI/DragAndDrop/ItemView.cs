using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using Diz.LanguageExtensions;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E31 RID: 11825
	public abstract class ItemView : AssetPoolObject, IDisposable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIView
	{
		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600E936 RID: 59702 RVA: 0x00002050 File Offset: 0x00000250
		protected BindableState<bool> IsBeingDragged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600E937 RID: 59703 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingRemoved
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600E938 RID: 59704 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingAdded
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600E939 RID: 59705 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingDrained
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600E93A RID: 59706 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsFilteredOut
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600E93B RID: 59707 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsDisabledDrag
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600E93C RID: 59708 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingSearched
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600E93D RID: 59709 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingExamined
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingLoadedMagazine
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600E93F RID: 59711 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingUnloadedMagazine
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600E940 RID: 59712 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<bool> IsBeingLoadedAmmo
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600E941 RID: 59713 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<Error> RemoveError
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600E942 RID: 59714 RVA: 0x00002050 File Offset: 0x00000250
		GameObject IUIView.GameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600E943 RID: 59715 RVA: 0x00002050 File Offset: 0x00000250
		Transform IUIView.Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600E944 RID: 59716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E945 RID: 59717 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2809 ItemContext
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

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600E946 RID: 59718 RVA: 0x00002050 File Offset: 0x00000250
		public bool BeingDragged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002856 RID: 10326
		// (set) Token: 0x0600E947 RID: 59719 RVA: 0x00002050 File Offset: 0x00000250
		public Color BorderColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600E948 RID: 59720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E949 RID: 59721 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2? IconScale
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

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600E94A RID: 59722 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E94B RID: 59723 RVA: 0x00002050 File Offset: 0x00000250
		public Item Item
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

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600E94C RID: 59724 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E94D RID: 59725 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSearched
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600E94E RID: 59726
		protected abstract bool IsInteractable { get; }

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600E94F RID: 59727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E950 RID: 59728 RVA: 0x00002050 File Offset: 0x00000250
		public virtual ItemRotation ItemRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600E951 RID: 59729 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform RectTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600E952 RID: 59730 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual IBindable<float> Transparency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600E953 RID: 59731 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool Examined
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600E954 RID: 59732 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E955 RID: 59733 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		private DraggedItemView DraggedItemView
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

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600E956 RID: 59734 RVA: 0x00002050 File Offset: 0x00000250
		protected GClass3021<EItemInfoButton> NewContextInteractions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void NewItemView(Item item, GClass2809 sourceItemContext, ItemRotation rotation, TraderControllerClass itemController, GInterface376 container, IItemOwner itemOwner, [CanBeNull] ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E958 RID: 59736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Item item, GInterface333 favoriteComponent)
		{
			throw null;
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CanInteract(GClass2821 dragItemContext)
		{
			throw null;
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool isBeingDragged)
		{
			throw null;
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CheckAcceptHandler(GClass2821 dragItemContext)
		{
			throw null;
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual GClass2809 CreateNewItemContext(GClass2809 sourceContext)
		{
			throw null;
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitInteractiveBinding()
		{
			throw null;
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate()
		{
			throw null;
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnBeingExaminedChanged(bool isBeingExamined)
		{
			throw null;
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateRemoveError(bool ignoreMalfunctions = true)
		{
			throw null;
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateInfoVisibility(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void Init()
		{
			throw null;
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RegisterItemView()
		{
			throw null;
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RefreshIcon()
		{
			throw null;
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateStaticInfo()
		{
			throw null;
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetQuestItemViewPanel()
		{
			throw null;
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateInfo()
		{
			throw null;
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnBeginDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEndDrag([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass2821 dragItemContext, PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		// Token: 0x0600E973 RID: 59763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E974 RID: 59764 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Highlight(bool highlight)
		{
			throw null;
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateColor()
		{
			throw null;
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBeingExaminedState(GEventArgs6 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLoadMagazineStatus(GEventArgs7 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600E979 RID: 59769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnloadMagazineStatus(GEventArgs8 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetInventoryCheckMagazineStatus(float time, bool value)
		{
			throw null;
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLoadAmmoStatus(GEventArgs1 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnClick(PointerEventData.InputButton button, Vector2 position, bool doubleClick)
		{
			throw null;
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool ExecuteMiddleClick()
		{
			throw null;
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowContextMenu(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static EBoundItem? GetBindingForAddress([CanBeNull] GInterface311 inventoryOwner, ItemAddress address)
		{
			throw null;
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static EBoundItem? GetBindingForItem([CanBeNull] TraderControllerClass itemController, Item item)
		{
			throw null;
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Kill()
		{
			throw null;
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x0600E985 RID: 59781 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0400EDE5 RID: 60901
		protected const int HIGHLIGHT_ALPHA = 50;

		// Token: 0x0400EDE6 RID: 60902
		protected const int BACKGROUND_ALPHA = 77;

		// Token: 0x0400EDE7 RID: 60903
		private const float float_0 = 0.3f;

		// Token: 0x0400EDE8 RID: 60904
		[SerializeField]
		protected ItemViewAnimation Animator;

		// Token: 0x0400EDE9 RID: 60905
		[SerializeField]
		protected Image MainImage;

		// Token: 0x0400EDEA RID: 60906
		[SerializeField]
		protected Image ColorPanel;

		// Token: 0x0400EDEB RID: 60907
		[SerializeField]
		protected Image _border;

		// Token: 0x0400EDEC RID: 60908
		[SerializeField]
		private GameObject _drainLoader;

		// Token: 0x0400EDED RID: 60909
		[SerializeField]
		private GameObject _iconLoader;

		// Token: 0x0400EDEE RID: 60910
		[SerializeField]
		protected CanvasGroup CanvasGroup;

		// Token: 0x0400EDEF RID: 60911
		[SerializeField]
		private QuestItemViewPanel _questsItemViewPanel;

		// Token: 0x0400EDF0 RID: 60912
		[SerializeField]
		protected GameObject InsuredItemBorder;

		// Token: 0x0400EDF1 RID: 60913
		[SerializeField]
		protected GameObject InsuredIcon;

		// Token: 0x0400EDF2 RID: 60914
		[SerializeField]
		protected Image RepairBuffIcon;

		// Token: 0x0400EDF3 RID: 60915
		[SerializeField]
		protected HoverTrigger HoverTrigger;

		// Token: 0x0400EDF4 RID: 60916
		[SerializeField]
		private float _mainImageAlpha;

		// Token: 0x0400EDF5 RID: 60917
		[SerializeField]
		private Image _favoriteImage;

		// Token: 0x0400EDF6 RID: 60918
		[SerializeField]
		private Image _unFavoriteImage;

		// Token: 0x0400EDF7 RID: 60919
		public static readonly Color DefaultSelectedColor;

		// Token: 0x0400EDF8 RID: 60920
		protected Color SelectedColor;

		// Token: 0x0400EDF9 RID: 60921
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_0;

		// Token: 0x0400EDFA RID: 60922
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_1;

		// Token: 0x0400EDFB RID: 60923
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_2;

		// Token: 0x0400EDFC RID: 60924
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_3;

		// Token: 0x0400EDFD RID: 60925
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_4;

		// Token: 0x0400EDFE RID: 60926
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_5;

		// Token: 0x0400EDFF RID: 60927
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_6;

		// Token: 0x0400EE00 RID: 60928
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_7;

		// Token: 0x0400EE01 RID: 60929
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_8;

		// Token: 0x0400EE02 RID: 60930
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_9;

		// Token: 0x0400EE03 RID: 60931
		[CompilerGenerated]
		private readonly BindableState<bool> gclass3370_10;

		// Token: 0x0400EE04 RID: 60932
		[CompilerGenerated]
		private readonly BindableState<Error> gclass3370_11;

		// Token: 0x0400EE05 RID: 60933
		public GInterface376 Container;

		// Token: 0x0400EE06 RID: 60934
		private bool bool_3;

		// Token: 0x0400EE07 RID: 60935
		public bool IsConflicting;

		// Token: 0x0400EE08 RID: 60936
		protected ItemUiContext ItemUiContext;

		// Token: 0x0400EE09 RID: 60937
		private IBindable<bool> ibindable_0;

		// Token: 0x0400EE0A RID: 60938
		private IBindable<bool> ibindable_1;

		// Token: 0x0400EE0B RID: 60939
		protected IBindable<bool> IsInteractive;

		// Token: 0x0400EE0C RID: 60940
		private bool bool_4;

		// Token: 0x0400EE0D RID: 60941
		protected bool HighlightedGlobally;

		// Token: 0x0400EE0E RID: 60942
		protected bool IsKilled;

		// Token: 0x0400EE0F RID: 60943
		protected ItemRotation _itemRotation;

		// Token: 0x0400EE10 RID: 60944
		protected Color OriginalBackgroundColor;

		// Token: 0x0400EE11 RID: 60945
		protected Color BackgroundColor;

		// Token: 0x0400EE12 RID: 60946
		protected TraderControllerClass ItemController;

		// Token: 0x0400EE13 RID: 60947
		protected IItemOwner ItemOwner;

		// Token: 0x0400EE14 RID: 60948
		protected bool IsTeammateDogtag;

		// Token: 0x0400EE15 RID: 60949
		private float float_1;

		// Token: 0x0400EE16 RID: 60950
		private double double_0;

		// Token: 0x0400EE17 RID: 60951
		private RectTransform rectTransform_0;

		// Token: 0x0400EE18 RID: 60952
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x0400EE19 RID: 60953
		private GClass818 gclass818_0;

		// Token: 0x0400EE1A RID: 60954
		private Vector2? nullable_0;

		// Token: 0x0400EE1B RID: 60955
		private Action action_0;

		// Token: 0x0400EE1C RID: 60956
		private PointerEventData pointerEventData_0;

		// Token: 0x0400EE1D RID: 60957
		private Color? nullable_1;

		// Token: 0x0400EE1E RID: 60958
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400EE1F RID: 60959
		[CompilerGenerated]
		private Item item_0;

		// Token: 0x0400EE20 RID: 60960
		[CompilerGenerated]
		private DraggedItemView draggedItemView_0;

		// Token: 0x02002E32 RID: 11826
		[CompilerGenerated]
		private sealed class Class2885
		{
			// Token: 0x0600E986 RID: 59782 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(bool filtered, bool dragDisabled, Error removeError)
			{
				throw null;
			}

			// Token: 0x0400EE21 RID: 60961
			public float minAlpha;

			// Token: 0x0400EE22 RID: 60962
			public float maxAlpha;
		}

		// Token: 0x02002E33 RID: 11827
		[CompilerGenerated]
		private sealed class Class2886
		{
			// Token: 0x0600E987 RID: 59783 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E988 RID: 59784 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(bool drained)
			{
				throw null;
			}

			// Token: 0x0600E989 RID: 59785 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(float transparency)
			{
				throw null;
			}

			// Token: 0x0600E98A RID: 59786 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(bool isInteractive)
			{
				throw null;
			}

			// Token: 0x0600E98B RID: 59787 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(Item item1)
			{
				throw null;
			}

			// Token: 0x0400EE23 RID: 60963
			public ItemView itemView_0;

			// Token: 0x0400EE24 RID: 60964
			public GInterface333 favoriteContext;
		}

		// Token: 0x02002E34 RID: 11828
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2887
		{
			// Token: 0x0600E98C RID: 59788 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(bool dragged, bool removed)
			{
				throw null;
			}

			// Token: 0x0600E98D RID: 59789 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(bool added, bool removed, bool examined, bool loaded)
			{
				throw null;
			}

			// Token: 0x0600E98E RID: 59790 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(bool filtered, bool dragged, bool added, bool drained, bool removed, bool searched, bool loadAmmo)
			{
				throw null;
			}

			// Token: 0x0400EE25 RID: 60965
			public static readonly ItemView.Class2887 class2887_0;

			// Token: 0x0400EE26 RID: 60966
			public static Func<bool, bool, bool> func_0;

			// Token: 0x0400EE27 RID: 60967
			public static Func<bool, bool, bool, bool, bool> func_1;

			// Token: 0x0400EE28 RID: 60968
			public static Func<bool, bool, bool, bool, bool, bool, bool, bool> func_2;
		}

		// Token: 0x02002E35 RID: 11829
		[CompilerGenerated]
		private sealed class Class2888
		{
			// Token: 0x0600E98F RID: 59791 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RepairableComponent subRepairable)
			{
				throw null;
			}

			// Token: 0x0400EE29 RID: 60969
			public GClass2726 repairKit;
		}

		// Token: 0x02002E36 RID: 11830
		[CompilerGenerated]
		private sealed class Class2889
		{
			// Token: 0x0600E990 RID: 59792 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<EBoundItem, Slot> pair)
			{
				throw null;
			}

			// Token: 0x0400EE2A RID: 60970
			public ItemAddress address;
		}

		// Token: 0x02002E37 RID: 11831
		[CompilerGenerated]
		private sealed class Class2890
		{
			// Token: 0x0600E991 RID: 59793 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<EBoundItem, Item> pair)
			{
				throw null;
			}

			// Token: 0x0400EE2B RID: 60971
			public Item item;
		}
	}
}
