using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020009CE RID: 2510
public class Tab : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x140000C3 RID: 195
	// (add) Token: 0x060037E3 RID: 14307 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060037E4 RID: 14308 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Tab, bool> OnSelectionChanged
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

	// Token: 0x1700096F RID: 2415
	// (get) Token: 0x060037E5 RID: 14309 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual bool CanHandlePointerClick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060037E6 RID: 14310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060037E7 RID: 14311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnAwake()
	{
		throw null;
	}

	// Token: 0x060037E8 RID: 14312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GInterface368 controller)
	{
		throw null;
	}

	// Token: 0x060037E9 RID: 14313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick([NotNull] PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037EA RID: 14314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void HandlePointerClick(bool isSelectedNow)
	{
		throw null;
	}

	// Token: 0x060037EB RID: 14315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Select(bool sendCallback = true)
	{
		throw null;
	}

	// Token: 0x060037EC RID: 14316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<bool> Deselect()
	{
		throw null;
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateVisual(bool selected, bool uiOnly = false)
	{
		throw null;
	}

	// Token: 0x060037EE RID: 14318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual void vmethod_0(bool active)
	{
		throw null;
	}

	// Token: 0x060037EF RID: 14319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060037F0 RID: 14320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPointerEnter([NotNull] PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037F1 RID: 14321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPointerExit([NotNull] PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037F2 RID: 14322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Hover(bool isHovered)
	{
		throw null;
	}

	// Token: 0x040039A0 RID: 14752
	[CompilerGenerated]
	private Action<Tab, bool> action_0;

	// Token: 0x040039A1 RID: 14753
	[SerializeField]
	protected GameObject _normalVersion;

	// Token: 0x040039A2 RID: 14754
	[SerializeField]
	protected GameObject _selectedVersion;

	// Token: 0x040039A3 RID: 14755
	[SerializeField]
	protected CanvasGroup _canvasGroup;

	// Token: 0x040039A4 RID: 14756
	[SerializeField]
	protected Image _targetImage;

	// Token: 0x040039A5 RID: 14757
	[SerializeField]
	protected Sprite _hoverSprite;

	// Token: 0x040039A6 RID: 14758
	[SerializeField]
	protected GameObject _hoverGraphic;

	// Token: 0x040039A7 RID: 14759
	[SerializeField]
	protected GameObject _idleGraphic;

	// Token: 0x040039A8 RID: 14760
	public bool Interactable;

	// Token: 0x040039A9 RID: 14761
	protected Sprite _normalSprite;

	// Token: 0x040039AA RID: 14762
	private bool bool_0;

	// Token: 0x040039AB RID: 14763
	protected bool _uiSelected;

	// Token: 0x040039AC RID: 14764
	protected GInterface368 Controller;
}
