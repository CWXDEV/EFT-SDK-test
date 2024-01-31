using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Hideout;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027D8 RID: 10200
	public sealed class GarlandSwitcher : InteractiveAmbianceObject<GarlandSwitcher.GarlandPattern>, GInterface351
	{
		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600CC64 RID: 52324 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CC65 RID: 52325 RVA: 0x00002050 File Offset: 0x00000250
		public new bool Enabled
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

		// Token: 0x0600CC66 RID: 52326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Switch(Turnable.EState switchTo)
		{
			throw null;
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GarlandSwitcher.EPatternType pattern, float speed)
		{
			throw null;
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GarlandSwitcher.ELightType color)
		{
			throw null;
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Light light, bool active)
		{
			throw null;
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Material material, bool active)
		{
			throw null;
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_7(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x0400CC7B RID: 52347
		[SerializeField]
		private Dictionary<GarlandSwitcher.ELightType, List<Light>> _lights;

		// Token: 0x0400CC7C RID: 52348
		[SerializeField]
		private Dictionary<GarlandSwitcher.ELightType, int> _materialIndexes;

		// Token: 0x0400CC7D RID: 52349
		[SerializeField]
		private GameObject _garland;

		// Token: 0x0400CC7E RID: 52350
		[SerializeField]
		private List<GarlandSwitcher.ELightType> _order;

		// Token: 0x0400CC7F RID: 52351
		public float Intensity;

		// Token: 0x0400CC80 RID: 52352
		public float EmissionPower;

		// Token: 0x0400CC81 RID: 52353
		private Dictionary<GarlandSwitcher.ELightType, Material> dictionary_1;

		// Token: 0x0400CC82 RID: 52354
		private bool bool_4;

		// Token: 0x0400CC83 RID: 52355
		private float float_0;

		// Token: 0x0400CC84 RID: 52356
		private GarlandSwitcher.EPatternType epatternType_0;

		// Token: 0x0400CC85 RID: 52357
		private Turnable.EState estate_0;

		// Token: 0x0400CC86 RID: 52358
		private GarlandSwitcher.Class2307 class2307_0;

		// Token: 0x020027D9 RID: 10201
		public enum ELightType
		{
			// Token: 0x0400CC88 RID: 52360
			None,
			// Token: 0x0400CC89 RID: 52361
			Green,
			// Token: 0x0400CC8A RID: 52362
			Blue,
			// Token: 0x0400CC8B RID: 52363
			Red,
			// Token: 0x0400CC8C RID: 52364
			Any = 100
		}

		// Token: 0x020027DA RID: 10202
		public enum EPatternType
		{
			// Token: 0x0400CC8E RID: 52366
			Linear,
			// Token: 0x0400CC8F RID: 52367
			Random,
			// Token: 0x0400CC90 RID: 52368
			OnOff
		}

		// Token: 0x020027DB RID: 10203
		private sealed class Class2307
		{
			// Token: 0x0600CC6F RID: 52335 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Run(float time, Action callback)
			{
				throw null;
			}

			// Token: 0x0600CC70 RID: 52336 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0600CC71 RID: 52337 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_0(float time)
			{
				throw null;
			}

			// Token: 0x0400CC91 RID: 52369
			private Action action_0;

			// Token: 0x020027DC RID: 10204
			[CompilerGenerated]
			private sealed class Class2308
			{
				// Token: 0x0600CC72 RID: 52338 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400CC92 RID: 52370
				public Action callback;
			}
		}

		// Token: 0x020027DE RID: 10206
		[Serializable]
		public sealed class GarlandPattern
		{
			// Token: 0x0400CC99 RID: 52377
			public bool Active;

			// Token: 0x0400CC9A RID: 52378
			public float Speed;
		}

		// Token: 0x020027E0 RID: 10208
		[CompilerGenerated]
		private sealed class Class2309
		{
			// Token: 0x0600CC77 RID: 52343 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CCA0 RID: 52384
			public GarlandSwitcher garlandSwitcher_0;

			// Token: 0x0400CCA1 RID: 52385
			public int index;
		}
	}
}
