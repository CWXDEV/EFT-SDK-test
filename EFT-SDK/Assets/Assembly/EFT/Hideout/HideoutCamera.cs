using System;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BDA RID: 7130
	public sealed class HideoutCamera : MonoBehaviour, IDisposable
	{
		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060095B6 RID: 38326 RVA: 0x00002050 File Offset: 0x00000250
		public Transform Transform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060095B7 RID: 38327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060095B8 RID: 38328 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
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

		// Token: 0x060095B9 RID: 38329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ECameraMoveType cameraMoveType)
		{
			throw null;
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Zoom(float? zoom)
		{
			throw null;
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Tick()
		{
			throw null;
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPosition(object position)
		{
			throw null;
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCameraActive(bool value)
		{
			throw null;
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Move(Vector3 direction)
		{
			throw null;
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(float x)
		{
			throw null;
		}

		// Token: 0x04009C71 RID: 40049
		private const int int_0 = 10;

		// Token: 0x04009C72 RID: 40050
		private const float float_0 = 0.5f;

		// Token: 0x04009C73 RID: 40051
		private const float float_1 = 10f;

		// Token: 0x04009C74 RID: 40052
		[SerializeField]
		private CinemachineVirtualCamera _virtualCamera;

		// Token: 0x04009C75 RID: 40053
		[SerializeField]
		private RailCameraMoveSettings _railCameraMoveSettings;

		// Token: 0x04009C76 RID: 40054
		[SerializeField]
		private FreeSpaceCameraMoveSettings _freeSpaceCameraMoveSettings;

		// Token: 0x04009C77 RID: 40055
		private float float_2;

		// Token: 0x04009C78 RID: 40056
		private float float_3;

		// Token: 0x04009C79 RID: 40057
		private ECameraMoveType ecameraMoveType_0;

		// Token: 0x04009C7A RID: 40058
		private GInterface174 ginterface174_0;

		// Token: 0x04009C7B RID: 40059
		public static bool NegativeDirection;
	}
}
