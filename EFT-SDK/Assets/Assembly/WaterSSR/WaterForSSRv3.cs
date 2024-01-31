using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WaterSSR
{
	// Token: 0x02000C28 RID: 3112
	public class WaterForSSRv3 : MonoBehaviour
	{
		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x060043D5 RID: 17365 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D6 RID: 17366 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<WaterForSSRv3> OnAdd
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

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x060043D7 RID: 17367 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D8 RID: 17368 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action<WaterForSSRv3> OnRemove
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

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00002050 File Offset: 0x00000250
		public WaterSettings Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
		public WaterObject[] Targets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MaterialPropertyBlock GetSettingsBlock()
		{
			throw null;
		}

		// Token: 0x04004D34 RID: 19764
		[CompilerGenerated]
		private static Action<WaterForSSRv3> action_0;

		// Token: 0x04004D35 RID: 19765
		[CompilerGenerated]
		private static Action<WaterForSSRv3> action_1;

		// Token: 0x04004D36 RID: 19766
		[SerializeField]
		private WaterSettings _settings;

		// Token: 0x04004D37 RID: 19767
		[SerializeField]
		[Space(5f)]
		private WaterObject[] _targets;

		// Token: 0x04004D38 RID: 19768
		private MaterialPropertyBlock materialPropertyBlock_0;
	}
}
