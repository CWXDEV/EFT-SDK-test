using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002969 RID: 10601
	public sealed class EnvironmentUIRoot : MonoBehaviour
	{

		// Token: 0x0600D312 RID: 54034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Camera alignmentCamera, IReadOnlyCollection<EEventType> events, bool isMain)
		{
			throw null;
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Camera newCam)
		{
			throw null;
		}

		// Token: 0x0600D314 RID: 54036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCameraActive(bool value)
		{
			throw null;
		}

		// Token: 0x0600D315 RID: 54037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMain(bool isMain)
		{
			throw null;
		}

		// Token: 0x0600D316 RID: 54038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetEvents(IReadOnlyCollection<EEventType> events)
		{
			throw null;
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomRotate()
		{
			throw null;
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1()
		{
			throw null;
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRotation()
		{
			throw null;
		}

		// Token: 0x0400D4EE RID: 54510
		private const float float_0 = 1f;

		// Token: 0x0400D4EF RID: 54511
		public CanvasGroup Shading;

		// Token: 0x0400D4F0 RID: 54512
		[SerializeField]
		private Transform CameraContainer;

		// Token: 0x0400D4F1 RID: 54513
		[SerializeField]
		private Light[] MainScreenLights;

		// Token: 0x0400D4F2 RID: 54514
		[SerializeField]
		private GameObject[] MainScreenObjects;

		// Token: 0x0400D4F3 RID: 54515
		[SerializeField]
		private ScreenPositionAnchor[] ScreenAnchors;

		// Token: 0x0400D4F4 RID: 54516
		[SerializeField]
		private EnvironmentUIRoot.EnvironmentEventObject[] EventObjects;

		// Token: 0x0200296A RID: 10602
		[Serializable]
		private struct EnvironmentEventObject
		{
			// Token: 0x0400D4F6 RID: 54518
			public EEventType EventType;

			// Token: 0x0400D4F7 RID: 54519
			public GameObject[] GameObjects;
		}
	}
}
