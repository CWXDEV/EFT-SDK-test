using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020009D3 RID: 2515
public class TraderCard : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x140000C4 RID: 196
	// (add) Token: 0x06003803 RID: 14339 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003804 RID: 14340 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnClick
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

	// Token: 0x06003805 RID: 14341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003806 RID: 14342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show(Profile.TraderInfo trader, AbstractQuestControllerClass questController, TraderTooltip tooltip)
	{
		throw null;
	}

	// Token: 0x06003807 RID: 14343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003808 RID: 14344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003809 RID: 14345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x0600380A RID: 14346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x0600380B RID: 14347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x0600380C RID: 14348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x0600380D RID: 14349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCardState(Profile.TraderInfo selectedTraderInfo)
	{
		throw null;
	}

	// Token: 0x0600380E RID: 14350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyState(TraderCard.ETraderCardState state)
	{
		throw null;
	}

	// Token: 0x0600380F RID: 14351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003810 RID: 14352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003811 RID: 14353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003812 RID: 14354 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(PointerEventData _)
	{
		throw null;
	}

	// Token: 0x06003813 RID: 14355 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(PointerEventData _)
	{
		throw null;
	}

	// Token: 0x040039BE RID: 14782
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x040039BF RID: 14783
	[SerializeField]
	private TraderCard.TraderCardState[] _states;

	// Token: 0x040039C0 RID: 14784
	[SerializeField]
	private TraderAvatar _traderAvatar;

	// Token: 0x040039C1 RID: 14785
	[SerializeField]
	private LocalizedText _nickName;

	// Token: 0x040039C2 RID: 14786
	[SerializeField]
	private TMP_Text _standing;

	// Token: 0x040039C3 RID: 14787
	[SerializeField]
	private TMP_Text _timeLeft;

	// Token: 0x040039C4 RID: 14788
	[SerializeField]
	private RankPanel _rankPanel;

	// Token: 0x040039C5 RID: 14789
	[SerializeField]
	private Image _mouseOver;

	// Token: 0x040039C6 RID: 14790
	[SerializeField]
	private GameObject _questionMark;

	// Token: 0x040039C7 RID: 14791
	private DateTime dateTime_0;

	// Token: 0x040039C8 RID: 14792
	private TraderTooltip traderTooltip_0;

	// Token: 0x040039C9 RID: 14793
	private Profile.TraderInfo traderInfo_0;

	// Token: 0x020009D4 RID: 2516
	public enum ETraderCardState
	{
		// Token: 0x040039CB RID: 14795
		Locked,
		// Token: 0x040039CC RID: 14796
		Available,
		// Token: 0x040039CD RID: 14797
		Selected
	}

	// Token: 0x020009D5 RID: 2517
	[Serializable]
	private class TraderCardState
	{
		// Token: 0x040039CE RID: 14798
		public TraderCard.ETraderCardState State;

		// Token: 0x040039CF RID: 14799
		public TraderCard.TraderCardStateStyle[] SetStyles;

		// Token: 0x040039D0 RID: 14800
		public GameObject[] Enable;

		// Token: 0x040039D1 RID: 14801
		public GameObject[] Disable;
	}

	// Token: 0x020009D6 RID: 2518
	[Serializable]
	private class TraderCardStateStyle
	{
		// Token: 0x040039D2 RID: 14802
		public Color Color;

		// Token: 0x040039D3 RID: 14803
		public Graphic[] Graphic;
	}

	// Token: 0x020009D7 RID: 2519
	[CompilerGenerated]
	private sealed class Class516
	{
		// Token: 0x06003814 RID: 14356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x040039D4 RID: 14804
		public Profile.TraderInfo trader;

		// Token: 0x040039D5 RID: 14805
		public TraderCard traderCard_0;
	}

	// Token: 0x020009D8 RID: 2520
	[CompilerGenerated]
	private sealed class Class517
	{
		// Token: 0x06003817 RID: 14359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TraderCard.TraderCardState currentState)
		{
			throw null;
		}

		// Token: 0x040039D6 RID: 14806
		public TraderCard.ETraderCardState state;
	}
}
