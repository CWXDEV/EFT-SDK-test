using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x020012F7 RID: 4855
	public sealed class GameDateTime
	{
		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600649F RID: 25759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064A0 RID: 25760 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x00002050 File Offset: 0x00000250
		internal DateTime DateTime_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		internal DateTime DateTime_1
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameDateTime smethod_0(DateTime realDateTime, ref string gameDate, ref string gameTime, ref float timeFactor, bool debug = false)
		{
			throw null;
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime smethod_1(string date, string time)
		{
			throw null;
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTime method_0()
		{
			throw null;
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameDateTime CreateDebug()
		{
			throw null;
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateTime Calculate()
		{
			throw null;
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateTime CalculateTaxonomyDate(DateTime todSkyDateTime)
		{
			throw null;
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset(DateTime gameDateTime)
		{
			throw null;
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset(DateTime realDateTime, string gameDate, string gameTime, float timeFactor)
		{
			throw null;
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetForce(DateTime gameDateTime)
		{
			throw null;
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset(DateTime realDateTime, DateTime gameDateTime, float timeFactor)
		{
			throw null;
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset(DateTime realDateTime, DateTime gameDateTime, float timeFactor, bool force)
		{
			throw null;
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameDateTime Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(NetworkWriter writer, bool gameOnly)
		{
			throw null;
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Validate(ref string date, ref string time, ref float timeFactor, bool init)
		{
			throw null;
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x00002050 File Offset: 0x00000250
		public bool Locked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Lock()
		{
			throw null;
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Unlock()
		{
			throw null;
		}

		// Token: 0x04007121 RID: 28961
		public float TimeFactorMod;

		// Token: 0x04007122 RID: 28962
		private float _realtimeSinceStartup;

		// Token: 0x04007123 RID: 28963
		private const string DateFormat = "d";

		// Token: 0x04007124 RID: 28964
		private const string TimeFormat = "HH:mm:ss";

		// Token: 0x04007125 RID: 28965
		private bool _locked;
	}
}
