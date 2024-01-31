using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002963 RID: 10595
	public sealed class EnvironmentUI : MonoBehaviourSingleton<EnvironmentUI>
	{
		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0600D2FA RID: 54010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D2FB RID: 54011 RVA: 0x00002050 File Offset: 0x00000250
		public EEventType[] Events
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

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D2FD RID: 54013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D2FE RID: 54014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600D2FF RID: 54015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task RefreshEnvironmentAsync()
		{
			throw null;
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task SetEnvironmentAsync(EnvironmentUI.EEnvironmentUIType environmentUiType)
		{
			throw null;
		}

		// Token: 0x0600D301 RID: 54017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(string sceneName)
		{
			throw null;
		}

		// Token: 0x0600D302 RID: 54018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRotation()
		{
			throw null;
		}

		// Token: 0x0600D303 RID: 54019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAsMain(bool isMain, bool rotateForced)
		{
			throw null;
		}

		// Token: 0x0600D304 RID: 54020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEnvironment(bool value)
		{
			throw null;
		}

		// Token: 0x0600D305 RID: 54021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeShading(EShadingType shadingType)
		{
			throw null;
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowCameraContainer(bool value)
		{
			throw null;
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableOverlay(bool enable)
		{
			throw null;
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate()
		{
			throw null;
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private EnvironmentUI.EEnvironmentUIType method_1()
		{
			throw null;
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EnvironmentUI.EEnvironmentUIType x)
		{
			throw null;
		}

		// Token: 0x0400D4CE RID: 54478
		private static readonly List<GameObject> list_0;

		// Token: 0x0400D4CF RID: 54479
		[SerializeField]
		private Camera _alignmentCamera;

		// Token: 0x0400D4D0 RID: 54480
		[SerializeField]
		private GameObject _commonContainer;

		// Token: 0x0400D4D1 RID: 54481
		[SerializeField]
		private EnvironmentUI.EnvironmentData[] _environments;

		// Token: 0x0400D4D2 RID: 54482
		[SerializeField]
		private EnvironmentShading _environmentShading;

		// Token: 0x0400D4D3 RID: 54483
		private EnvironmentUIRoot environmentUIRoot_0;

		// Token: 0x0400D4D4 RID: 54484
		private EnvironmentUI.EEnvironmentUIType eenvironmentUIType_0;

		// Token: 0x0400D4D5 RID: 54485
		private bool bool_0;

		// Token: 0x0400D4D6 RID: 54486
		private readonly GClass763 gclass763_0;

		// Token: 0x0400D4D7 RID: 54487
		private bool bool_1;

		// Token: 0x0400D4D8 RID: 54488
		private EEventType[] eeventType_0;

		// Token: 0x02002964 RID: 10596
		public enum EEnvironmentUIType
		{
			// Token: 0x0400D4DA RID: 54490
			RandomEnvironmentUiType,
			// Token: 0x0400D4DB RID: 54491
			FactoryEnvironmentUiType,
			// Token: 0x0400D4DC RID: 54492
			WoodEnvironmentUiType,
			// Token: 0x0400D4DD RID: 54493
			LaboratoryEnvironmentUiType
		}

		// Token: 0x02002965 RID: 10597
		[Serializable]
		private struct EnvironmentData
		{
			// Token: 0x0400D4DE RID: 54494
			public EnvironmentUI.EEnvironmentUIType Type;

			// Token: 0x0400D4DF RID: 54495
			public string SceneName;
		}
	}
}
