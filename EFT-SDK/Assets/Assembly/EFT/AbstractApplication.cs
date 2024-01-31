using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001192 RID: 4498
	public abstract class AbstractApplication : MonoBehaviour
	{
		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06005F83 RID: 24451
		protected abstract EUpdateQueue PlayerUpdateQueue { get; }

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x00002050 File Offset: 0x00000250
		private static bool Initialized
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Awake()
		{
			throw null;
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateTechnicalSystems()
		{
			throw null;
		}

		// Token: 0x06005F88 RID: 24456
		protected abstract GClass635 CreateLogConfigurator();

		// Token: 0x06005F89 RID: 24457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0()
		{
			throw null;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06005F8B RID: 24459 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F8C RID: 24460 RVA: 0x00002050 File Offset: 0x00000250
		public bool Destroyed
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

		// Token: 0x06005F8D RID: 24461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Destroy()
		{
			throw null;
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string s)
		{
			throw null;
		}

		// Token: 0x04006979 RID: 27001
		public GClass619 Logger;

		// Token: 0x0400697A RID: 27002
		private static bool bool_0;

		// Token: 0x0400697B RID: 27003
		[CompilerGenerated]
		private static bool bool_1;

		// Token: 0x0400697C RID: 27004
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x02001193 RID: 4499
		[CompilerGenerated]
		[Serializable]
		private sealed class Class873
		{
			// Token: 0x06005F91 RID: 24465 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
			{
				throw null;
			}

			// Token: 0x0400697D RID: 27005
			public static readonly AbstractApplication.Class873 class873_0;

			// Token: 0x0400697E RID: 27006
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
		}
	}
}
