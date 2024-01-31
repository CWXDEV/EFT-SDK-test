using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x0200093B RID: 2363
public class InteractiveSubscriber : MonoBehaviour
{
	// Token: 0x06003562 RID: 13666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		throw null;
	}

	// Token: 0x06003563 RID: 13667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnStatusChangedHandler(WorldInteractiveObject subscribee, EDoorState previous, EDoorState next)
	{
		throw null;
	}

	// Token: 0x06003564 RID: 13668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySounds(EDoorState fromState, EDoorState state)
	{
		throw null;
	}

	// Token: 0x06003565 RID: 13669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ViewsSetActive(EDoorState state)
	{
		throw null;
	}

	// Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0(Transform parent, bool isActive)
	{
		throw null;
	}

	// Token: 0x06003567 RID: 13671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003568 RID: 13672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1(Transform t, Vector3 spin)
	{
		throw null;
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x0400364D RID: 13901
	public WorldInteractiveObject Subscribee;

	// Token: 0x0400364E RID: 13902
	public QueuePlayer QueuePlayer;

	// Token: 0x0400364F RID: 13903
	public InteractiveSubscriber.ViewPerState[] Views;

	// Token: 0x04003650 RID: 13904
	public InteractiveSubscriber.PlaySettings[] Sounds;

	// Token: 0x04003651 RID: 13905
	private Action action_0;

	// Token: 0x0200093C RID: 2364
	[Serializable]
	public class ViewPerState
	{
		// Token: 0x04003652 RID: 13906
		public EDoorState State;

		// Token: 0x04003653 RID: 13907
		public GameObject GameObject;

		// Token: 0x04003654 RID: 13908
		public bool EnableDisable;

		// Token: 0x04003655 RID: 13909
		public bool EnableContentInCoroutine;

		// Token: 0x04003656 RID: 13910
		public Vector3 Spin;
	}

	// Token: 0x0200093D RID: 2365
	[Serializable]
	public class PlaySettings
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00002050 File Offset: 0x00000250
		public BetterSource Source
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

		// Token: 0x04003657 RID: 13911
		public AudioClip Clip;

		// Token: 0x04003658 RID: 13912
		public bool Loop;

		// Token: 0x04003659 RID: 13913
		public float Volume;

		// Token: 0x0400365A RID: 13914
		public int MaxDistance;

		// Token: 0x0400365B RID: 13915
		public float SpatialBlend;

		// Token: 0x0400365C RID: 13916
		public AnimationCurve CustomCurve;

		// Token: 0x0400365D RID: 13917
		public AnimationCurve SpreadCurve;

		// Token: 0x0400365E RID: 13918
		public float StartDelay;

		// Token: 0x0400365F RID: 13919
		public float EndDelay;

		// Token: 0x04003660 RID: 13920
		public float FadeOut;

		// Token: 0x04003661 RID: 13921
		public float FadeIn;

		// Token: 0x04003662 RID: 13922
		public EDoorState State;

		// Token: 0x04003663 RID: 13923
		public EDoorState FromState;

		// Token: 0x04003664 RID: 13924
		public Transform[] AdditionalPositions;
	}

	// Token: 0x0200093E RID: 2366
	[CompilerGenerated]
	private sealed class Class489
	{
		// Token: 0x04003665 RID: 13925
		public InteractiveSubscriber.PlaySettings sound;

		// Token: 0x04003666 RID: 13926
		public InteractiveSubscriber interactiveSubscriber_0;
	}

	// Token: 0x0200093F RID: 2367
	[CompilerGenerated]
	private sealed class Class490
	{
		// Token: 0x0600356C RID: 13676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04003667 RID: 13927
		public InteractiveSubscriber.PlaySettings closureSound;
	}

	// Token: 0x02000940 RID: 2368
	[CompilerGenerated]
	private sealed class Class491
	{
		// Token: 0x0600356D RID: 13677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04003668 RID: 13928
		public InteractiveSubscriber.PlaySettings closureSound;

		// Token: 0x04003669 RID: 13929
		public InteractiveSubscriber.Class489 class489_0;
	}

	// Token: 0x02000941 RID: 2369
	[CompilerGenerated]
	private sealed class Class492
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400366A RID: 13930
		public BetterSource closureSource;

		// Token: 0x0400366B RID: 13931
		public InteractiveSubscriber.PlaySettings closureSound;

		// Token: 0x0400366C RID: 13932
		public Action action_0;
	}

	// Token: 0x02000942 RID: 2370
	[CompilerGenerated]
	[Serializable]
	private sealed class Class493
	{
		// Token: 0x06003570 RID: 13680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400366D RID: 13933
		public static readonly InteractiveSubscriber.Class493 class493_0;

		// Token: 0x0400366E RID: 13934
		public static Action action_0;
	}

	// Token: 0x02000943 RID: 2371
	[CompilerGenerated]
	private sealed class Class494
	{
		// Token: 0x06003571 RID: 13681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400366F RID: 13935
		public Coroutine c;

		// Token: 0x04003670 RID: 13936
		public InteractiveSubscriber interactiveSubscriber_0;
	}

	// Token: 0x02000944 RID: 2372
	[CompilerGenerated]
	private sealed class Class495
	{
		// Token: 0x06003572 RID: 13682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04003671 RID: 13937
		public Coroutine c;

		// Token: 0x04003672 RID: 13938
		public InteractiveSubscriber interactiveSubscriber_0;
	}
}
