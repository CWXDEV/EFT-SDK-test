using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BSG.CameraEffects;
using EFT.CameraControl;
using EFT.Hideout;
using EFT.Settings.Graphics;
using JetBrains.Annotations;
using Prism.Utils;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x020026F9 RID: 9977
public sealed class CameraClass : IDisposable
{
	// Token: 0x1700235C RID: 9052
	// (get) Token: 0x0600C596 RID: 50582 RVA: 0x00002050 File Offset: 0x00000250
	public static CameraClass Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700235D RID: 9053
	// (get) Token: 0x0600C597 RID: 50583 RVA: 0x00002050 File Offset: 0x00000250
	public static bool Exist
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700235E RID: 9054
	// (get) Token: 0x0600C598 RID: 50584 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2944 OpticCameraManager
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700235F RID: 9055
	// (get) Token: 0x0600C599 RID: 50585 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C59A RID: 50586 RVA: 0x00002050 File Offset: 0x00000250
	public EffectsController EffectsController
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

	// Token: 0x17002360 RID: 9056
	// (get) Token: 0x0600C59B RID: 50587 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C59C RID: 50588 RVA: 0x00002050 File Offset: 0x00000250
	public HideoutCameraFlashlight Flashlight
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

	// Token: 0x17002361 RID: 9057
	// (get) Token: 0x0600C59D RID: 50589 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C59E RID: 50590 RVA: 0x00002050 File Offset: 0x00000250
	public HighLightMesh MeshHighlighter
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

	// Token: 0x17002362 RID: 9058
	// (get) Token: 0x0600C59F RID: 50591 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5A0 RID: 50592 RVA: 0x00002050 File Offset: 0x00000250
	public VisorEffect VisorEffect
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

	// Token: 0x17002363 RID: 9059
	// (get) Token: 0x0600C5A1 RID: 50593 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5A2 RID: 50594 RVA: 0x00002050 File Offset: 0x00000250
	public HysteresisFilter VisorSwitcher
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

	// Token: 0x17002364 RID: 9060
	// (get) Token: 0x0600C5A3 RID: 50595 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5A4 RID: 50596 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17002365 RID: 9061
	// (get) Token: 0x0600C5A5 RID: 50597 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5A6 RID: 50598 RVA: 0x00002050 File Offset: 0x00000250
	public ThermalVision ThermalVision
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

	// Token: 0x17002366 RID: 9062
	// (get) Token: 0x0600C5A7 RID: 50599 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5A8 RID: 50600 RVA: 0x00002050 File Offset: 0x00000250
	public GradingPostFX PostFX
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

	// Token: 0x140002C9 RID: 713
	// (add) Token: 0x0600C5A9 RID: 50601 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5AA RID: 50602 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnFovChanged
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

	// Token: 0x17002367 RID: 9063
	// (get) Token: 0x0600C5AB RID: 50603 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5AC RID: 50604 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x140002CA RID: 714
	// (add) Token: 0x0600C5AD RID: 50605 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5AE RID: 50606 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnCameraChanged
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

	// Token: 0x140002CB RID: 715
	// (add) Token: 0x0600C5AF RID: 50607 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C5B0 RID: 50608 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> FoVUpdateAction
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

	// Token: 0x17002368 RID: 9064
	// (get) Token: 0x0600C5B1 RID: 50609 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5B2 RID: 50610 RVA: 0x00002050 File Offset: 0x00000250
	public bool ApplyDovFovOnCamera
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

	// Token: 0x17002369 RID: 9065
	// (get) Token: 0x0600C5B3 RID: 50611 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5B4 RID: 50612 RVA: 0x00002050 File Offset: 0x00000250
	public float Fov
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

	// Token: 0x1700236A RID: 9066
	// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C5B6 RID: 50614 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsActive
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

	// Token: 0x1700236B RID: 9067
	// (get) Token: 0x0600C5B7 RID: 50615 RVA: 0x00002050 File Offset: 0x00000250
	public SSAA SSAA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700236D RID: 9069
	// (get) Token: 0x0600C5B8 RID: 50616 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsOcclusionCullingAllowed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C5B9 RID: 50617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCameraFromSettings([CanBeNull] CameraClass.GInterface350 settings)
	{
		throw null;
	}

	// Token: 0x0600C5BA RID: 50618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCameraFromPrefab([CanBeNull] GameObject cameraPrefab = null, [CanBeNull] PrismPreset prismPreset = null, [CanBeNull] PostProcessProfile postProcessProfile = null)
	{
		throw null;
	}

	// Token: 0x0600C5BB RID: 50619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0([NotNull] Camera camera, [NotNull] PrismPreset prismPreset)
	{
		throw null;
	}

	// Token: 0x0600C5BC RID: 50620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0([NotNull] Camera camera, [NotNull] PostProcessProfile postProcessProfile)
	{
		throw null;
	}

