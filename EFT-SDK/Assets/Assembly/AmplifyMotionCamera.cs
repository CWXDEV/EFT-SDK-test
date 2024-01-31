using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200005B RID: 91
[AddComponentMenu("")]
[RequireComponent(typeof(Camera))]
public class AmplifyMotionCamera : MonoBehaviour
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	public bool Initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	public bool AutoStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
	public bool Overlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	public Camera Camera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterObject(AmplifyMotionObjectBase obj)
	{
		throw null;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterObject(AmplifyMotionObjectBase obj)
	{
		throw null;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LinkTo(AmplifyMotionEffectBase instance, bool overlay)
	{
		throw null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAutoStep()
	{
		throw null;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartAutoStep()
	{
		throw null;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Step()
	{
		throw null;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixedUpdateTransform(AmplifyMotionEffectBase inst, CommandBuffer updateCB)
	{
		throw null;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTransform(AmplifyMotionEffectBase inst, CommandBuffer updateCB)
	{
		throw null;
	}

	// Token: 0x0400012B RID: 299
	internal AmplifyMotionEffectBase Instance;

	// Token: 0x0400012C RID: 300
	internal Matrix4x4 PrevViewProjMatrix;

	// Token: 0x0400012D RID: 301
	internal Matrix4x4 ViewProjMatrix;

	// Token: 0x0400012E RID: 302
	internal Matrix4x4 InvViewProjMatrix;

	// Token: 0x0400012F RID: 303
	internal Matrix4x4 PrevViewProjMatrixRT;

	// Token: 0x04000130 RID: 304
	internal Matrix4x4 ViewProjMatrixRT;

	// Token: 0x04000131 RID: 305
	internal Transform Transform;

	// Token: 0x04000132 RID: 306
	private bool m_linked;

	// Token: 0x04000133 RID: 307
	private bool m_initialized;

	// Token: 0x04000134 RID: 308
	private bool m_starting;

	// Token: 0x04000135 RID: 309
	private bool m_autoStep;

	// Token: 0x04000136 RID: 310
	private bool m_step;

	// Token: 0x04000137 RID: 311
	private bool m_overlay;

	// Token: 0x04000138 RID: 312
	private Camera m_camera;

	// Token: 0x04000139 RID: 313
	private int m_prevFrameCount;

	// Token: 0x0400013A RID: 314
	private HashSet<AmplifyMotionObjectBase> m_affectedObjectsTable;

	// Token: 0x0400013B RID: 315
	private AmplifyMotionObjectBase[] m_affectedObjects;

	// Token: 0x0400013C RID: 316
	private bool m_affectedObjectsChanged;

	// Token: 0x0400013D RID: 317
	private const CameraEvent m_renderCBEvent = CameraEvent.BeforeImageEffects;

	// Token: 0x0400013E RID: 318
	private CommandBuffer m_renderCB;
}
