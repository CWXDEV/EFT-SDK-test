using System;

namespace EFT.Animations
{
	// Token: 0x02001EF6 RID: 7926
	public interface IEffector
	{
		// Token: 0x0600A3B0 RID: 41904
		void Initialize(PlayerSpring playerSpring);

		// Token: 0x0600A3B1 RID: 41905
		void Process(float deltaTime);

		// Token: 0x0600A3B2 RID: 41906
		string DebugOutput();
	}
}
