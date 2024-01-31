using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	// Token: 0x02000E54 RID: 3668
	public class DetailDemoSceneController : MonoBehaviour
	{
		// Token: 0x06004CA6 RID: 19622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(DetailDemoSceneController.CameraModes cameraMode)
		{
			throw null;
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(DetailDemoSceneController.QualityMode qualityMode)
		{
			throw null;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(DetailDemoSceneController.QualityMode qualityMode)
		{
			throw null;
		}

		// Token: 0x040057D5 RID: 22485
		public GameObject fpController;

		// Token: 0x040057D6 RID: 22486
		public GameObject spaceshipCamera;

		// Token: 0x040057D7 RID: 22487
		public GameObject grassMowerCamera;

		// Token: 0x040057D8 RID: 22488
		public GPUInstancerDetailManager detailManager;

		// Token: 0x040057D9 RID: 22489
		public bool persistRemoval;

		// Token: 0x040057DA RID: 22490
		private GameObject gameObject_0;

		// Token: 0x040057DB RID: 22491
		private GameObject gameObject_1;

		// Token: 0x040057DC RID: 22492
		private GameObject gameObject_2;

		// Token: 0x040057DD RID: 22493
		private GameObject gameObject_3;

		// Token: 0x040057DE RID: 22494
		private Text text_0;

		// Token: 0x040057DF RID: 22495
		private Transform transform_0;

		// Token: 0x040057E0 RID: 22496
		private Transform transform_1;

		// Token: 0x040057E1 RID: 22497
		private GameObject gameObject_4;

		// Token: 0x040057E2 RID: 22498
		private DetailDemoSceneController.CameraModes cameraModes_0;

		// Token: 0x040057E3 RID: 22499
		private ParticleSystem particleSystem_0;

		// Token: 0x040057E4 RID: 22500
		private DetailDemoSceneController.QualityMode qualityMode_0;

		// Token: 0x040057E5 RID: 22501
		private List<int[,]> list_0;

		// Token: 0x02000E55 RID: 3669
		private enum CameraModes
		{
			// Token: 0x040057E7 RID: 22503
			FPMode,
			// Token: 0x040057E8 RID: 22504
			SpaceshipMode,
			// Token: 0x040057E9 RID: 22505
			MowerMode
		}

		// Token: 0x02000E56 RID: 3670
		private enum QualityMode
		{
			// Token: 0x040057EB RID: 22507
			Low,
			// Token: 0x040057EC RID: 22508
			Mid,
			// Token: 0x040057ED RID: 22509
			High
		}
	}
}
