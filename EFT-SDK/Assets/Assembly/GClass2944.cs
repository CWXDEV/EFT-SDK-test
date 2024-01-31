using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BSG.CameraEffects;
using EFT.CameraControl;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x020026FD RID: 9981
public class GClass2944 : IDisposable
{
	// Token: 0x17002373 RID: 9075
	// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x00002050 File Offset: 0x00000250
	public int OpticRenderResolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002374 RID: 9076
	// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x00002050 File Offset: 0x00000250
	public int OpticNextRenderResolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002375 RID: 9077
	// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00002050 File Offset: 0x00000250
	public OpticComponentUpdater Updater
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140002CC RID: 716
	// (add) Token: 0x0600C5F4 RID: 50676 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5F5 RID: 50677 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnOpticEnabled
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

	// Token: 0x140002CD RID: 717
	// (add) Token: 0x0600C5F6 RID: 50678 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5F7 RID: 50679 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnOpticDisabled
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

	// Token: 0x140002CE RID: 718
	// (add) Token: 0x0600C5F8 RID: 50680 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5F9 RID: 50681 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Texture, Texture> OnOpticTexturesAreChanged
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

	// Token: 0x17002376 RID: 9078
	// (get) Token: 0x0600C5FA RID: 50682 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5FB RID: 50683 RVA: 0x00002050 File Offset: 0x00000250
	public Camera Camera
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

	// Token: 0x17002377 RID: 9079
	// (get) Token: 0x0600C5FC RID: 50684 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002378 RID: 9080
	// (get) Token: 0x0600C5FD RID: 50685 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5FE RID: 50686 RVA: 0x00002050 File Offset: 0x00000250
	public OpticSight CurrentOpticSight
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

	// Token: 0x17002379 RID: 9081
	// (get) Token: 0x0600C5FF RID: 50687 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C600 RID: 50688 RVA: 0x00002050 File Offset: 0x00000250
	public NightVision NightVision
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

	// Token: 0x0600C601 RID: 50689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x0600C602 RID: 50690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResolution(int resolution)
	{
		throw null;
	}

	// Token: 0x0600C603 RID: 50691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSSR(bool ssrEnabled)
	{
		throw null;
	}

	// Token: 0x0600C604 RID: 50692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(OpticSight.GStruct381 sightStatus)
	{
		throw null;
	}

	// Token: 0x0600C605 RID: 50693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x0600C606 RID: 50694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(OpticSight opticSight)
	{
		throw null;
	}

	// Token: 0x0600C607 RID: 50695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AttachToCamera(Camera camera)
	{
		throw null;
	}

	// Token: 0x0600C608 RID: 50696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(OpticSight opticSight)
	{
		throw null;
	}

	// Token: 0x0600C609 RID: 50697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C7B8 RID: 51128
	public int OpticFinalResolution;

	// Token: 0x0400C7B9 RID: 51129
	private OpticComponentUpdater opticComponentUpdater_0;

	// Token: 0x0400C7BA RID: 51130
	private StreamingController streamingController_0;

	// Token: 0x0400C7BB RID: 51131
	private PostProcessVolume postProcessVolume_0;

	// Token: 0x0400C7BC RID: 51132
	private PostProcessLayer postProcessLayer_0;

	// Token: 0x0400C7BD RID: 51133
	private ThermalVision thermalVision_0;

	// Token: 0x0400C7BE RID: 51134
	private Coroutine coroutine_0;

	// Token: 0x0400C7BF RID: 51135
	private Action action_0;

	// Token: 0x0400C7C0 RID: 51136
	private RenderTexture renderTexture_0;

	// Token: 0x0400C7C1 RID: 51137
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400C7C2 RID: 51138
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400C7C3 RID: 51139
	[CompilerGenerated]
	private Action<Texture, Texture> action_3;

	// Token: 0x0400C7C4 RID: 51140
	[CompilerGenerated]
	private Camera camera_0;

	// Token: 0x0400C7C5 RID: 51141
	[CompilerGenerated]
	private OpticSight opticSight_0;

	// Token: 0x0400C7C6 RID: 51142
	[CompilerGenerated]
	private NightVision nightVision_0;

	// Token: 0x0400C7C7 RID: 51143
	private static readonly int int_0;
}