	// Token: 0x0600C5BD RID: 50621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCamera(Camera camera)
	{
		throw null;
	}

	// Token: 0x0600C5BE RID: 50622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetVRamUsage(out ulong totalVRam, out ulong localBudget, out ulong localCurrentUsage)
	{
		throw null;
	}

	// Token: 0x0600C5BF RID: 50623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateUseOcclusionCulling()
	{
		throw null;
	}

	// Token: 0x0600C5C0 RID: 50624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Blur(bool isActive, float time = 0.5f)
	{
		throw null;
	}

	// Token: 0x0600C5C1 RID: 50625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float IncreaseStreamingMipMapBias(float bias)
	{
		throw null;
	}

	// Token: 0x0600C5C2 RID: 50626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Distance(Vector3 position)
	{
		throw null;
	}

	// Token: 0x0600C5C3 RID: 50627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SqrDistance(Vector3 position)
	{
		throw null;
	}

	// Token: 0x0600C5C4 RID: 50628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int fov, float minFov = 55f, float maxFov = 75f)
	{
		throw null;
	}

	// Token: 0x0600C5C5 RID: 50629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600C5C6 RID: 50630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600C5C7 RID: 50631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(int fov, int minFov, int maxFov)
	{
		throw null;
	}

	// Token: 0x0600C5C8 RID: 50632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFov(float x, float time, bool applyFovOnCamera = true)
	{
		throw null;
	}

	// Token: 0x0600C5C9 RID: 50633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_5(float x, float time)
	{
		throw null;
	}

	// Token: 0x0600C5CA RID: 50634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOcclusionCullingEnabled(bool? value)
	{
		throw null;
	}

	// Token: 0x0600C5CB RID: 50635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Texture depthBuffer, Texture mvBuffer)
	{
		throw null;
	}

	// Token: 0x0600C5CC RID: 50636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x0600C5CD RID: 50637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x0600C5CE RID: 50638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(int instanceId)
	{
		throw null;
	}

	// Token: 0x0600C5CF RID: 50639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x0600C5D0 RID: 50640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x0600C5D1 RID: 50641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(CollimatorSight sight)
	{
		throw null;
	}

	// Token: 0x0600C5D2 RID: 50642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(CollimatorSight sight)
	{
		throw null;
	}

	// Token: 0x0600C5D3 RID: 50643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAspectRatio(float division)
	{
		throw null;
	}

	// Token: 0x0600C5D4 RID: 50644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSuperSampling(float sampling)
	{
		throw null;
	}

	// Token: 0x0600C5D5 RID: 50645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChromaticAberration(bool enabled)
	{
		throw null;
	}

	// Token: 0x0600C5D6 RID: 50646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNoise(bool useNoise)
	{
		throw null;
	}

	// Token: 0x0600C5D7 RID: 50647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOverallVisibility(float range)
	{
		throw null;
	}

	// Token: 0x0600C5D8 RID: 50648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMipStreamingBufferSize(int size)
	{
		throw null;
	}

	// Token: 0x0600C5D9 RID: 50649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMipStreamingIOCount(int count)
	{
		throw null;
	}

	// Token: 0x0600C5DA RID: 50650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSSAO(ESSAOMode ssaoMode)
	{
		throw null;
	}

	// Token: 0x0600C5DB RID: 50651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSharpen(float strength)
	{
		throw null;
	}

	// Token: 0x0600C5DC RID: 50652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSSR(ESSRMode ssrMode)
	{
		throw null;
	}

	// Token: 0x0600C5DD RID: 50653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetSSREnabled()
	{
		throw null;
	}

	// Token: 0x0600C5DE RID: 50654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAntiAliasing(EAntialiasingMode quality, EDLSSMode dlssMode, EFSR2Mode fsr2Mode)
	{
		throw null;
	}

	// Token: 0x0600C5DF RID: 50655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetZBlur(bool enable)
	{
		throw null;
	}

	// Token: 0x0600C5E0 RID: 50656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFSR(EFSRMode fsrMode)
	{
		throw null;
	}

	// Token: 0x0600C5E1 RID: 50657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFSR2(EFSR2Mode fsr2Mode)
	{
		throw null;
	}

	// Token: 0x0600C5E2 RID: 50658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reset()
	{
		throw null;
	}

	// Token: 0x0600C5E3 RID: 50659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14<T>() where T : Component
	{
		throw null;
	}

	// Token: 0x0600C5E4 RID: 50660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15()
	{
		throw null;
	}

	// Token: 0x0600C5E5 RID: 50661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600C5E6 RID: 50662 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16()
	{
		throw null;
	}

	// Token: 0x0600C5E7 RID: 50663 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17(float x)
	{
		throw null;
	}

	// Token: 0x0600C5E8 RID: 50664 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(int x)
	{
		throw null;
	}

