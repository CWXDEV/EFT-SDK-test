using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationEventSystem;
using EFT;
using JetBrains.Annotations;

// Token: 0x020006D9 RID: 1753
public abstract class ObjectInHandsAnimator
{
	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x060027AF RID: 10159 RVA: 0x00002050 File Offset: 0x00000250
	public IAnimator Animator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000725 RID: 1829
	// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInInteraction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInInventory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x060027B2 RID: 10162 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Action FireEventAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AnimatorEventHandler(int functionNameHash, AnimationEventParameter parameter)
	{
		throw null;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Gesture(EGesture index)
	{
		throw null;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowCompass(bool show)
	{
		throw null;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowRadioTransmitter(bool show)
	{
		throw null;
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEventsConsumer([NotNull] GInterface24 eventsConsumer)
	{
		throw null;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEventsConsumer([NotNull] GInterface24 eventsConsumer)
	{
		throw null;
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetAnimatorGetter(Func<IAnimator> getter)
	{
		throw null;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool HasParameter(int parameterHash)
	{
		throw null;
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayerState(ObjectInHandsAnimator.PlayerState state)
	{
		throw null;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPatrol(bool b)
	{
		throw null;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SkipTime(float t)
	{
		throw null;
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CurrentStateNameIs(int layer, string sname)
	{
		throw null;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLayerWeight(int layerid, int p2)
	{
		throw null;
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLayerWeight(int layerId, float weight)
	{
		throw null;
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLayerWeight(string layerName, int p2)
	{
		throw null;
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetLeftHand()
	{
		throw null;
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInventory(bool open)
	{
		throw null;
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LockInventory()
	{
		throw null;
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnlockInventory()
	{
		throw null;
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveParam(bool active, bool resetLeftHand = true)
	{
		throw null;
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFastHide(bool fastHide)
	{
		throw null;
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetQuickFire(bool quickFire)
	{
		throw null;
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPointOfViewOnSpawn(EPointOfView pointOfView)
	{
		throw null;
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationSpeed(float speed)
	{
		throw null;
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLActionIndex(int actionIndex)
	{
		throw null;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeflected(bool b)
	{
		throw null;
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMeleeSpeed(float speed)
	{
		throw null;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetAnimatorParameter(int hash)
	{
		throw null;
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetLeftHandProgress()
	{
		throw null;
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetLayerWeight(int layerIndex)
	{
		throw null;
	}

	// Token: 0x040026D5 RID: 9941
	private bool _inventoryLocked;

	// Token: 0x040026D6 RID: 9942
	public const int LACTION_DROP_BACKPACK_INDEX = 300;

	// Token: 0x040026D7 RID: 9943
	public const int LACTION_PICKUP_INDEX = 1;

	// Token: 0x040026D8 RID: 9944
	protected const string LACTIONS_LAYER_NAME = "LActions";

	// Token: 0x040026D9 RID: 9945
	protected Func<IAnimator> _animatorGetter;

	// Token: 0x040026DA RID: 9946
	protected int _animatorLayersCount;

	// Token: 0x040026DB RID: 9947
	private readonly List<GInterface24> _eventsConsumers;

	// Token: 0x040026DC RID: 9948
	private readonly HashSet<int> _existedParameters;

	// Token: 0x040026DD RID: 9949
	public int LACTIONS_LAYER_INDEX;

	// Token: 0x020006DA RID: 1754
	public enum PlayerState
	{
		// Token: 0x040026DF RID: 9951
		None,
		// Token: 0x040026E0 RID: 9952
		Idle,
		// Token: 0x040026E1 RID: 9953
		Jump,
		// Token: 0x040026E2 RID: 9954
		Sprint,
		// Token: 0x040026E3 RID: 9955
		Prone
	}
}
