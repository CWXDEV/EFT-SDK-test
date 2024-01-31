using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BD6 RID: 7126
	[Serializable]
	public class FreeSpaceCameraMoveSettings
	{
		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x00002050 File Offset: 0x00000250
		public float MoveSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x0600959E RID: 38302 RVA: 0x00002050 File Offset: 0x00000250
		public float MouseRotationSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x0600959F RID: 38303 RVA: 0x00002050 File Offset: 0x00000250
		public float AutoRotationSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060095A0 RID: 38304 RVA: 0x00002050 File Offset: 0x00000250
		public float ScreenEdgeDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060095A1 RID: 38305 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 DefaultVirtualCameraLocalPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 DefaultVirtualCameraLocalRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<float, float> GetXCameraBorder()
		{
			throw null;
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<float, float> GetZCameraBorder()
		{
			throw null;
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ValueTuple<float, float> method_0(ref ValueTuple<float, float>? boundValue, float localPosition, float localScale)
		{
			throw null;
		}

		// Token: 0x04009C59 RID: 40025
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x04009C5A RID: 40026
		[SerializeField]
		private float _mouseRotationSpeed;

		// Token: 0x04009C5B RID: 40027
		[SerializeField]
		private float _autoRotationSpeed;

		// Token: 0x04009C5C RID: 40028
		[SerializeField]
		private float _screenEdgeDelta;

		// Token: 0x04009C5D RID: 40029
		[SerializeField]
		private Transform _bounds;

		// Token: 0x04009C5E RID: 40030
		[SerializeField]
		private Vector3 _defaultVirtualCameraLocalPosition;

		// Token: 0x04009C5F RID: 40031
		[SerializeField]
		private Vector3 _defaultVirtualCameraLocalRotation;

		// Token: 0x04009C60 RID: 40032
		private Transform _cachedBounds;

		// Token: 0x04009C61 RID: 40033
		private ValueTuple<float, float>? _xCameraBorder;

		// Token: 0x04009C62 RID: 40034
		private ValueTuple<float, float>? _zCameraBorder;
	}
}
