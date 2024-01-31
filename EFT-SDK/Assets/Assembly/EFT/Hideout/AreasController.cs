using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001A98 RID: 6808
	public sealed class AreasController : SerializedMonoBehaviour, IEventSystemHandler, GInterface162
	{
		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<ELightingLevel> IEnumerable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EAreaType, HideoutArea> Areas
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideoutAwake()
		{
			throw null;
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ELightingLevel level, bool switchToNewLevel)
		{
			throw null;
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select(AreaData data, bool wait)
		{
			throw null;
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool value)
		{
			throw null;
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(AreaData data, bool value)
		{
			throw null;
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x04009691 RID: 38545
		public static readonly IReadOnlyCollection<ELightingLevel> LightingPriority;

		// Token: 0x04009692 RID: 38546
		[SerializeField]
		private HideoutCameraController _hideoutCameraController;

		// Token: 0x04009693 RID: 38547
		[SerializeField]
		private AmbianceController _ambianceController;

		// Token: 0x04009694 RID: 38548
		[SerializeField]
		private Dictionary<ELightingLevel, GameObject> _globalLighting;

		// Token: 0x04009695 RID: 38549
		[SerializeField]
		private Dictionary<EAreaType, HideoutArea> _areas;

		// Token: 0x04009696 RID: 38550
		private HideoutScreenOverlay hideoutScreenOverlay_0;

		// Token: 0x04009697 RID: 38551
		private EnergyControllerClass gclass1901_0;

		// Token: 0x04009698 RID: 38552
		private GClass763 gclass763_0;

		// Token: 0x04009699 RID: 38553
		private readonly HashSet<ELightingLevel> hashSet_0;

		// Token: 0x0400969A RID: 38554
		private ELightingLevel elightingLevel_0;

		// Token: 0x0400969B RID: 38555
		private bool bool_0;

		// Token: 0x02001A99 RID: 6809
		[CompilerGenerated]
		private sealed class Class1595
		{
			// Token: 0x06008F65 RID: 36709 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400969C RID: 38556
			public HideoutClass hideout;

			// Token: 0x0400969D RID: 38557
			public AreasController areasController_0;
		}

		// Token: 0x02001A9A RID: 6810
		[CompilerGenerated]
		private sealed class Class1596
		{
			// Token: 0x06008F66 RID: 36710 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06008F67 RID: 36711 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x06008F68 RID: 36712 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(bool value)
			{
				throw null;
			}

			// Token: 0x06008F69 RID: 36713 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0400969E RID: 38558
			public AreaData data;

			// Token: 0x0400969F RID: 38559
			public GClass1924 behaviour;

			// Token: 0x040096A0 RID: 38560
			public AreasController.Class1595 class1595_0;
		}
	}
}
