using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;

namespace EFT
{
	// Token: 0x020016C6 RID: 5830
	public abstract class ClientApplication<T> : AbstractApplication where T : class, GInterface144
	{
		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x00002050 File Offset: 0x00000250
		protected override EUpdateQueue PlayerUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06007DD5 RID: 32213 RVA: 0x00002050 File Offset: 0x00000250
		protected T Session
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass635 CreateLogConfigurator()
		{
			throw null;
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task Start()
		{
			throw null;
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetClientBackEndSession()
		{
			throw null;
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IEnumerator CheckNVidiaReflexAvailability()
		{
			throw null;
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init(IAssetsManager assetsManager, InputTree inputTree)
		{
			throw null;
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void DestroyApplication()
		{
			throw null;
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x040084AD RID: 33965
		protected IBackendInterface<T> ClientBackEnd;

		// Token: 0x040084AE RID: 33966
		protected InputTree _inputTree;

		// Token: 0x040084AF RID: 33967
		protected BundleLock BundleLock;

		// Token: 0x040084B0 RID: 33968
		private Class2316 class2316_0;
	}
}
