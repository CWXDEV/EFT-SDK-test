using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dissonance.Networking;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001306 RID: 4870
	internal sealed class TrafficCollectScenario : MonoBehaviour
	{
		// Token: 0x060064E0 RID: 25824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TrafficCollectScenario smethod_0(GInterface100 game, TimeSpan? step = null, TrafficCollectScenario.Class339 logger = null)
		{
			throw null;
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060064E1 RID: 25825 RVA: 0x00002050 File Offset: 0x00000250
		private static TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1477 TrafficData()
		{
			throw null;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TrafficCollectScenario.Struct203 method_0()
		{
			throw null;
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GStruct130 smethod_1(TrafficCounter counter)
		{
			throw null;
		}

		// Token: 0x0400715E RID: 29022
		private GInterface100 ginterface100_0;

		// Token: 0x0400715F RID: 29023
		private TimeSpan timeSpan_0;

		// Token: 0x04007160 RID: 29024
		private TrafficCollectScenario.Class339 class339_0;

		// Token: 0x04007161 RID: 29025
		private DateTime dateTime_0;

		// Token: 0x04007162 RID: 29026
		private readonly List<TrafficCollectScenario.Struct203> list_0;

		// Token: 0x04007163 RID: 29027
		private TrafficCollectScenario.Struct203 struct203_0;

		// Token: 0x02001307 RID: 4871
		internal sealed class Class339 : LoggerClass
		{
		}

		// Token: 0x02001308 RID: 4872
		[StructLayout(LayoutKind.Auto)]
		public struct Struct203
		{
			// Token: 0x04007164 RID: 29028
			public TimeSpan TimeSpan;

			// Token: 0x04007165 RID: 29029
			public GStruct130 GameSent;

			// Token: 0x04007166 RID: 29030
			public GStruct130 GameReceived;

			// Token: 0x04007167 RID: 29031
			public GStruct130 VoipSent;

			// Token: 0x04007168 RID: 29032
			public GStruct130 VoipReceived;
		}
	}
}