	// Token: 0x0400C785 RID: 51077
	private static CameraClass gclass2943_0;

	// Token: 0x0400C786 RID: 51078
	public const string CAMERA_NAME = "FPS Camera";

	// Token: 0x0400C787 RID: 51079
	private static readonly int int_0;

	// Token: 0x0400C788 RID: 51080
	[CompilerGenerated]
	private readonly GClass2944 gclass2944_0;

	// Token: 0x0400C789 RID: 51081
	[CompilerGenerated]
	private EffectsController effectsController_0;

	// Token: 0x0400C78A RID: 51082
	[CompilerGenerated]
	private HideoutCameraFlashlight hideoutCameraFlashlight_0;

	// Token: 0x0400C78B RID: 51083
	[CompilerGenerated]
	private HighLightMesh highLightMesh_0;

	// Token: 0x0400C78C RID: 51084
	[CompilerGenerated]
	private VisorEffect visorEffect_0;

	// Token: 0x0400C78D RID: 51085
	[CompilerGenerated]
	private HysteresisFilter hysteresisFilter_0;

	// Token: 0x0400C78E RID: 51086
	[CompilerGenerated]
	private NightVision nightVision_0;

	// Token: 0x0400C78F RID: 51087
	[CompilerGenerated]
	private ThermalVision thermalVision_0;

	// Token: 0x0400C790 RID: 51088
	[CompilerGenerated]
	private GradingPostFX gradingPostFX_0;

	// Token: 0x0400C791 RID: 51089
	[CompilerGenerated]
	private Action<float> action_0;

	// Token: 0x0400C792 RID: 51090
	[CompilerGenerated]
	private Camera camera_0;

	// Token: 0x0400C793 RID: 51091
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400C794 RID: 51092
	[CompilerGenerated]
	private Action<int> action_2;

	// Token: 0x0400C795 RID: 51093
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400C796 RID: 51094
	[CompilerGenerated]
	private float float_0;

	// Token: 0x0400C797 RID: 51095
	public readonly GClass2949 ReflexController;

	// Token: 0x0400C798 RID: 51096
	public const float OpticsFov = 35f;

	// Token: 0x0400C799 RID: 51097
	public const float AimDeltaFov = 15f;

	// Token: 0x0400C79A RID: 51098
	private CameraLodBiasController cameraLodBiasController_0;

	// Token: 0x0400C79B RID: 51099
	private PostProcessVolume postProcessVolume_0;

	// Token: 0x0400C79D RID: 51101
	private PostProcessLayer postProcessLayer_0;

	// Token: 0x0400C79E RID: 51102
	private CC_Sharpen cc_Sharpen_0;

	// Token: 0x0400C79F RID: 51103
	private HBAO hbao_0;

	// Token: 0x0400C7A1 RID: 51105
	private PrismEffects prismEffects_0;

	// Token: 0x0400C7A2 RID: 51106
	private global::ChromaticAberration chromaticAberration_0;

	// Token: 0x0400C7A3 RID: 51107
	private float float_1;

	// Token: 0x0400C7A4 RID: 51108
	private Coroutine coroutine_0;

	// Token: 0x0400C7A5 RID: 51109
	private InventoryBlur inventoryBlur_0;

	// Token: 0x0400C7A6 RID: 51110
	private SSAA ssaa_0;

	// Token: 0x0400C7A7 RID: 51111
	private SSAAImpl ssaaimpl_0;

	// Token: 0x0400C7A8 RID: 51112
	private bool? nullable_0;

	// Token: 0x0400C7A9 RID: 51113
	private VolumetricLightRenderer volumetricLightRenderer_0;

	// Token: 0x0400C7AA RID: 51114
	private StreamingController streamingController_0;

	// Token: 0x0400C7AC RID: 51116
	private readonly List<Action> list_0;

	// Token: 0x0400C7AD RID: 51117
	private Renderer[] renderer_0;

	// Token: 0x0400C7AE RID: 51118
	private Renderer[] renderer_1;

	// Token: 0x020026FA RID: 9978
	public interface GInterface350
	{
		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x0600C5E9 RID: 50665
		[CanBeNull]
		Camera CameraPrefab { get; }

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600C5EA RID: 50666
		[CanBeNull]
		PrismPreset PrismPresetPrefab { get; }

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600C5EB RID: 50667
		[CanBeNull]
		PostProcessProfile PostProcessProfilePrefab { get; }
	}

	// Token: 0x020026FB RID: 9979
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2241
	{
		// Token: 0x0600C5EC RID: 50668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(OcclusionCullingSwitcher switcher)
		{
			throw null;
		}

		// Token: 0x0400C7AF RID: 51119
		public static readonly CameraClass.Class2241 class2241_0;

		// Token: 0x0400C7B0 RID: 51120
		public static Func<OcclusionCullingSwitcher, bool> func_0;
	}
}
